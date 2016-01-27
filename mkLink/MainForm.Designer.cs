namespace mkLink {
    partial class mkLink {
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.targetLink = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.linkBrowseButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.linkTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.targetTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.targetBrowseButton = new System.Windows.Forms.Button();
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.typeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.createLinkButton = new System.Windows.Forms.Button();
            this.descriptionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionContent = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.linkTableLayoutPanel.SuspendLayout();
            this.targetTableLayoutPanel.SuspendLayout();
            this.bottomTableLayoutPanel.SuspendLayout();
            this.typeTableLayoutPanel.SuspendLayout();
            this.descriptionTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Symbolic Link",
            "Hard Link",
            "Directory Junction"});
            this.typeComboBox.Location = new System.Drawing.Point(3, 18);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // linkTextBox
            // 
            this.linkTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkTextBox.Location = new System.Drawing.Point(3, 3);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(494, 20);
            this.linkTextBox.TabIndex = 1;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(8, 5);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(27, 13);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.Text = "Link";
            // 
            // targetLink
            // 
            this.targetLink.AutoSize = true;
            this.targetLink.Location = new System.Drawing.Point(8, 50);
            this.targetLink.Name = "targetLink";
            this.targetLink.Size = new System.Drawing.Size(38, 13);
            this.targetLink.TabIndex = 3;
            this.targetLink.Text = "Target";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTextBox.Location = new System.Drawing.Point(3, 3);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(494, 20);
            this.targetTextBox.TabIndex = 4;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // linkBrowseButton
            // 
            this.linkBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkBrowseButton.Location = new System.Drawing.Point(504, 3);
            this.linkBrowseButton.Name = "linkBrowseButton";
            this.linkBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.linkBrowseButton.TabIndex = 6;
            this.linkBrowseButton.Text = "Browse";
            this.linkBrowseButton.UseVisualStyleBackColor = true;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.linkTableLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.linkLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.targetLink, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.targetTableLayoutPanel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.bottomTableLayoutPanel, 0, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(592, 144);
            this.mainTableLayoutPanel.TabIndex = 10;
            this.mainTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // linkTableLayoutPanel
            // 
            this.linkTableLayoutPanel.ColumnCount = 2;
            this.linkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.linkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.linkTableLayoutPanel.Controls.Add(this.linkTextBox, 0, 0);
            this.linkTableLayoutPanel.Controls.Add(this.linkBrowseButton, 1, 0);
            this.linkTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkTableLayoutPanel.Location = new System.Drawing.Point(5, 20);
            this.linkTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.linkTableLayoutPanel.Name = "linkTableLayoutPanel";
            this.linkTableLayoutPanel.RowCount = 1;
            this.linkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.linkTableLayoutPanel.Size = new System.Drawing.Size(582, 30);
            this.linkTableLayoutPanel.TabIndex = 11;
            // 
            // targetTableLayoutPanel
            // 
            this.targetTableLayoutPanel.ColumnCount = 2;
            this.targetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.targetTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.targetTableLayoutPanel.Controls.Add(this.targetTextBox, 0, 0);
            this.targetTableLayoutPanel.Controls.Add(this.targetBrowseButton, 1, 0);
            this.targetTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTableLayoutPanel.Location = new System.Drawing.Point(5, 65);
            this.targetTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.targetTableLayoutPanel.Name = "targetTableLayoutPanel";
            this.targetTableLayoutPanel.RowCount = 1;
            this.targetTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.targetTableLayoutPanel.Size = new System.Drawing.Size(582, 30);
            this.targetTableLayoutPanel.TabIndex = 12;
            // 
            // targetBrowseButton
            // 
            this.targetBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.targetBrowseButton.Location = new System.Drawing.Point(504, 3);
            this.targetBrowseButton.Name = "targetBrowseButton";
            this.targetBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.targetBrowseButton.TabIndex = 7;
            this.targetBrowseButton.Text = "Browse";
            this.targetBrowseButton.UseVisualStyleBackColor = true;
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.ColumnCount = 3;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTableLayoutPanel.Controls.Add(this.typeTableLayoutPanel, 0, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.createLinkButton, 2, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.descriptionTableLayoutPanel, 1, 0);
            this.bottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(5, 95);
            this.bottomTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 1;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(582, 44);
            this.bottomTableLayoutPanel.TabIndex = 13;
            // 
            // typeTableLayoutPanel
            // 
            this.typeTableLayoutPanel.ColumnCount = 1;
            this.typeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.typeTableLayoutPanel.Controls.Add(this.typeComboBox, 0, 1);
            this.typeTableLayoutPanel.Controls.Add(this.typeLabel, 0, 0);
            this.typeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.typeTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.typeTableLayoutPanel.Name = "typeTableLayoutPanel";
            this.typeTableLayoutPanel.RowCount = 2;
            this.typeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.typeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.typeTableLayoutPanel.Size = new System.Drawing.Size(128, 44);
            this.typeTableLayoutPanel.TabIndex = 0;
            // 
            // createLinkButton
            // 
            this.createLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createLinkButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.createLinkButton.Location = new System.Drawing.Point(479, 11);
            this.createLinkButton.Name = "createLinkButton";
            this.createLinkButton.Size = new System.Drawing.Size(100, 30);
            this.createLinkButton.TabIndex = 8;
            this.createLinkButton.Text = "Create Link";
            this.createLinkButton.UseVisualStyleBackColor = false;
            // 
            // descriptionTableLayoutPanel
            // 
            this.descriptionTableLayoutPanel.ColumnCount = 1;
            this.descriptionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.descriptionTableLayoutPanel.Controls.Add(this.descriptionLabel, 0, 0);
            this.descriptionTableLayoutPanel.Controls.Add(this.descriptionContent, 0, 1);
            this.descriptionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTableLayoutPanel.Location = new System.Drawing.Point(128, 0);
            this.descriptionTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.descriptionTableLayoutPanel.Name = "descriptionTableLayoutPanel";
            this.descriptionTableLayoutPanel.RowCount = 2;
            this.descriptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.descriptionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.descriptionTableLayoutPanel.Size = new System.Drawing.Size(348, 44);
            this.descriptionTableLayoutPanel.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionLabel.TabIndex = 0;
            // 
            // descriptionContent
            // 
            this.descriptionContent.AutoSize = true;
            this.descriptionContent.Location = new System.Drawing.Point(3, 23);
            this.descriptionContent.Name = "descriptionContent";
            this.descriptionContent.Size = new System.Drawing.Size(108, 13);
            this.descriptionContent.TabIndex = 1;
            this.descriptionContent.Text = "No description found.";
            // 
            // mkLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 144);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "mkLink";
            this.Text = "mkLink";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.linkTableLayoutPanel.ResumeLayout(false);
            this.linkTableLayoutPanel.PerformLayout();
            this.targetTableLayoutPanel.ResumeLayout(false);
            this.targetTableLayoutPanel.PerformLayout();
            this.bottomTableLayoutPanel.ResumeLayout(false);
            this.typeTableLayoutPanel.ResumeLayout(false);
            this.typeTableLayoutPanel.PerformLayout();
            this.descriptionTableLayoutPanel.ResumeLayout(false);
            this.descriptionTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.Label targetLink;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button linkBrowseButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel linkTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel targetTableLayoutPanel;
        private System.Windows.Forms.Button targetBrowseButton;
        private System.Windows.Forms.Button createLinkButton;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel typeTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel descriptionTableLayoutPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionContent;
    }
}

