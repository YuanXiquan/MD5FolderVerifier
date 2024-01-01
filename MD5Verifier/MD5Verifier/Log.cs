using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace MD5FolderVerifier
{
    [SupportedOSPlatform("windows")]
    class VerifierLog
    {
        #region Class Properties
        /// <summary>
        /// Running Mode: Console or GUI
        /// </summary>
        public RunningMode Mode { get; private set; }
        /// <summary>
        /// Parent Form
        /// </summary>
        public MainForm ParentForm { get; private set; }
        #endregion

        #region Class Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mode">running mode</param>
        /// <param name="parentForm">GUI instance</param>
        public VerifierLog(RunningMode mode, MainForm parentForm)
        {
            this.Mode = mode;
            this.ParentForm = parentForm;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Append a new Log
        /// </summary>
        /// <param name="msgType">message type</param>
        /// <param name="msg">message string</param>
        /// <param name="resultType">result type</param>
        public void AppendLog(LogMsgType msgType, string msg, LogResultType resultType)
        {
            string outputStr = "";
            string msgTypeStr = "";
            string resultTypeStr = "";

            switch (msgType)
            {
                case LogMsgType.Error:
                    msgTypeStr = "Error";
                    break;
                case LogMsgType.Info:
                    msgTypeStr = "Info";
                    break;
                case LogMsgType.Warning:
                    msgTypeStr = "Warning";
                    break;
                default:
                    throw new NotImplementedException();
            }

            switch(resultType)
            {
                case LogResultType.AlreadyExist:
                    resultTypeStr = "Already Exist";
                    break;
                case LogResultType.GenerateSuccess:
                    resultTypeStr = "Generate Success";
                    break;
                case LogResultType.Mismatch:
                    resultTypeStr = "Checksum Mismatch";
                    break;
                case LogResultType.NotFound:
                    resultTypeStr = "Record Not Found";
                    break;
                case LogResultType.Passed:
                    resultTypeStr = "Passed";
                    break;
                default:
                    throw new NotImplementedException();
            }

            outputStr = msgTypeStr + " | " + msg + " | " + resultTypeStr;
            if(msgType == LogMsgType.Error)
            {
                LogGrid gridValue = new LogGrid(msgTypeStr, msg, resultTypeStr);
                this.ParentForm.AppendErrorMsg(outputStr, gridValue);
            }
            else
            {
                this.ParentForm.AppendNormalMsg(outputStr);
            }
        }
        #endregion
    }
}
