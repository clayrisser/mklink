using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace mkLink {
    public partial class Home : Form {

        private string initialFileFolderName = "";
        private bool targetIsFile = true;
        private bool linkIsFile = true;

        public Home(string fileName) {
            InitializeComponent();
            if (fileName != "") { // Program run from another file
                SelectTarget(fileName);
                SelectLink();
            }
            this.typeComboBox.Text = "Symbolic Link";
        }


        private void typeComboBox_SelectedIndexChanged_1(object sender, EventArgs e) {
            this.typeDescriptionLabel.Text = this.typeComboBox.Text.FindDescription();
        }


        private void targetSelectFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dialogResult = ofd.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                SelectTarget(ofd.FileName);
            }
        }


        private void targetSelectFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dialogResult = fbd.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                SelectTarget(fbd.SelectedPath);
            }
        }


        private void selectLinkButton_Click(object sender, EventArgs e) {
            SelectLink();
        }


        private void createLinkButton_Click(object sender, EventArgs e) {
            string link = this.linkTextBox.Text;
            string target = this.targetTextBox.Text;

            // Determine type
            string type = ""; // File symbolic link
            switch (this.typeComboBox.Text) {
                default:
                    if (!this.targetIsFile) {
                        type = "/D"; // Directory symbolic link
                    }
                    break;
                case "Hard Link / Directory Junction":
                    if (this.targetIsFile) {
                        type = "/H"; // Hard link
                    } else {
                        type = "/J"; // Directory junction
                    }
                    break;
            }

            // MKLINK [[/D] | [/H] | [/J]] Link Target
            string response = CMD.Execute("MKLINK " + type + " \"" + link + "\" \"" + target + "\"");
            MessageBox.Show(response);
        }


        private void targetTextBox_TextChanged(object sender, EventArgs e) {
            this.targetIsFile = this.targetTextBox.Text.IsFile();
            bool validPath = true;
            if (this.targetIsFile) {
                validPath = File.Exists(this.targetTextBox.Text);
            } else {
                validPath = Directory.Exists(this.targetTextBox.Text);
            }
            if (validPath) {
                this.linkGroupBox.Enabled = true;
            } else {
                this.linkGroupBox.Enabled = false;
            }
            if (targetIsFile != linkIsFile) {
                this.createLinkButton.Enabled = false;
            }
        }


        private void linkTextBox_TextChanged(object sender, EventArgs e) {
            this.linkIsFile = this.linkTextBox.Text.IsFile();
            try {
                string directoryName = Path.GetDirectoryName(this.linkTextBox.Text);
                bool validPath = Directory.Exists(directoryName);
                if (validPath) {
                    this.createLinkButton.Enabled = true;
                } else {
                    this.createLinkButton.Enabled = false;
                }
            } catch (ArgumentException) {
                this.createLinkButton.Enabled = false;
            }
            if (targetIsFile != linkIsFile) {
                this.createLinkButton.Enabled = false;
            }
        }


        private void learnMoreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://technet.microsoft.com/en-us/library/cc753194.aspx");
        }


        private void createdByLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://jamrizzi.com");
        }


        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void SelectTarget(string path) {
            this.targetTextBox.Text = path;
            if (this.targetIsFile) {
                this.initialFileFolderName = Path.GetFileName(path);
                this.selectLinkButton.Enabled = true;
            } else {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                this.initialFileFolderName = directoryInfo.Name;
                this.selectLinkButton.Enabled = true;
            }
        }


        private void SelectLink() {
            if (this.targetIsFile) { // Item is a file
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = this.initialFileFolderName;
                DialogResult dialogResult = sfd.ShowDialog();
                if (dialogResult == DialogResult.OK) {
                    this.linkTextBox.Text = sfd.FileName;
                }
            } else { // Item is a folder
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult dialogResult = fbd.ShowDialog();
                if (dialogResult == DialogResult.OK) {
                    this.linkTextBox.Text = fbd.SelectedPath + "\\" + this.initialFileFolderName;
                }
            }
        }
    }
}
