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
using System.Runtime.Versioning;

namespace MD5FolderVerifier
{
    [SupportedOSPlatform("windows")]
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
        delegate void LogGridParameterDelegate(string value, LogGrid gridValue);
        delegate void IntParameterDelegate(int finished, int total);
        private MD5ChecksumVerifier Verifier;
        private List<string> ErrorLog;
        private StringBuilder _sb;
        private int _counter;
        private Thread VerifierThread;
        private BindingList<LogGrid> LogGridList;

        public MainForm()
        {
            InitializeComponent();
            this.Verifier = new MD5ChecksumVerifier(this);
            this.ErrorLog = [];
            _sb = new StringBuilder();
            _counter = 0;

            this.WorkingPathTextBox.KeyDown += new KeyEventHandler(WorkingPathCheckKeys);

            this.InitOutputDataGrid();

            this.WorkingPathTextBox.Select();
        }

        private void WorkingPathCheckKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.Generate();
            }

        }



        private void InitOutputDataGrid()
        {
            this.OutputDataGridView.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.DataPropertyName = "MessageType";
            typeColumn.HeaderText = "Type";
            typeColumn.MinimumWidth = 20;
            typeColumn.Width = 30;

            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.DataPropertyName = "MessageText";
            textColumn.HeaderText = "Message";
            textColumn.MinimumWidth = 400;
            textColumn.MinimumWidth = 400;

            DataGridViewTextBoxColumn resultColumn = new DataGridViewTextBoxColumn();
            resultColumn.DataPropertyName = "MessageResult";
            resultColumn.HeaderText = "Result";

            this.OutputDataGridView.Columns.Add(typeColumn);
            this.OutputDataGridView.Columns.Add(textColumn);
            this.OutputDataGridView.Columns.Add(resultColumn);

            this.LogGridList = [];
            this.OutputDataGridView.DataSource = this.LogGridList;
        }

        private void PathSelectButton_Click(object sender, EventArgs e)
        {
            CheckSumFolderBrowserDialog.ShowDialog();
            this.WorkingPathTextBox.Text = CheckSumFolderBrowserDialog.SelectedPath;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.Generate();
        }

        private void Generate()
        {
            this.ClearStatus();
            string path = this.WorkingPathTextBox.Text;
            int numOfThreads = (int)this.ThreadNumericUpDown.Value;
            this.Verifier.SetCurrentDirectory(path);
            this.Verifier.SetNumOfThreads(numOfThreads);
            this.AppendNormalMsg("Start Verify");
            
            this.VerifierThread = new Thread(new ThreadStart(this.Verifier.Verify));
            this.VerifierThread.Start();

            // disable button
            this.GenerateButton.Enabled = false;
        }

        private void ClearStatus()
        {
            this.ErrorLog = [];
            _sb = new StringBuilder();
            _counter = 0;
            this.OutputTextBox.Clear();
            this.LogGridList.Clear();
        }

        public void GenerateFinished(string path)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(GenerateFinished), new object[] { path });
                return;
            }

            if (Directory.Exists(path))
            {
                this.AppendNormalMsg("Verify Finished");
                this.AppendNormalMsg("");


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
                    this.AppendNormalMsg(each);
                }
            }

            // enable button
            this.GenerateButton.Enabled = true;

            this._counter = 200;
            this.AppendNormalMsg("");
            OutputTextBox.SelectionStart = OutputTextBox.Text.Length;
            OutputTextBox.ScrollToCaret();
            OutputTextBox.Refresh();
        }

        public void AppendNormalMsg(string line)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(AppendNormalMsg), new object[] { line });
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

        public void AppendErrorMsg(string line, LogGrid gridValue)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new LogGridParameterDelegate(AppendErrorMsg), new object[] { line, gridValue });
                return;
            }

            this.LogGridList.Add(gridValue);

            this.ErrorLog.Add(line);
            this.AppendNormalMsg(line);
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

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.WorkingPathTextBox.Select();
            this.WorkingPathTextBox.SelectAll();
        }

    }
}
