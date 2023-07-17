namespace SubRenamer.MatchModeEditor
{
    partial class RegexEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexEditor));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.VideoRegex = new System.Windows.Forms.TextBox();
            this.SubRegex = new System.Windows.Forms.TextBox();
            this.RegexTestLink = new System.Windows.Forms.LinkLabel();
            this.LearnRegexLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.S_TestResult = new System.Windows.Forms.TextBox();
            this.S_Test_OpenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.S_TestStr = new System.Windows.Forms.TextBox();
            this.V_TestResult = new System.Windows.Forms.TextBox();
            this.V_Test_OpenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.V_TestStr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // VideoRegex
            // 
            resources.ApplyResources(this.VideoRegex, "VideoRegex");
            this.VideoRegex.Name = "VideoRegex";
            // 
            // SubRegex
            // 
            resources.ApplyResources(this.SubRegex, "SubRegex");
            this.SubRegex.Name = "SubRegex";
            // 
            // RegexTestLink
            // 
            resources.ApplyResources(this.RegexTestLink, "RegexTestLink");
            this.RegexTestLink.Name = "RegexTestLink";
            this.RegexTestLink.TabStop = true;
            this.RegexTestLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegexTestLink_LinkClicked);
            // 
            // LearnRegexLink
            // 
            resources.ApplyResources(this.LearnRegexLink, "LearnRegexLink");
            this.LearnRegexLink.Name = "LearnRegexLink";
            this.LearnRegexLink.TabStop = true;
            this.LearnRegexLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LearnRegexLink_LinkClicked);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.VideoRegex);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.SubRegex);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.S_TestResult);
            this.groupBox3.Controls.Add(this.S_Test_OpenBtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.S_TestStr);
            this.groupBox3.Controls.Add(this.V_TestResult);
            this.groupBox3.Controls.Add(this.V_Test_OpenBtn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.V_TestStr);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // S_TestResult
            // 
            resources.ApplyResources(this.S_TestResult, "S_TestResult");
            this.S_TestResult.Name = "S_TestResult";
            this.S_TestResult.ReadOnly = true;
            // 
            // S_Test_OpenBtn
            // 
            resources.ApplyResources(this.S_Test_OpenBtn, "S_Test_OpenBtn");
            this.S_Test_OpenBtn.Name = "S_Test_OpenBtn";
            this.S_Test_OpenBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // S_TestStr
            // 
            resources.ApplyResources(this.S_TestStr, "S_TestStr");
            this.S_TestStr.Name = "S_TestStr";
            // 
            // V_TestResult
            // 
            resources.ApplyResources(this.V_TestResult, "V_TestResult");
            this.V_TestResult.Name = "V_TestResult";
            this.V_TestResult.ReadOnly = true;
            // 
            // V_Test_OpenBtn
            // 
            resources.ApplyResources(this.V_Test_OpenBtn, "V_Test_OpenBtn");
            this.V_Test_OpenBtn.Name = "V_Test_OpenBtn";
            this.V_Test_OpenBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // V_TestStr
            // 
            resources.ApplyResources(this.V_TestStr, "V_TestStr");
            this.V_TestStr.Name = "V_TestStr";
            // 
            // RegexEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LearnRegexLink);
            this.Controls.Add(this.RegexTestLink);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegexEditor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.RegexEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox VideoRegex;
        private System.Windows.Forms.TextBox SubRegex;
        private System.Windows.Forms.LinkLabel RegexTestLink;
        private System.Windows.Forms.LinkLabel LearnRegexLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox V_TestResult;
        private System.Windows.Forms.Button V_Test_OpenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox V_TestStr;
        private System.Windows.Forms.TextBox S_TestResult;
        private System.Windows.Forms.Button S_Test_OpenBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox S_TestStr;
    }
}