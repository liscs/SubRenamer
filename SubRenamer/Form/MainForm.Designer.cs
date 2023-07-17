namespace SubRenamer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopMenu = new System.Windows.Forms.MainMenu(this.components);
            this.TopMenu_File = new System.Windows.Forms.MenuItem();
            this.TopMenu_OpenFileBtn = new System.Windows.Forms.MenuItem();
            this.TopMenu_OpenFolderBtn = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.TopMenu_ReMatch = new System.Windows.Forms.MenuItem();
            this.TopMenu_ClearAll = new System.Windows.Forms.MenuItem();
            this.TopMenu_Rule = new System.Windows.Forms.MenuItem();
            this.TopMenu_Setting = new System.Windows.Forms.MenuItem();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainContPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FileListUi = new System.Windows.Forms.ListView();
            this.MatchKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Video = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.R_RuleBtn = new System.Windows.Forms.Button();
            this.R_ClearAllBtn = new System.Windows.Forms.Button();
            this.R_ReMatchBtn = new System.Windows.Forms.Button();
            this.CopyrightText = new System.Windows.Forms.Label();
            this.R_RemoveBtn = new System.Windows.Forms.Button();
            this.R_EditBtn = new System.Windows.Forms.Button();
            this.R_OpenFolderBtn = new System.Windows.Forms.Button();
            this.PreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.R_OpenFileBtn = new System.Windows.Forms.Button();
            this.R_SettingBtn = new System.Windows.Forms.Button();
            this.MainContWrapPanel = new System.Windows.Forms.Panel();
            this.MainContPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MainContWrapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.TopMenu_File,
            this.TopMenu_Rule,
            this.TopMenu_Setting});
            resources.ApplyResources(this.TopMenu, "TopMenu");
            // 
            // TopMenu_File
            // 
            resources.ApplyResources(this.TopMenu_File, "TopMenu_File");
            this.TopMenu_File.Index = 0;
            this.TopMenu_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.TopMenu_OpenFileBtn,
            this.TopMenu_OpenFolderBtn,
            this.menuItem1,
            this.TopMenu_ReMatch,
            this.TopMenu_ClearAll});
            this.TopMenu_File.Tag = "TopMenu_File";
            // 
            // TopMenu_OpenFileBtn
            // 
            resources.ApplyResources(this.TopMenu_OpenFileBtn, "TopMenu_OpenFileBtn");
            this.TopMenu_OpenFileBtn.Index = 0;
            this.TopMenu_OpenFileBtn.Tag = "TopMenu_OpenFileBtn";
            this.TopMenu_OpenFileBtn.Click += new System.EventHandler(this.TopMenu_OpenFileBtn_Click);
            // 
            // TopMenu_OpenFolderBtn
            // 
            resources.ApplyResources(this.TopMenu_OpenFolderBtn, "TopMenu_OpenFolderBtn");
            this.TopMenu_OpenFolderBtn.Index = 1;
            this.TopMenu_OpenFolderBtn.Tag = "TopMenu_OpenFolderBtn";
            this.TopMenu_OpenFolderBtn.Click += new System.EventHandler(this.TopMenu_OpenFolderBtn_Click);
            // 
            // menuItem1
            // 
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Index = 2;
            // 
            // TopMenu_ReMatch
            // 
            resources.ApplyResources(this.TopMenu_ReMatch, "TopMenu_ReMatch");
            this.TopMenu_ReMatch.Index = 3;
            this.TopMenu_ReMatch.Tag = "TopMenu_ReMatch";
            this.TopMenu_ReMatch.Click += new System.EventHandler(this.TopMenu_ReMatch_Click);
            // 
            // TopMenu_ClearAll
            // 
            resources.ApplyResources(this.TopMenu_ClearAll, "TopMenu_ClearAll");
            this.TopMenu_ClearAll.Index = 4;
            this.TopMenu_ClearAll.Tag = "TopMenu_ClearAll";
            this.TopMenu_ClearAll.Click += new System.EventHandler(this.TopMenu_ClearAll_Click);
            // 
            // TopMenu_Rule
            // 
            resources.ApplyResources(this.TopMenu_Rule, "TopMenu_Rule");
            this.TopMenu_Rule.Index = 1;
            this.TopMenu_Rule.Tag = "TopMenu_Rule";
            this.TopMenu_Rule.Click += new System.EventHandler(this.TopMenu_Rule_Click);
            // 
            // TopMenu_Setting
            // 
            resources.ApplyResources(this.TopMenu_Setting, "TopMenu_Setting");
            this.TopMenu_Setting.Index = 2;
            this.TopMenu_Setting.Tag = "TopMenu_Setting";
            this.TopMenu_Setting.Click += new System.EventHandler(this.TopMenu_Setting_Click);
            // 
            // MainContPanel
            // 
            resources.ApplyResources(this.MainContPanel, "MainContPanel");
            this.MainContPanel.Controls.Add(this.FileListUi, 0, 1);
            this.MainContPanel.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.MainContPanel.Name = "MainContPanel";
            this.MainToolTip.SetToolTip(this.MainContPanel, resources.GetString("MainContPanel.ToolTip"));
            // 
            // FileListUi
            // 
            resources.ApplyResources(this.FileListUi, "FileListUi");
            this.FileListUi.AllowDrop = true;
            this.FileListUi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MatchKey,
            this.Video,
            this.Subtitle,
            this.Status});
            this.FileListUi.FullRowSelect = true;
            this.FileListUi.HideSelection = false;
            this.FileListUi.Name = "FileListUi";
            this.FileListUi.ShowItemToolTips = true;
            this.MainToolTip.SetToolTip(this.FileListUi, resources.GetString("FileListUi.ToolTip"));
            this.FileListUi.UseCompatibleStateImageBehavior = false;
            this.FileListUi.View = System.Windows.Forms.View.Details;
            this.FileListUi.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileListUi_DragDrop);
            this.FileListUi.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileListUi_DragEnter);
            this.FileListUi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileListUi_KeyDown);
            this.FileListUi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileListUi_MouseClick);
            // 
            // MatchKey
            // 
            this.MatchKey.Tag = "MatchKey";
            resources.ApplyResources(this.MatchKey, "MatchKey");
            // 
            // Video
            // 
            this.Video.Tag = "Video";
            resources.ApplyResources(this.Video, "Video");
            // 
            // Subtitle
            // 
            this.Subtitle.Tag = "Subtitle";
            resources.ApplyResources(this.Subtitle, "Subtitle");
            // 
            // Status
            // 
            this.Status.Tag = "Status";
            resources.ApplyResources(this.Status, "Status");
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.R_RuleBtn, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.R_ClearAllBtn, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.R_ReMatchBtn, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.CopyrightText, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.R_RemoveBtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.R_EditBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.R_OpenFolderBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PreviewCheckBox, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.StartBtn, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.R_OpenFileBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.R_SettingBtn, 0, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.MainToolTip.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // R_RuleBtn
            // 
            resources.ApplyResources(this.R_RuleBtn, "R_RuleBtn");
            this.R_RuleBtn.Name = "R_RuleBtn";
            this.MainToolTip.SetToolTip(this.R_RuleBtn, resources.GetString("R_RuleBtn.ToolTip"));
            this.R_RuleBtn.UseVisualStyleBackColor = true;
            this.R_RuleBtn.Click += new System.EventHandler(this.R_RuleBtn_Click);
            // 
            // R_ClearAllBtn
            // 
            resources.ApplyResources(this.R_ClearAllBtn, "R_ClearAllBtn");
            this.R_ClearAllBtn.Name = "R_ClearAllBtn";
            this.MainToolTip.SetToolTip(this.R_ClearAllBtn, resources.GetString("R_ClearAllBtn.ToolTip"));
            this.R_ClearAllBtn.UseVisualStyleBackColor = true;
            this.R_ClearAllBtn.Click += new System.EventHandler(this.R_ClearAllBtn_Click);
            // 
            // R_ReMatchBtn
            // 
            resources.ApplyResources(this.R_ReMatchBtn, "R_ReMatchBtn");
            this.R_ReMatchBtn.Name = "R_ReMatchBtn";
            this.MainToolTip.SetToolTip(this.R_ReMatchBtn, resources.GetString("R_ReMatchBtn.ToolTip"));
            this.R_ReMatchBtn.UseVisualStyleBackColor = true;
            this.R_ReMatchBtn.Click += new System.EventHandler(this.R_ReMatchBtn_Click);
            // 
            // CopyrightText
            // 
            resources.ApplyResources(this.CopyrightText, "CopyrightText");
            this.CopyrightText.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyrightText.ForeColor = System.Drawing.Color.DarkGray;
            this.CopyrightText.Name = "CopyrightText";
            this.MainToolTip.SetToolTip(this.CopyrightText, resources.GetString("CopyrightText.ToolTip"));
            this.CopyrightText.Click += new System.EventHandler(this.CopyrightText_Click);
            // 
            // R_RemoveBtn
            // 
            resources.ApplyResources(this.R_RemoveBtn, "R_RemoveBtn");
            this.R_RemoveBtn.Name = "R_RemoveBtn";
            this.MainToolTip.SetToolTip(this.R_RemoveBtn, resources.GetString("R_RemoveBtn.ToolTip"));
            this.R_RemoveBtn.UseVisualStyleBackColor = true;
            this.R_RemoveBtn.Click += new System.EventHandler(this.R_RemoveBtn_Click);
            // 
            // R_EditBtn
            // 
            resources.ApplyResources(this.R_EditBtn, "R_EditBtn");
            this.R_EditBtn.Name = "R_EditBtn";
            this.MainToolTip.SetToolTip(this.R_EditBtn, resources.GetString("R_EditBtn.ToolTip"));
            this.R_EditBtn.UseVisualStyleBackColor = true;
            this.R_EditBtn.Click += new System.EventHandler(this.R_EditBtn_Click);
            // 
            // R_OpenFolderBtn
            // 
            resources.ApplyResources(this.R_OpenFolderBtn, "R_OpenFolderBtn");
            this.R_OpenFolderBtn.Name = "R_OpenFolderBtn";
            this.MainToolTip.SetToolTip(this.R_OpenFolderBtn, resources.GetString("R_OpenFolderBtn.ToolTip"));
            this.R_OpenFolderBtn.UseVisualStyleBackColor = true;
            this.R_OpenFolderBtn.Click += new System.EventHandler(this.R_OpenFolderBtn_Click);
            // 
            // PreviewCheckBox
            // 
            resources.ApplyResources(this.PreviewCheckBox, "PreviewCheckBox");
            this.PreviewCheckBox.Name = "PreviewCheckBox";
            this.MainToolTip.SetToolTip(this.PreviewCheckBox, resources.GetString("PreviewCheckBox.ToolTip"));
            this.PreviewCheckBox.UseVisualStyleBackColor = true;
            this.PreviewCheckBox.CheckedChanged += new System.EventHandler(this.PreviewCheckBox_CheckedChanged);
            // 
            // StartBtn
            // 
            resources.ApplyResources(this.StartBtn, "StartBtn");
            this.StartBtn.Name = "StartBtn";
            this.MainToolTip.SetToolTip(this.StartBtn, resources.GetString("StartBtn.ToolTip"));
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // R_OpenFileBtn
            // 
            resources.ApplyResources(this.R_OpenFileBtn, "R_OpenFileBtn");
            this.R_OpenFileBtn.Name = "R_OpenFileBtn";
            this.MainToolTip.SetToolTip(this.R_OpenFileBtn, resources.GetString("R_OpenFileBtn.ToolTip"));
            this.R_OpenFileBtn.UseVisualStyleBackColor = true;
            this.R_OpenFileBtn.Click += new System.EventHandler(this.R_OpenFileBtn_Click);
            // 
            // R_SettingBtn
            // 
            resources.ApplyResources(this.R_SettingBtn, "R_SettingBtn");
            this.R_SettingBtn.Name = "R_SettingBtn";
            this.MainToolTip.SetToolTip(this.R_SettingBtn, resources.GetString("R_SettingBtn.ToolTip"));
            this.R_SettingBtn.UseVisualStyleBackColor = true;
            this.R_SettingBtn.Click += new System.EventHandler(this.R_SettingBtn_Click);
            // 
            // MainContWrapPanel
            // 
            resources.ApplyResources(this.MainContWrapPanel, "MainContWrapPanel");
            this.MainContWrapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContWrapPanel.Controls.Add(this.MainContPanel);
            this.MainContWrapPanel.Name = "MainContWrapPanel";
            this.MainToolTip.SetToolTip(this.MainContWrapPanel, resources.GetString("MainContWrapPanel.ToolTip"));
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainContWrapPanel);
            this.Menu = this.TopMenu;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.MainToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainContPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MainContWrapPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu TopMenu;
        private System.Windows.Forms.MenuItem TopMenu_File;
        private System.Windows.Forms.MenuItem TopMenu_Setting;
        private System.Windows.Forms.MenuItem TopMenu_OpenFileBtn;
        private System.Windows.Forms.MenuItem TopMenu_OpenFolderBtn;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.MenuItem TopMenu_Rule;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem TopMenu_ReMatch;
        private System.Windows.Forms.MenuItem TopMenu_ClearAll;
        private System.Windows.Forms.TableLayoutPanel MainContPanel;
        private System.Windows.Forms.ListView FileListUi;
        private System.Windows.Forms.ColumnHeader MatchKey;
        private System.Windows.Forms.ColumnHeader Video;
        private System.Windows.Forms.ColumnHeader Subtitle;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button R_RuleBtn;
        private System.Windows.Forms.Button R_ClearAllBtn;
        private System.Windows.Forms.Button R_ReMatchBtn;
        private System.Windows.Forms.Label CopyrightText;
        private System.Windows.Forms.Button R_RemoveBtn;
        private System.Windows.Forms.Button R_EditBtn;
        private System.Windows.Forms.Button R_OpenFolderBtn;
        private System.Windows.Forms.CheckBox PreviewCheckBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button R_OpenFileBtn;
        private System.Windows.Forms.Button R_SettingBtn;
        private System.Windows.Forms.Panel MainContWrapPanel;
    }
}

