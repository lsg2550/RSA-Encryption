namespace RSA_Encryption
{
    partial class rsaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rsaForm));
            this.textboxQ = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textboxP = new System.Windows.Forms.TextBox();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.textboxLog = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.textboxN = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.textboxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textboxCandidates = new System.Windows.Forms.TextBox();
            this.labelCandidates = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupbox2.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxQ
            // 
            resources.ApplyResources(this.textboxQ, "textboxQ");
            this.textboxQ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textboxQ.Name = "textboxQ";
            // 
            // buttonSubmit
            // 
            resources.ApplyResources(this.buttonSubmit, "buttonSubmit");
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textboxP
            // 
            resources.ApplyResources(this.textboxP, "textboxP");
            this.textboxP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textboxP.Name = "textboxP";
            // 
            // labelQ
            // 
            resources.ApplyResources(this.labelQ, "labelQ");
            this.labelQ.Name = "labelQ";
            // 
            // labelP
            // 
            resources.ApplyResources(this.labelP, "labelP");
            this.labelP.Name = "labelP";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.labelCandidates);
            this.groupbox2.Controls.Add(this.textboxCandidates);
            this.groupbox2.Controls.Add(this.labelR);
            this.groupbox2.Controls.Add(this.textboxR);
            this.groupbox2.Controls.Add(this.labelN);
            this.groupbox2.Controls.Add(this.textboxN);
            resources.ApplyResources(this.groupbox2, "groupbox2");
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.TabStop = false;
            // 
            // textboxLog
            // 
            this.textboxLog.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxLog.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textboxLog, "textboxLog");
            this.textboxLog.Name = "textboxLog";
            this.textboxLog.ReadOnly = true;
            // 
            // labelLog
            // 
            resources.ApplyResources(this.labelLog, "labelLog");
            this.labelLog.Name = "labelLog";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.textboxQ);
            this.groupbox1.Controls.Add(this.buttonSubmit);
            this.groupbox1.Controls.Add(this.textboxP);
            this.groupbox1.Controls.Add(this.labelQ);
            this.groupbox1.Controls.Add(this.labelP);
            this.groupbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupbox1, "groupbox1");
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.TabStop = false;
            // 
            // textboxN
            // 
            resources.ApplyResources(this.textboxN, "textboxN");
            this.textboxN.Name = "textboxN";
            this.textboxN.ReadOnly = true;
            // 
            // labelN
            // 
            resources.ApplyResources(this.labelN, "labelN");
            this.labelN.Name = "labelN";
            // 
            // textboxR
            // 
            resources.ApplyResources(this.textboxR, "textboxR");
            this.textboxR.Name = "textboxR";
            this.textboxR.ReadOnly = true;
            // 
            // labelR
            // 
            resources.ApplyResources(this.labelR, "labelR");
            this.labelR.Name = "labelR";
            // 
            // textboxCandidates
            // 
            resources.ApplyResources(this.textboxCandidates, "textboxCandidates");
            this.textboxCandidates.Name = "textboxCandidates";
            this.textboxCandidates.ReadOnly = true;
            // 
            // labelCandidates
            // 
            resources.ApplyResources(this.labelCandidates, "labelCandidates");
            this.labelCandidates.Name = "labelCandidates";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // rsaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.textboxLog);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rsaForm";
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxQ;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textboxP;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.TextBox textboxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textboxN;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textboxR;
        private System.Windows.Forms.Label labelCandidates;
        private System.Windows.Forms.TextBox textboxCandidates;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

