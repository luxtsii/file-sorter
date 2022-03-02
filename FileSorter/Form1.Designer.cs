﻿namespace FileSorter
{
    partial class Form1
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
            this.folderPathBox = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.folderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderPathBox
            // 
            this.folderPathBox.Location = new System.Drawing.Point(13, 13);
            this.folderPathBox.Name = "folderPathBox";
            this.folderPathBox.ReadOnly = true;
            this.folderPathBox.Size = new System.Drawing.Size(340, 20);
            this.folderPathBox.TabIndex = 0;
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(379, 14);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(96, 20);
            this.selectFolder.TabIndex = 1;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(379, 40);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(96, 23);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sort Folder";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 45);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 74);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.folderPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPathBox;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.FolderBrowserDialog folderSelect;
        private System.Windows.Forms.Label outputLabel;
    }
}

