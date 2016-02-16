namespace mkLink {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.targetSelectFileButton = new System.Windows.Forms.Button();
            this.targetSelectFolderButton = new System.Windows.Forms.Button();
            this.selectLinkButton = new System.Windows.Forms.Button();
            this.createLinkButton = new System.Windows.Forms.Button();
            this.typeDescriptionLabel = new System.Windows.Forms.Label();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createdByLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
            this.linkGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.targetGroupBox.SuspendLayout();
            this.linkGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetTextBox
            // 
            this.targetTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.targetTextBox.Location = new System.Drawing.Point(10, 23);
            this.targetTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(532, 20);
            this.targetTextBox.TabIndex = 2;
            this.targetTextBox.TextChanged += new System.EventHandler(this.targetTextBox_TextChanged);
            // 
            // linkTextBox
            // 
            this.linkTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkTextBox.Location = new System.Drawing.Point(10, 23);
            this.linkTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(532, 20);
            this.linkTextBox.TabIndex = 3;
            this.linkTextBox.TextChanged += new System.EventHandler(this.linkTextBox_TextChanged);
            // 
            // targetSelectFileButton
            // 
            this.targetSelectFileButton.Location = new System.Drawing.Point(100, 48);
            this.targetSelectFileButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.targetSelectFileButton.Name = "targetSelectFileButton";
            this.targetSelectFileButton.Size = new System.Drawing.Size(85, 25);
            this.targetSelectFileButton.TabIndex = 6;
            this.targetSelectFileButton.Text = "Select File";
            this.targetSelectFileButton.UseVisualStyleBackColor = true;
            this.targetSelectFileButton.Click += new System.EventHandler(this.targetSelectFileButton_Click);
            // 
            // targetSelectFolderButton
            // 
            this.targetSelectFolderButton.Location = new System.Drawing.Point(10, 48);
            this.targetSelectFolderButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.targetSelectFolderButton.Name = "targetSelectFolderButton";
            this.targetSelectFolderButton.Size = new System.Drawing.Size(85, 25);
            this.targetSelectFolderButton.TabIndex = 8;
            this.targetSelectFolderButton.Text = "Select Folder";
            this.targetSelectFolderButton.UseVisualStyleBackColor = true;
            this.targetSelectFolderButton.Click += new System.EventHandler(this.targetSelectFolderButton_Click);
            // 
            // selectLinkButton
            // 
            this.selectLinkButton.Location = new System.Drawing.Point(10, 48);
            this.selectLinkButton.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.selectLinkButton.Name = "selectLinkButton";
            this.selectLinkButton.Size = new System.Drawing.Size(85, 25);
            this.selectLinkButton.TabIndex = 9;
            this.selectLinkButton.Text = "Select Link";
            this.selectLinkButton.UseVisualStyleBackColor = true;
            this.selectLinkButton.Click += new System.EventHandler(this.selectLinkButton_Click);
            // 
            // createLinkButton
            // 
            this.createLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createLinkButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createLinkButton.Enabled = false;
            this.createLinkButton.Location = new System.Drawing.Point(389, 6);
            this.createLinkButton.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.createLinkButton.Name = "createLinkButton";
            this.createLinkButton.Size = new System.Drawing.Size(90, 30);
            this.createLinkButton.TabIndex = 10;
            this.createLinkButton.Text = "Create Link";
            this.createLinkButton.UseVisualStyleBackColor = false;
            this.createLinkButton.Click += new System.EventHandler(this.createLinkButton_Click);
            // 
            // typeDescriptionLabel
            // 
            this.typeDescriptionLabel.AutoSize = true;
            this.typeDescriptionLabel.Location = new System.Drawing.Point(190, 23);
            this.typeDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.typeDescriptionLabel.Name = "typeDescriptionLabel";
            this.typeDescriptionLabel.Size = new System.Drawing.Size(241, 13);
            this.typeDescriptionLabel.TabIndex = 12;
            this.typeDescriptionLabel.Text = "Creates a symbolic link, also known as a shortcut.";
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(50, 60);
            this.aboutLinkLabel.Location = new System.Drawing.Point(0, 0);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(305, 17);
            this.aboutLinkLabel.TabIndex = 1;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "mkLink creates multiple types of symbolic links.  Learn More";
            this.aboutLinkLabel.UseCompatibleTextRendering = true;
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.learnMoreLinkLabel_LinkClicked);
            // 
            // createdByLinkLabel
            // 
            this.createdByLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createdByLinkLabel.AutoSize = true;
            this.createdByLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(11, 32);
            this.createdByLinkLabel.Location = new System.Drawing.Point(373, 0);
            this.createdByLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.createdByLinkLabel.Name = "createdByLinkLabel";
            this.createdByLinkLabel.Size = new System.Drawing.Size(179, 17);
            this.createdByLinkLabel.TabIndex = 2;
            this.createdByLinkLabel.TabStop = true;
            this.createdByLinkLabel.Text = "Created by JamRizzi Technologies";
            this.createdByLinkLabel.UseCompatibleTextRendering = true;
            this.createdByLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createdByLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel1.Size = new System.Drawing.Size(574, 289);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.typeGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.targetGroupBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.linkGroupBox, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 279);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.aboutLinkLabel);
            this.panel3.Controls.Add(this.createdByLinkLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 23);
            this.panel3.TabIndex = 15;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.typeDescriptionLabel);
            this.typeGroupBox.Controls.Add(this.typeComboBox);
            this.typeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeGroupBox.Location = new System.Drawing.Point(0, 23);
            this.typeGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.typeGroupBox.Size = new System.Drawing.Size(552, 56);
            this.typeGroupBox.TabIndex = 17;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Symbolic Link",
            "Hard Link / Directory Junction"});
            this.typeComboBox.Location = new System.Drawing.Point(10, 23);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(175, 21);
            this.typeComboBox.TabIndex = 15;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged_1);
            // 
            // targetGroupBox
            // 
            this.targetGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetGroupBox.Controls.Add(this.targetTextBox);
            this.targetGroupBox.Controls.Add(this.targetSelectFolderButton);
            this.targetGroupBox.Controls.Add(this.targetSelectFileButton);
            this.targetGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetGroupBox.Location = new System.Drawing.Point(0, 89);
            this.targetGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.targetGroupBox.Name = "targetGroupBox";
            this.targetGroupBox.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.targetGroupBox.Size = new System.Drawing.Size(552, 85);
            this.targetGroupBox.TabIndex = 13;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "Target";
            // 
            // linkGroupBox
            // 
            this.linkGroupBox.Controls.Add(this.linkTextBox);
            this.linkGroupBox.Controls.Add(this.selectLinkButton);
            this.linkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkGroupBox.Enabled = false;
            this.linkGroupBox.Location = new System.Drawing.Point(0, 184);
            this.linkGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.linkGroupBox.Name = "linkGroupBox";
            this.linkGroupBox.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.linkGroupBox.Size = new System.Drawing.Size(552, 85);
            this.linkGroupBox.TabIndex = 14;
            this.linkGroupBox.TabStop = false;
            this.linkGroupBox.Text = "Link";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 330);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.createLinkButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 41);
            this.panel2.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelButton.Location = new System.Drawing.Point(484, 6);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Home
            // 
            this.AcceptButton = this.createLinkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(9999, 374);
            this.MinimumSize = new System.Drawing.Size(600, 374);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Text = "mkLink";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.targetGroupBox.ResumeLayout(false);
            this.targetGroupBox.PerformLayout();
            this.linkGroupBox.ResumeLayout(false);
            this.linkGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button targetSelectFileButton;
        private System.Windows.Forms.Button targetSelectFolderButton;
        private System.Windows.Forms.Button selectLinkButton;
        private System.Windows.Forms.Button createLinkButton;
        private System.Windows.Forms.Label typeDescriptionLabel;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.LinkLabel createdByLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox targetGroupBox;
        private System.Windows.Forms.GroupBox linkGroupBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
    }
}

