﻿namespace MD5FolderVerifier
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
            this.SuspendLayout();
            // 
            // WorkingPathLabel
            // 
            this.WorkingPathLabel.AutoSize = true;
            this.WorkingPathLabel.Location = new System.Drawing.Point(13, 13);
            this.WorkingPathLabel.Name = "WorkingPathLabel";
            this.WorkingPathLabel.Size = new System.Drawing.Size(72, 13);
            this.WorkingPathLabel.TabIndex = 0;
            this.WorkingPathLabel.Text = "Working Path";
            // 
            // WorkingPathTextBox
            // 
            this.WorkingPathTextBox.Location = new System.Drawing.Point(13, 30);
            this.WorkingPathTextBox.Name = "WorkingPathTextBox";
            this.WorkingPathTextBox.Size = new System.Drawing.Size(541, 20);
            this.WorkingPathTextBox.TabIndex = 1;
            // 
            // PathSelectButton
            // 
            this.PathSelectButton.Location = new System.Drawing.Point(560, 27);
            this.PathSelectButton.Name = "PathSelectButton";
            this.PathSelectButton.Size = new System.Drawing.Size(75, 23);
            this.PathSelectButton.TabIndex = 2;
            this.PathSelectButton.Text = "Path";
            this.PathSelectButton.UseVisualStyleBackColor = true;
            this.PathSelectButton.Click += new System.EventHandler(this.PathSelectButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(13, 85);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(622, 506);
            this.OutputTextBox.TabIndex = 3;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(560, 56);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // VerifyProgressBar
            // 
            this.VerifyProgressBar.Location = new System.Drawing.Point(12, 56);
            this.VerifyProgressBar.Name = "VerifyProgressBar";
            this.VerifyProgressBar.Size = new System.Drawing.Size(542, 23);
            this.VerifyProgressBar.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 603);
            this.Controls.Add(this.VerifyProgressBar);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.PathSelectButton);
            this.Controls.Add(this.WorkingPathTextBox);
            this.Controls.Add(this.WorkingPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MD5 Checksum Verifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkingPathLabel;
        private System.Windows.Forms.TextBox WorkingPathTextBox;
        private System.Windows.Forms.Button PathSelectButton;
        private System.Windows.Forms.FolderBrowserDialog CheckSumFolderBrowserDialog;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ProgressBar VerifyProgressBar;
    }
}

