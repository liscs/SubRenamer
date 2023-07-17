namespace SubRenamer
{
    partial class RuleEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleEditor));
            this.ModeBtn_Auto = new System.Windows.Forms.RadioButton();
            this.ModeBtn_Manu = new System.Windows.Forms.RadioButton();
            this.ModeBtn_Regex = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.EditBtn_Regex = new System.Windows.Forms.LinkLabel();
            this.EditBtn_Manu = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeBtn_Auto
            // 
            resources.ApplyResources(this.ModeBtn_Auto, "ModeBtn_Auto");
            this.ModeBtn_Auto.Name = "ModeBtn_Auto";
            this.ModeBtn_Auto.TabStop = true;
            this.ModeBtn_Auto.UseVisualStyleBackColor = true;
            this.ModeBtn_Auto.CheckedChanged += new System.EventHandler(this.ModeBtn_Auto_CheckedChanged);
            // 
            // ModeBtn_Manu
            // 
            resources.ApplyResources(this.ModeBtn_Manu, "ModeBtn_Manu");
            this.ModeBtn_Manu.Name = "ModeBtn_Manu";
            this.ModeBtn_Manu.TabStop = true;
            this.ModeBtn_Manu.UseVisualStyleBackColor = true;
            this.ModeBtn_Manu.CheckedChanged += new System.EventHandler(this.ModeBtn_Manu_CheckedChanged);
            // 
            // ModeBtn_Regex
            // 
            resources.ApplyResources(this.ModeBtn_Regex, "ModeBtn_Regex");
            this.ModeBtn_Regex.Name = "ModeBtn_Regex";
            this.ModeBtn_Regex.TabStop = true;
            this.ModeBtn_Regex.UseVisualStyleBackColor = true;
            this.ModeBtn_Regex.CheckedChanged += new System.EventHandler(this.ModeBtn_Regex_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Copyright);
            this.groupBox1.Controls.Add(this.EditBtn_Regex);
            this.groupBox1.Controls.Add(this.EditBtn_Manu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ModeBtn_Auto);
            this.groupBox1.Controls.Add(this.ModeBtn_Regex);
            this.groupBox1.Controls.Add(this.ModeBtn_Manu);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Copyright
            // 
            resources.ApplyResources(this.Copyright, "Copyright");
            this.Copyright.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Copyright.Name = "Copyright";
            this.Copyright.Click += new System.EventHandler(this.Copyright_Click);
            // 
            // EditBtn_Regex
            // 
            resources.ApplyResources(this.EditBtn_Regex, "EditBtn_Regex");
            this.EditBtn_Regex.Name = "EditBtn_Regex";
            this.EditBtn_Regex.TabStop = true;
            this.EditBtn_Regex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditBtn_Regex_LinkClicked);
            // 
            // EditBtn_Manu
            // 
            resources.ApplyResources(this.EditBtn_Manu, "EditBtn_Manu");
            this.EditBtn_Manu.Name = "EditBtn_Manu";
            this.EditBtn_Manu.TabStop = true;
            this.EditBtn_Manu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditBtn_Manu_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // RuleEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RuleEditor";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RuleEditor_FormClosed);
            this.Load += new System.EventHandler(this.RuleEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton ModeBtn_Manu;
        private System.Windows.Forms.RadioButton ModeBtn_Regex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel EditBtn_Regex;
        private System.Windows.Forms.LinkLabel EditBtn_Manu;
        private System.Windows.Forms.RadioButton ModeBtn_Auto;
        private System.Windows.Forms.Label Copyright;
    }
}