﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Configuration;

namespace MD5FolderVerifier
{
    class MD5ChecksumVerifier
    {
        #region Class Properties
        /// <summary>
        /// Current Directory
        /// </summary>
        public string CurrentDirectory { get; private set; }
        /// <summary>
        /// Parent Form
        /// </summary>
        public MainForm ParentForm { get; private set; }
        /// <summary>
        /// The number of total folders
        /// </summary>
        public int TotalFolders { get; private set; }
        /// <summary>
        /// The number of finished verified folders
        /// </summary>
        public int FinishedFolders { get; private set; }
        /// <summary>
        /// The name of Checksum file
        /// </summary>
        public string CheckSumFileName
        {
            get
            {
                return ConfigurationManager.AppSettings["CheckSumFileName"];
            }
        }
        /// <summary>
        /// Running Mode: Console or GUI
        /// </summary>
        public RunningMode Mode { get; private set; }
        /// <summary>
        /// Log Instance
        /// </summary>
        public VerifierLog Log { get; private set; }
        /// <summary>
        /// The extensions not included inside verification
        /// </summary>
        public string IgnoredExtensions
        {
            get
            {
                return ConfigurationManager.AppSettings["IgnoredExtensions"];
            }
        }
        #endregion

        #region Class Constructor
        public MD5ChecksumVerifier(MainForm form)
        {
            this.ParentForm = form;
            this.Mode = RunningMode.GUI;
            this.Log = new VerifierLog(this.Mode, this.ParentForm);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Set up working Directory
        /// </summary>
        /// <param name="path"></param>
        public void SetCurrentDirectory(string path)
        {
            this.CurrentDirectory = path;
        }

        /// <summary>
        /// Verify MD5s
        /// </summary>
        public void Verify()
        {
            this.VerifyMD5ForDir(this.CurrentDirectory);
            this.ParentForm.GenerateFinished(this.CurrentDirectory);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Generate MD5 for Folders inside a Folder
        /// </summary>
        /// <param name="path"></param>
        private bool VerifyMD5ForDir(string path)
        {
            this.FinishedFolders = 0;
            this.TotalFolders = 0;
            List<string> dirs = null;

            if (Directory.Exists(path))
            {
                dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories).ToList();
                dirs.Add(path);
            }
            else
            {
                this.Log.AppendLog(LogMsgType.Error, "Invalid Working Path", LogResultType.NotFound);
                return false;
            }

            this.TotalFolders = dirs.Count;

            foreach (string each in dirs)
            {
                if (this.GenerateMd5ForFiles(each))
                {
                    this.Log.AppendLog(LogMsgType.Info, each, LogResultType.GenerateSuccess);
                }
                else
                {
                    this.VerifyMd5ForFiles(each);
                }
                this.FinishedFolders++;

                this.ParentForm.UpdateStatus(this.FinishedFolders, this.TotalFolders);
            }

            return true;
        }

        /// <summary>
        /// Verify MD5 checksum for a file
        /// </summary>
        /// <param name="path"></param>
        private void VerifyMd5ForFiles(string path)
        {
            string MD5LogPath = Path.Combine(path, this.CheckSumFileName);

            if (!File.Exists(MD5LogPath))
            {
                throw new ArgumentException("Log File doesn't exist:" + MD5LogPath);
            }

            Dictionary<string, string> md5Dict = new Dictionary<string, string>();
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(MD5LogPath))
            {
                string temp = "";
                while ((temp = sr.ReadLine()) != null)
                {
                    if (temp != null && temp != "")
                    {
                        string[] lineData = temp.Split(':');
                        md5Dict[lineData[0]] = lineData[1];
                    }
                }
            }

            List<string> files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).ToList();

            List<string> resultLines = new List<string>();
            
            foreach (string each in files)
            {
                // dont process any md5 file
                if (Path.GetExtension(each).Contains(this.IgnoredExtensions))
                {
                    continue;
                }

                string fileName = Path.GetFileName(each);

                if (!md5Dict.ContainsKey(fileName))
                {
                    this.Log.AppendLog(LogMsgType.Error, each, LogResultType.NotFound);
                }
                else if (md5Dict[fileName] != this.GetMD5HashFromFile(each))
                {
                    this.Log.AppendLog(LogMsgType.Error, each, LogResultType.Mismatch);
                }
                else
                {
                    this.Log.AppendLog(LogMsgType.Info, each, LogResultType.Passed);
                }
            }
        }



        /// <summary>
        /// Generate MD5 For Files in a Directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool GenerateMd5ForFiles(string path)
        {
            string MD5LogPath = Path.Combine(path, this.CheckSumFileName);

            if (!File.Exists(MD5LogPath))
            {
                using (StreamWriter sw = File.CreateText(MD5LogPath)) { }
            }
            else
            {
                this.Log.AppendLog(LogMsgType.Warning, MD5LogPath, LogResultType.AlreadyExist);
                return false;
            }

            List<string> files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).ToList();

            List<string> resultLines = new List<string>();

            foreach (string each in files)
            {
                // dont process any md5 file
                if(Path.GetExtension(each) == ".md5log")
                {
                    continue;
                }

                resultLines.Add(Path.GetFileName(each) + ":" + this.GetMD5HashFromFile(each));
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(MD5LogPath))
            {
                foreach (string each in resultLines)
                {
                    sw.WriteLine(each);
                }
            }

            return true;
        }


        /// <summary>
        /// Generate MD5 hash from a give file path
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetMD5HashFromFile(string fileName)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal;
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
                retVal = md5.ComputeHash(file);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
        #endregion

    }
}
