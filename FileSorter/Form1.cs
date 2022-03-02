using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            DialogResult selectedFolder = folderSelect.ShowDialog();

            if (selectedFolder == DialogResult.OK)
            {
                folderPathBox.Text = folderSelect.SelectedPath;
                outputLabel.Text = "";
            }
        }

        private void SortFolders(string filePath)
        {
            string[] files = Directory.GetFiles(filePath);

            foreach (string file in files)
            {
                string fileType = file.Split('.')[file.Split('.').Length - 1];
                string fileName = file.Split('\\')[file.Split('\\').Length - 1];

                if (Directory.Exists(filePath + "\\" + fileType.ToUpper()))
                {
                    File.Move(file, filePath + "\\" + fileType.ToUpper() + "\\" + fileName);
                } 
                else
                {
                    Directory.CreateDirectory(filePath + "\\" + fileType.ToUpper());
                    File.Move(file, filePath + "\\" + fileType.ToUpper() + "\\" + fileName);
                }
            }

            outputLabel.Text = "Done!";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (folderPathBox.Text == "")
            {
                outputLabel.Text = "No folder selected.";
            } 
            else if (!Directory.Exists(folderPathBox.Text))
            {
                outputLabel.Text = "Matching folder not found.";
            }
            else
            {
                SortFolders(folderPathBox.Text);
            }
        }
    }
}
