namespace SubRenamer.MatchModeEditor
{
    partial class ManuEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManuEditor));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.V_Tpl = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.S_Matched = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.S_OpenBtn = new System.Windows.Forms.Button();
            this.S_Tpl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.V_Matched = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.V_OpenBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // V_Tpl
            // 
            resources.ApplyResources(this.V_Tpl, "V_Tpl");
            this.V_Tpl.Name = "V_Tpl";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.S_Matched);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.S_OpenBtn);
            this.groupBox3.Controls.Add(this.S_Tpl);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // S_Matched
            // 
            resources.ApplyResources(this.S_Matched, "S_Matched");
            this.S_Matched.Name = "S_Matched";
            this.S_Matched.ReadOnly = true;
            this.S_Matched.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Name = "label2";
            // 
            // S_OpenBtn
            // 
            resources.ApplyResources(this.S_OpenBtn, "S_OpenBtn");
            this.S_OpenBtn.Name = "S_OpenBtn";
            this.S_OpenBtn.UseVisualStyleBackColor = true;
            // 
            // S_Tpl
            // 
            resources.ApplyResources(this.S_Tpl, "S_Tpl");
            this.S_Tpl.Name = "S_Tpl";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.V_Matched);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.V_OpenBtn);
            this.groupBox1.Controls.Add(this.V_Tpl);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // V_Matched
            // 
            resources.ApplyResources(this.V_Matched, "V_Matched");
            this.V_Matched.Name = "V_Matched";
            this.V_Matched.ReadOnly = true;
            this.V_Matched.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // V_OpenBtn
            // 
            resources.ApplyResources(this.V_OpenBtn, "V_OpenBtn");
            this.V_OpenBtn.Name = "V_OpenBtn";
            this.V_OpenBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Name = "label3";
            // 
            // ManuEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManuEditor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ManuEditor_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox V_Tpl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox S_Tpl;
        private System.Windows.Forms.Button V_OpenBtn;
        private System.Windows.Forms.Button S_OpenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox V_Matched;
        private System.Windows.Forms.TextBox S_Matched;
    }
}