namespace SubRenamer
{
    partial class VsItemEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VsItemEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.MatchKey_TextBox = new System.Windows.Forms.TextBox();
            this.Video_TextBox = new System.Windows.Forms.TextBox();
            this.Sub_TextBox = new System.Windows.Forms.TextBox();
            this.Video_SelectFileBtn = new System.Windows.Forms.Button();
            this.Sub_SelectFileBtn = new System.Windows.Forms.Button();
            this.PrevItemBtn = new System.Windows.Forms.Button();
            this.NextItemBtn = new System.Windows.Forms.Button();
            this.Video_ClearBtn = new System.Windows.Forms.Button();
            this.Sub_ClearBtn = new System.Windows.Forms.Button();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PageNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.MainToolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // MatchKey_TextBox
            // 
            resources.ApplyResources(this.MatchKey_TextBox, "MatchKey_TextBox");
            this.MatchKey_TextBox.Name = "MatchKey_TextBox";
            this.MainToolTip.SetToolTip(this.MatchKey_TextBox, resources.GetString("MatchKey_TextBox.ToolTip"));
            this.MatchKey_TextBox.TextChanged += new System.EventHandler(this.MatchKey_TextBox_TextChanged);
            // 
            // Video_TextBox
            // 
            resources.ApplyResources(this.Video_TextBox, "Video_TextBox");
            this.Video_TextBox.Name = "Video_TextBox";
            this.Video_TextBox.ReadOnly = true;
            this.MainToolTip.SetToolTip(this.Video_TextBox, resources.GetString("Video_TextBox.ToolTip"));
            // 
            // Sub_TextBox
            // 
            resources.ApplyResources(this.Sub_TextBox, "Sub_TextBox");
            this.Sub_TextBox.Name = "Sub_TextBox";
            this.Sub_TextBox.ReadOnly = true;
            this.MainToolTip.SetToolTip(this.Sub_TextBox, resources.GetString("Sub_TextBox.ToolTip"));
            // 
            // Video_SelectFileBtn
            // 
            resources.ApplyResources(this.Video_SelectFileBtn, "Video_SelectFileBtn");
            this.Video_SelectFileBtn.Name = "Video_SelectFileBtn";
            this.MainToolTip.SetToolTip(this.Video_SelectFileBtn, resources.GetString("Video_SelectFileBtn.ToolTip"));
            this.Video_SelectFileBtn.UseVisualStyleBackColor = true;
            this.Video_SelectFileBtn.Click += new System.EventHandler(this.Video_SelectFileBtn_Click);
            // 
            // Sub_SelectFileBtn
            // 
            resources.ApplyResources(this.Sub_SelectFileBtn, "Sub_SelectFileBtn");
            this.Sub_SelectFileBtn.Name = "Sub_SelectFileBtn";
            this.MainToolTip.SetToolTip(this.Sub_SelectFileBtn, resources.GetString("Sub_SelectFileBtn.ToolTip"));
            this.Sub_SelectFileBtn.UseVisualStyleBackColor = true;
            this.Sub_SelectFileBtn.Click += new System.EventHandler(this.Sub_SelectFileBtn_Click);
            // 
            // PrevItemBtn
            // 
            resources.ApplyResources(this.PrevItemBtn, "PrevItemBtn");
            this.PrevItemBtn.Name = "PrevItemBtn";
            this.MainToolTip.SetToolTip(this.PrevItemBtn, resources.GetString("PrevItemBtn.ToolTip"));
            this.PrevItemBtn.UseVisualStyleBackColor = true;
            this.PrevItemBtn.Click += new System.EventHandler(this.PrevItemBtn_Click);
            // 
            // NextItemBtn
            // 
            resources.ApplyResources(this.NextItemBtn, "NextItemBtn");
            this.NextItemBtn.Name = "NextItemBtn";
            this.MainToolTip.SetToolTip(this.NextItemBtn, resources.GetString("NextItemBtn.ToolTip"));
            this.NextItemBtn.UseVisualStyleBackColor = true;
            this.NextItemBtn.Click += new System.EventHandler(this.NextItemBtn_Click);
            // 
            // Video_ClearBtn
            // 
            resources.ApplyResources(this.Video_ClearBtn, "Video_ClearBtn");
            this.Video_ClearBtn.Name = "Video_ClearBtn";
            this.MainToolTip.SetToolTip(this.Video_ClearBtn, resources.GetString("Video_ClearBtn.ToolTip"));
            this.Video_ClearBtn.UseVisualStyleBackColor = true;
            this.Video_ClearBtn.Click += new System.EventHandler(this.Video_ClearBtn_Click);
            // 
            // Sub_ClearBtn
            // 
            resources.ApplyResources(this.Sub_ClearBtn, "Sub_ClearBtn");
            this.Sub_ClearBtn.Name = "Sub_ClearBtn";
            this.MainToolTip.SetToolTip(this.Sub_ClearBtn, resources.GetString("Sub_ClearBtn.ToolTip"));
            this.Sub_ClearBtn.UseVisualStyleBackColor = true;
            this.Sub_ClearBtn.Click += new System.EventHandler(this.Sub_ClearBtn_Click);
            // 
            // RemoveItemBtn
            // 
            resources.ApplyResources(this.RemoveItemBtn, "RemoveItemBtn");
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.MainToolTip.SetToolTip(this.RemoveItemBtn, resources.GetString("RemoveItemBtn.ToolTip"));
            this.RemoveItemBtn.UseVisualStyleBackColor = true;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // AddItemBtn
            // 
            resources.ApplyResources(this.AddItemBtn, "AddItemBtn");
            this.AddItemBtn.Name = "AddItemBtn";
            this.MainToolTip.SetToolTip(this.AddItemBtn, resources.GetString("AddItemBtn.ToolTip"));
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // PageNum
            // 
            resources.ApplyResources(this.PageNum, "PageNum");
            this.PageNum.Name = "PageNum";
            this.PageNum.ReadOnly = true;
            this.MainToolTip.SetToolTip(this.PageNum, resources.GetString("PageNum.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Video_TextBox);
            this.groupBox1.Controls.Add(this.Video_SelectFileBtn);
            this.groupBox1.Controls.Add(this.Video_ClearBtn);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.MainToolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.Sub_TextBox);
            this.groupBox2.Controls.Add(this.Sub_SelectFileBtn);
            this.groupBox2.Controls.Add(this.Sub_ClearBtn);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.MainToolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // VsItemEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.NextItemBtn);
            this.Controls.Add(this.PrevItemBtn);
            this.Controls.Add(this.MatchKey_TextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VsItemEditor";
            this.ShowIcon = false;
            this.MainToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VsItemEditor_FormClosed);
            this.Load += new System.EventHandler(this.VsItemEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MatchKey_TextBox;
        private System.Windows.Forms.TextBox Video_TextBox;
        private System.Windows.Forms.TextBox Sub_TextBox;
        private System.Windows.Forms.Button Video_SelectFileBtn;
        private System.Windows.Forms.Button Sub_SelectFileBtn;
        private System.Windows.Forms.Button PrevItemBtn;
        private System.Windows.Forms.Button NextItemBtn;
        private System.Windows.Forms.Button Video_ClearBtn;
        private System.Windows.Forms.Button Sub_ClearBtn;
        private System.Windows.Forms.Button RemoveItemBtn;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.TextBox PageNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}