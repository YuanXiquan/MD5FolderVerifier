using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Configuration;

namespace MD5Verifier
{
    public partial class MainForm : Form
    {

        public string LogFileName
        {
            get
            {
                return ConfigurationManager.AppSettings["LogFileName"];
            }
        }
        
        delegate void StringParameterDelegate(string value);
        delegate void IntParameterDelegate(int finished, int total);
        private MD5ChecksumVerifier Verifier;
        private List<string> ErrorLog;
        private StringBuilder _sb;
        private int _counter;
        private Thread VerifierThread;

        public MainForm()
        {
            InitializeComponent();
            this.Verifier = new MD5ChecksumVerifier(this);
            this.ErrorLog = new List<string>();
            _sb = new StringBuilder();
            _counter = 0;
        }

        private void PathSelectButton_Click(object sender, EventArgs e)
        {
            CheckSumFolderBrowserDialog.ShowDialog();
            this.WorkingPathTextBox.Text = CheckSumFolderBrowserDialog.SelectedPath;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.ClearStatus();
            string path = this.WorkingPathTextBox.Text;
            this.Verifier.SetCurrentDirectory(path);
            this.AppendNewLineToOutput("Start Verify");
            
            this.VerifierThread = new Thread(new ThreadStart(this.Verifier.Verify));
            this.VerifierThread.Start();

            // disable button
            this.GenerateButton.Enabled = false;
        }

        private void ClearStatus()
        {
            this.ErrorLog = new List<string>();
            _sb = new StringBuilder();
            _counter = 0;
            this.OutputTextBox.Clear();
        }

        public void GenerateFinished(string path)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(GenerateFinished), new object[] { path });
                return;
            }

            this.AppendNewLineToOutput("Verify Finished");
            this.AppendNewLineToOutput("");


            string errLogPath = Path.Combine(path, this.LogFileName);

            if (!File.Exists(errLogPath))
            {
                using (StreamWriter sw = File.CreateText(errLogPath)) { }
            }

            using (StreamWriter sw = File.AppendText(errLogPath))
            {
                sw.WriteLine("================================================");
                sw.WriteLine(DateTime.Now.ToUniversalTime().ToString("u"));

                foreach (string each in this.ErrorLog)
                {
                    sw.WriteLine(each);
                }
            }

            foreach (string each in this.ErrorLog)
            {
                this.AppendNewLineToOutput(each);
            }

            // enable button
            this.GenerateButton.Enabled = true;

            this._counter = 200;
            this.AppendNewLineToOutput("");
            OutputTextBox.SelectionStart = OutputTextBox.Text.Length;
            OutputTextBox.ScrollToCaret();
            OutputTextBox.Refresh();
        }

        public void AppendNewLineToOutput(string line)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(AppendNewLineToOutput), new object[] { line });
                return;
            }
            
            _sb.AppendLine(line);

            if (_counter >= 20)
            {
                this.OutputTextBox.AppendText(_sb.ToString());
                _sb = new StringBuilder();
                _counter = 0;
            }
            else
            {
                _counter++;
            }
        }

        public void AppendLineToLog(string line)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(AppendLineToLog), new object[] { line });
                return;
            }

            this.ErrorLog.Add(line);
            this.AppendNewLineToOutput(line);
        }

        public void UpdateStatus(int finished, int total)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new IntParameterDelegate(UpdateStatus), new object[] { finished, total });
                return;
            }

            if(total == 0)
            {
                return;
            }


            this.VerifyProgressBar.Maximum = total;
            this.VerifyProgressBar.Value = finished;
        }
    }
}
