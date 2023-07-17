namespace SubRenamer
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.VersionText = new System.Windows.Forms.Label();
            this.UpdateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.RawSubtitleBuckup = new System.Windows.Forms.CheckBox();
            this.ListShowFileFullName = new System.Windows.Forms.CheckBox();
            this.ListItemRemovePrompt = new System.Windows.Forms.CheckBox();
            this.BlogLabel = new System.Windows.Forms.LinkLabel();
            this.RenameVideo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxVideoExtension = new System.Windows.Forms.ListBox();
            this.listBoxSubExtension = new System.Windows.Forms.ListBox();
            this.labelVideoExtension = new System.Windows.Forms.Label();
            this.labelSubExtension = new System.Windows.Forms.Label();
            this.btnAddVideoExtension = new System.Windows.Forms.Button();
            this.btnDeleteVideoExtension = new System.Windows.Forms.Button();
            this.btnDeleteSubExtension = new System.Windows.Forms.Button();
            this.btnAddSubExtension = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VersionText
            // 
            resources.ApplyResources(this.VersionText, "VersionText");
            this.VersionText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VersionText.Name = "VersionText";
            // 
            // UpdateLinkLabel
            // 
            resources.ApplyResources(this.UpdateLinkLabel, "UpdateLinkLabel");
            this.UpdateLinkLabel.Name = "UpdateLinkLabel";
            this.UpdateLinkLabel.TabStop = true;
            this.UpdateLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.UpdateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLinkLabel_LinkClicked);
            // 
            // GithubLinkLabel
            // 
            resources.ApplyResources(this.GithubLinkLabel, "GithubLinkLabel");
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // AuthorLinkLabel
            // 
            resources.ApplyResources(this.AuthorLinkLabel, "AuthorLinkLabel");
            this.AuthorLinkLabel.Name = "AuthorLinkLabel";
            this.AuthorLinkLabel.TabStop = true;
            this.AuthorLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.AuthorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Name = "label1";
            // 
            // RawSubtitleBuckup
            // 
            resources.ApplyResources(this.RawSubtitleBuckup, "RawSubtitleBuckup");
            this.RawSubtitleBuckup.Name = "RawSubtitleBuckup";
            this.RawSubtitleBuckup.UseVisualStyleBackColor = true;
            // 
            // ListShowFileFullName
            // 
            resources.ApplyResources(this.ListShowFileFullName, "ListShowFileFullName");
            this.ListShowFileFullName.Name = "ListShowFileFullName";
            this.ListShowFileFullName.UseVisualStyleBackColor = true;
            this.ListShowFileFullName.CheckedChanged += new System.EventHandler(this.ListShowFileFullNameCheckBox_CheckedChanged);
            // 
            // ListItemRemovePrompt
            // 
            resources.ApplyResources(this.ListItemRemovePrompt, "ListItemRemovePrompt");
            this.ListItemRemovePrompt.Name = "ListItemRemovePrompt";
            this.ListItemRemovePrompt.UseVisualStyleBackColor = true;
            // 
            // BlogLabel
            // 
            resources.ApplyResources(this.BlogLabel, "BlogLabel");
            this.BlogLabel.Name = "BlogLabel";
            this.BlogLabel.TabStop = true;
            this.BlogLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.BlogLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogLabel_LinkClicked);
            // 
            // RenameVideo
            // 
            resources.ApplyResources(this.RenameVideo, "RenameVideo");
            this.RenameVideo.Name = "RenameVideo";
            this.RenameVideo.UseVisualStyleBackColor = true;
            this.RenameVideo.CheckedChanged += new System.EventHandler(this.RenameVideo_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Name = "label2";
            // 
            // listBoxVideoExtension
            // 
            this.listBoxVideoExtension.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxVideoExtension, "listBoxVideoExtension");
            this.listBoxVideoExtension.Name = "listBoxVideoExtension";
            // 
            // listBoxSubExtension
            // 
            this.listBoxSubExtension.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxSubExtension, "listBoxSubExtension");
            this.listBoxSubExtension.Name = "listBoxSubExtension";
            // 
            // labelVideoExtension
            // 
            resources.ApplyResources(this.labelVideoExtension, "labelVideoExtension");
            this.labelVideoExtension.Name = "labelVideoExtension";
            // 
            // labelSubExtension
            // 
            resources.ApplyResources(this.labelSubExtension, "labelSubExtension");
            this.labelSubExtension.Name = "labelSubExtension";
            // 
            // btnAddVideoExtension
            // 
            resources.ApplyResources(this.btnAddVideoExtension, "btnAddVideoExtension");
            this.btnAddVideoExtension.Name = "btnAddVideoExtension";
            this.btnAddVideoExtension.UseVisualStyleBackColor = true;
            this.btnAddVideoExtension.Click += new System.EventHandler(this.AddVideoExtension);
            // 
            // btnDeleteVideoExtension
            // 
            resources.ApplyResources(this.btnDeleteVideoExtension, "btnDeleteVideoExtension");
            this.btnDeleteVideoExtension.Name = "btnDeleteVideoExtension";
            this.btnDeleteVideoExtension.UseVisualStyleBackColor = true;
            this.btnDeleteVideoExtension.Click += new System.EventHandler(this.DeleteVideoExtension);
            // 
            // btnDeleteSubExtension
            // 
            resources.ApplyResources(this.btnDeleteSubExtension, "btnDeleteSubExtension");
            this.btnDeleteSubExtension.Name = "btnDeleteSubExtension";
            this.btnDeleteSubExtension.UseVisualStyleBackColor = true;
            this.btnDeleteSubExtension.Click += new System.EventHandler(this.DeleteSubExtension);
            // 
            // btnAddSubExtension
            // 
            resources.ApplyResources(this.btnAddSubExtension, "btnAddSubExtension");
            this.btnAddSubExtension.Name = "btnAddSubExtension";
            this.btnAddSubExtension.UseVisualStyleBackColor = true;
            this.btnAddSubExtension.Click += new System.EventHandler(this.AddSubExtension);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            resources.GetString("comboBoxLanguage.Items"),
            resources.GetString("comboBoxLanguage.Items1")});
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.LanguageChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Name = "label3";
            // 
            // SettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.btnDeleteSubExtension);
            this.Controls.Add(this.btnAddSubExtension);
            this.Controls.Add(this.btnDeleteVideoExtension);
            this.Controls.Add(this.btnAddVideoExtension);
            this.Controls.Add(this.labelSubExtension);
            this.Controls.Add(this.labelVideoExtension);
            this.Controls.Add(this.listBoxSubExtension);
            this.Controls.Add(this.listBoxVideoExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RenameVideo);
            this.Controls.Add(this.BlogLabel);
            this.Controls.Add(this.RawSubtitleBuckup);
            this.Controls.Add(this.ListItemRemovePrompt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ListShowFileFullName);
            this.Controls.Add(this.AuthorLinkLabel);
            this.Controls.Add(this.GithubLinkLabel);
            this.Controls.Add(this.UpdateLinkLabel);
            this.Controls.Add(this.VersionText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox RawSubtitleBuckup;
        private System.Windows.Forms.Label VersionText;
        private System.Windows.Forms.LinkLabel UpdateLinkLabel;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.LinkLabel AuthorLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox ListItemRemovePrompt;
        private System.Windows.Forms.CheckBox ListShowFileFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel BlogLabel;
        private System.Windows.Forms.CheckBox RenameVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxVideoExtension;
        private System.Windows.Forms.ListBox listBoxSubExtension;
        private System.Windows.Forms.Label labelVideoExtension;
        private System.Windows.Forms.Label labelSubExtension;
        private System.Windows.Forms.Button btnAddVideoExtension;
        private System.Windows.Forms.Button btnDeleteVideoExtension;
        private System.Windows.Forms.Button btnDeleteSubExtension;
        private System.Windows.Forms.Button btnAddSubExtension;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label3;
    }
}