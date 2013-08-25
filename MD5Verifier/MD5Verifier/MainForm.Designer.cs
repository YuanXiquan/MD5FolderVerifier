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
            this.WorkingPathLabel = new System.Windows.Forms.Label();
            this.WorkingPathTextBox = new System.Windows.Forms.TextBox();
            this.PathSelectButton = new System.Windows.Forms.Button();
            this.CheckSumFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.VerifyProgressBar = new System.Windows.Forms.ProgressBar();
            this.CentreTabControl = new System.Windows.Forms.TabControl();
            this.ConsolePage = new System.Windows.Forms.TabPage();
            this.OutputPage = new System.Windows.Forms.TabPage();
            this.OutputDataGridView = new System.Windows.Forms.DataGridView();
            this.TopInputPanel = new System.Windows.Forms.Panel();
            this.CentreTabControl.SuspendLayout();
            this.ConsolePage.SuspendLayout();
            this.OutputPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGridView)).BeginInit();
            this.TopInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingPathLabel
            // 
            this.WorkingPathLabel.AutoSize = true;
            this.WorkingPathLabel.Location = new System.Drawing.Point(12, 22);
            this.WorkingPathLabel.Name = "WorkingPathLabel";
            this.WorkingPathLabel.Size = new System.Drawing.Size(72, 13);
            this.WorkingPathLabel.TabIndex = 0;
            this.WorkingPathLabel.Text = "Working Path";
            // 
            // WorkingPathTextBox
            // 
            this.WorkingPathTextBox.Location = new System.Drawing.Point(12, 38);
            this.WorkingPathTextBox.Name = "WorkingPathTextBox";
            this.WorkingPathTextBox.Size = new System.Drawing.Size(541, 20);
            this.WorkingPathTextBox.TabIndex = 1;
            // 
            // PathSelectButton
            // 
            this.PathSelectButton.Location = new System.Drawing.Point(568, 35);
            this.PathSelectButton.Name = "PathSelectButton";
            this.PathSelectButton.Size = new System.Drawing.Size(75, 23);
            this.PathSelectButton.TabIndex = 2;
            this.PathSelectButton.Text = "Path";
            this.PathSelectButton.UseVisualStyleBackColor = true;
            this.PathSelectButton.Click += new System.EventHandler(this.PathSelectButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(3, 3);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(645, 514);
            this.OutputTextBox.TabIndex = 3;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(568, 64);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // VerifyProgressBar
            // 
            this.VerifyProgressBar.Location = new System.Drawing.Point(12, 64);
            this.VerifyProgressBar.Name = "VerifyProgressBar";
            this.VerifyProgressBar.Size = new System.Drawing.Size(542, 23);
            this.VerifyProgressBar.TabIndex = 5;
            // 
            // CentreTabControl
            // 
            this.CentreTabControl.Controls.Add(this.ConsolePage);
            this.CentreTabControl.Controls.Add(this.OutputPage);
            this.CentreTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CentreTabControl.Location = new System.Drawing.Point(0, 116);
            this.CentreTabControl.Name = "CentreTabControl";
            this.CentreTabControl.SelectedIndex = 0;
            this.CentreTabControl.Size = new System.Drawing.Size(659, 546);
            this.CentreTabControl.TabIndex = 6;
            // 
            // ConsolePage
            // 
            this.ConsolePage.Controls.Add(this.OutputTextBox);
            this.ConsolePage.Location = new System.Drawing.Point(4, 22);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsolePage.Size = new System.Drawing.Size(651, 520);
            this.ConsolePage.TabIndex = 0;
            this.ConsolePage.Text = "Console";
            this.ConsolePage.UseVisualStyleBackColor = true;
            // 
            // OutputPage
            // 
            this.OutputPage.Controls.Add(this.OutputDataGridView);
            this.OutputPage.Location = new System.Drawing.Point(4, 22);
            this.OutputPage.Name = "OutputPage";
            this.OutputPage.Padding = new System.Windows.Forms.Padding(3);
            this.OutputPage.Size = new System.Drawing.Size(651, 520);
            this.OutputPage.TabIndex = 1;
            this.OutputPage.Text = "Output";
            this.OutputPage.UseVisualStyleBackColor = true;
            // 
            // OutputDataGridView
            // 
            this.OutputDataGridView.AllowUserToAddRows = false;
            this.OutputDataGridView.AllowUserToDeleteRows = false;
            this.OutputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutputDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.OutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.OutputDataGridView.Location = new System.Drawing.Point(3, 3);
            this.OutputDataGridView.Name = "OutputDataGridView";
            this.OutputDataGridView.ReadOnly = true;
            this.OutputDataGridView.RowHeadersVisible = false;
            this.OutputDataGridView.ShowEditingIcon = false;
            this.OutputDataGridView.Size = new System.Drawing.Size(645, 514);
            this.OutputDataGridView.TabIndex = 0;
            // 
            // TopInputPanel
            // 
            this.TopInputPanel.Controls.Add(this.WorkingPathTextBox);
            this.TopInputPanel.Controls.Add(this.VerifyProgressBar);
            this.TopInputPanel.Controls.Add(this.WorkingPathLabel);
            this.TopInputPanel.Controls.Add(this.GenerateButton);
            this.TopInputPanel.Controls.Add(this.PathSelectButton);
            this.TopInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopInputPanel.Location = new System.Drawing.Point(0, 0);
            this.TopInputPanel.Name = "TopInputPanel";
            this.TopInputPanel.Size = new System.Drawing.Size(659, 110);
            this.TopInputPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 662);
            this.Controls.Add(this.TopInputPanel);
            this.Controls.Add(this.CentreTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MD5 Checksum Verifier";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.CentreTabControl.ResumeLayout(false);
            this.ConsolePage.ResumeLayout(false);
            this.ConsolePage.PerformLayout();
            this.OutputPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputDataGridView)).EndInit();
            this.TopInputPanel.ResumeLayout(false);
            this.TopInputPanel.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

