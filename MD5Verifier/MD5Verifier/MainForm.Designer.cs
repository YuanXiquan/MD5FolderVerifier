namespace MD5FolderVerifier
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            WorkingPathLabel = new System.Windows.Forms.Label();
            WorkingPathTextBox = new System.Windows.Forms.TextBox();
            PathSelectButton = new System.Windows.Forms.Button();
            CheckSumFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            OutputTextBox = new System.Windows.Forms.TextBox();
            GenerateButton = new System.Windows.Forms.Button();
            VerifyProgressBar = new System.Windows.Forms.ProgressBar();
            CentreTabControl = new System.Windows.Forms.TabControl();
            ConsolePage = new System.Windows.Forms.TabPage();
            OutputPage = new System.Windows.Forms.TabPage();
            OutputDataGridView = new System.Windows.Forms.DataGridView();
            TopInputPanel = new System.Windows.Forms.Panel();
            ThreadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            NumOfThreadLabel = new System.Windows.Forms.Label();
            CentreTabControl.SuspendLayout();
            ConsolePage.SuspendLayout();
            OutputPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OutputDataGridView).BeginInit();
            TopInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ThreadNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // WorkingPathLabel
            // 
            WorkingPathLabel.AutoSize = true;
            WorkingPathLabel.Location = new System.Drawing.Point(16, 31);
            WorkingPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            WorkingPathLabel.Name = "WorkingPathLabel";
            WorkingPathLabel.Size = new System.Drawing.Size(96, 20);
            WorkingPathLabel.TabIndex = 0;
            WorkingPathLabel.Text = "Working Path";
            // 
            // WorkingPathTextBox
            // 
            WorkingPathTextBox.Location = new System.Drawing.Point(16, 70);
            WorkingPathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            WorkingPathTextBox.Name = "WorkingPathTextBox";
            WorkingPathTextBox.Size = new System.Drawing.Size(723, 27);
            WorkingPathTextBox.TabIndex = 1;
            // 
            // PathSelectButton
            // 
            PathSelectButton.Location = new System.Drawing.Point(757, 66);
            PathSelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PathSelectButton.Name = "PathSelectButton";
            PathSelectButton.Size = new System.Drawing.Size(100, 35);
            PathSelectButton.TabIndex = 2;
            PathSelectButton.Text = "Path";
            PathSelectButton.UseVisualStyleBackColor = true;
            PathSelectButton.Click += PathSelectButton_Click;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            OutputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            OutputTextBox.Location = new System.Drawing.Point(4, 5);
            OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            OutputTextBox.Size = new System.Drawing.Size(863, 797);
            OutputTextBox.TabIndex = 3;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new System.Drawing.Point(757, 107);
            GenerateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new System.Drawing.Size(100, 35);
            GenerateButton.TabIndex = 4;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // VerifyProgressBar
            // 
            VerifyProgressBar.Location = new System.Drawing.Point(16, 107);
            VerifyProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            VerifyProgressBar.Name = "VerifyProgressBar";
            VerifyProgressBar.Size = new System.Drawing.Size(723, 35);
            VerifyProgressBar.TabIndex = 5;
            // 
            // CentreTabControl
            // 
            CentreTabControl.Controls.Add(ConsolePage);
            CentreTabControl.Controls.Add(OutputPage);
            CentreTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            CentreTabControl.Location = new System.Drawing.Point(0, 178);
            CentreTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CentreTabControl.Name = "CentreTabControl";
            CentreTabControl.SelectedIndex = 0;
            CentreTabControl.Size = new System.Drawing.Size(879, 840);
            CentreTabControl.TabIndex = 6;
            // 
            // ConsolePage
            // 
            ConsolePage.Controls.Add(OutputTextBox);
            ConsolePage.Location = new System.Drawing.Point(4, 29);
            ConsolePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ConsolePage.Name = "ConsolePage";
            ConsolePage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ConsolePage.Size = new System.Drawing.Size(871, 807);
            ConsolePage.TabIndex = 0;
            ConsolePage.Text = "Console";
            ConsolePage.UseVisualStyleBackColor = true;
            // 
            // OutputPage
            // 
            OutputPage.Controls.Add(OutputDataGridView);
            OutputPage.Location = new System.Drawing.Point(4, 29);
            OutputPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OutputPage.Name = "OutputPage";
            OutputPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OutputPage.Size = new System.Drawing.Size(871, 807);
            OutputPage.TabIndex = 1;
            OutputPage.Text = "Output";
            OutputPage.UseVisualStyleBackColor = true;
            // 
            // OutputDataGridView
            // 
            OutputDataGridView.AllowUserToAddRows = false;
            OutputDataGridView.AllowUserToDeleteRows = false;
            OutputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            OutputDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            OutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            OutputDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            OutputDataGridView.Location = new System.Drawing.Point(4, 5);
            OutputDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OutputDataGridView.Name = "OutputDataGridView";
            OutputDataGridView.ReadOnly = true;
            OutputDataGridView.RowHeadersVisible = false;
            OutputDataGridView.RowHeadersWidth = 51;
            OutputDataGridView.ShowEditingIcon = false;
            OutputDataGridView.Size = new System.Drawing.Size(863, 797);
            OutputDataGridView.TabIndex = 0;
            // 
            // TopInputPanel
            // 
            TopInputPanel.Controls.Add(ThreadNumericUpDown);
            TopInputPanel.Controls.Add(NumOfThreadLabel);
            TopInputPanel.Controls.Add(WorkingPathTextBox);
            TopInputPanel.Controls.Add(VerifyProgressBar);
            TopInputPanel.Controls.Add(WorkingPathLabel);
            TopInputPanel.Controls.Add(GenerateButton);
            TopInputPanel.Controls.Add(PathSelectButton);
            TopInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopInputPanel.Location = new System.Drawing.Point(0, 0);
            TopInputPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TopInputPanel.Name = "TopInputPanel";
            TopInputPanel.Size = new System.Drawing.Size(879, 168);
            TopInputPanel.TabIndex = 7;
            // 
            // ThreadNumericUpDown
            // 
            ThreadNumericUpDown.Location = new System.Drawing.Point(757, 29);
            ThreadNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ThreadNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ThreadNumericUpDown.Name = "ThreadNumericUpDown";
            ThreadNumericUpDown.Size = new System.Drawing.Size(100, 27);
            ThreadNumericUpDown.TabIndex = 6;
            ThreadNumericUpDown.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // NumOfThreadLabel
            // 
            NumOfThreadLabel.AutoSize = true;
            NumOfThreadLabel.Location = new System.Drawing.Point(600, 31);
            NumOfThreadLabel.Name = "NumOfThreadLabel";
            NumOfThreadLabel.Size = new System.Drawing.Size(139, 20);
            NumOfThreadLabel.TabIndex = 0;
            NumOfThreadLabel.Text = "Number Of Threads";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(879, 1018);
            Controls.Add(TopInputPanel);
            Controls.Add(CentreTabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "MD5 Checksum Verifier";
            Activated += MainForm_Activated;
            CentreTabControl.ResumeLayout(false);
            ConsolePage.ResumeLayout(false);
            ConsolePage.PerformLayout();
            OutputPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OutputDataGridView).EndInit();
            TopInputPanel.ResumeLayout(false);
            TopInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ThreadNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label WorkingPathLabel;
        private System.Windows.Forms.TextBox WorkingPathTextBox;
        private System.Windows.Forms.Button PathSelectButton;
        private System.Windows.Forms.FolderBrowserDialog CheckSumFolderBrowserDialog;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ProgressBar VerifyProgressBar;
        private System.Windows.Forms.TabControl CentreTabControl;
        private System.Windows.Forms.TabPage ConsolePage;
        private System.Windows.Forms.TabPage OutputPage;
        private System.Windows.Forms.DataGridView OutputDataGridView;
        private System.Windows.Forms.Panel TopInputPanel;
        private System.Windows.Forms.Label NumOfThreadLabel;
        private System.Windows.Forms.NumericUpDown ThreadNumericUpDown;
    }
}

