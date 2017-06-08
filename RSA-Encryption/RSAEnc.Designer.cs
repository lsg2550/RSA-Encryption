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
            this.labelCandidates = new System.Windows.Forms.Label();
            this.textboxCandidates = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textboxR = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.textboxN = new System.Windows.Forms.TextBox();
            this.textboxLog = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.submitK = new System.Windows.Forms.Button();
            this.textboxProdOfK = new System.Windows.Forms.TextBox();
            this.textboxPrimeFactK = new System.Windows.Forms.TextBox();
            this.labelProductsOfK = new System.Windows.Forms.Label();
            this.labelPrimeFactorsK = new System.Windows.Forms.Label();
            this.textboxK = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCheckED = new System.Windows.Forms.Button();
            this.textboxD = new System.Windows.Forms.TextBox();
            this.textboxE = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxEncDec = new System.Windows.Forms.TextBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.buttonEncDec = new System.Windows.Forms.Button();
            this.checkboxEncDec = new System.Windows.Forms.CheckBox();
            this.groupbox2.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxQ
            // 
            resources.ApplyResources(this.textboxQ, "textboxQ");
            this.textboxQ.BackColor = System.Drawing.SystemColors.Window;
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
            this.textboxP.BackColor = System.Drawing.SystemColors.Window;
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
            // labelCandidates
            // 
            resources.ApplyResources(this.labelCandidates, "labelCandidates");
            this.labelCandidates.Name = "labelCandidates";
            // 
            // textboxCandidates
            // 
            resources.ApplyResources(this.textboxCandidates, "textboxCandidates");
            this.textboxCandidates.Name = "textboxCandidates";
            this.textboxCandidates.ReadOnly = true;
            // 
            // labelR
            // 
            resources.ApplyResources(this.labelR, "labelR");
            this.labelR.Name = "labelR";
            // 
            // textboxR
            // 
            resources.ApplyResources(this.textboxR, "textboxR");
            this.textboxR.Name = "textboxR";
            this.textboxR.ReadOnly = true;
            // 
            // labelN
            // 
            resources.ApplyResources(this.labelN, "labelN");
            this.labelN.Name = "labelN";
            // 
            // textboxN
            // 
            resources.ApplyResources(this.textboxN, "textboxN");
            this.textboxN.Name = "textboxN";
            this.textboxN.ReadOnly = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.submitK);
            this.groupBox3.Controls.Add(this.textboxProdOfK);
            this.groupBox3.Controls.Add(this.textboxPrimeFactK);
            this.groupBox3.Controls.Add(this.labelProductsOfK);
            this.groupBox3.Controls.Add(this.labelPrimeFactorsK);
            this.groupBox3.Controls.Add(this.textboxK);
            this.groupBox3.Controls.Add(this.labelK);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // submitK
            // 
            resources.ApplyResources(this.submitK, "submitK");
            this.submitK.Name = "submitK";
            this.submitK.UseVisualStyleBackColor = true;
            this.submitK.Click += new System.EventHandler(this.submitK_Click);
            // 
            // textboxProdOfK
            // 
            resources.ApplyResources(this.textboxProdOfK, "textboxProdOfK");
            this.textboxProdOfK.Name = "textboxProdOfK";
            this.textboxProdOfK.ReadOnly = true;
            // 
            // textboxPrimeFactK
            // 
            resources.ApplyResources(this.textboxPrimeFactK, "textboxPrimeFactK");
            this.textboxPrimeFactK.Name = "textboxPrimeFactK";
            this.textboxPrimeFactK.ReadOnly = true;
            // 
            // labelProductsOfK
            // 
            resources.ApplyResources(this.labelProductsOfK, "labelProductsOfK");
            this.labelProductsOfK.Name = "labelProductsOfK";
            // 
            // labelPrimeFactorsK
            // 
            resources.ApplyResources(this.labelPrimeFactorsK, "labelPrimeFactorsK");
            this.labelPrimeFactorsK.Name = "labelPrimeFactorsK";
            // 
            // textboxK
            // 
            resources.ApplyResources(this.textboxK, "textboxK");
            this.textboxK.Name = "textboxK";
            // 
            // labelK
            // 
            resources.ApplyResources(this.labelK, "labelK");
            this.labelK.Name = "labelK";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCheckED);
            this.groupBox4.Controls.Add(this.textboxD);
            this.groupBox4.Controls.Add(this.textboxE);
            this.groupBox4.Controls.Add(this.labelD);
            this.groupBox4.Controls.Add(this.labelE);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // buttonCheckED
            // 
            resources.ApplyResources(this.buttonCheckED, "buttonCheckED");
            this.buttonCheckED.Name = "buttonCheckED";
            this.buttonCheckED.UseVisualStyleBackColor = true;
            this.buttonCheckED.Click += new System.EventHandler(this.buttonCheckED_Click);
            // 
            // textboxD
            // 
            resources.ApplyResources(this.textboxD, "textboxD");
            this.textboxD.Name = "textboxD";
            // 
            // textboxE
            // 
            resources.ApplyResources(this.textboxE, "textboxE");
            this.textboxE.Name = "textboxE";
            // 
            // labelD
            // 
            resources.ApplyResources(this.labelD, "labelD");
            this.labelD.Name = "labelD";
            // 
            // labelE
            // 
            resources.ApplyResources(this.labelE, "labelE");
            this.labelE.Name = "labelE";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textboxEncDec);
            this.groupBox5.Controls.Add(this.textBoxMsg);
            this.groupBox5.Controls.Add(this.buttonEncDec);
            this.groupBox5.Controls.Add(this.checkboxEncDec);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textboxEncDec
            // 
            resources.ApplyResources(this.textboxEncDec, "textboxEncDec");
            this.textboxEncDec.Name = "textboxEncDec";
            this.textboxEncDec.ReadOnly = true;
            // 
            // textBoxMsg
            // 
            resources.ApplyResources(this.textBoxMsg, "textBoxMsg");
            this.textBoxMsg.Name = "textBoxMsg";
            // 
            // buttonEncDec
            // 
            resources.ApplyResources(this.buttonEncDec, "buttonEncDec");
            this.buttonEncDec.Name = "buttonEncDec";
            this.buttonEncDec.UseVisualStyleBackColor = true;
            this.buttonEncDec.Click += new System.EventHandler(this.buttonEncDec_Click);
            // 
            // checkboxEncDec
            // 
            resources.ApplyResources(this.checkboxEncDec, "checkboxEncDec");
            this.checkboxEncDec.Name = "checkboxEncDec";
            this.checkboxEncDec.UseVisualStyleBackColor = true;
            // 
            // rsaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Label labelProductsOfK;
        private System.Windows.Forms.Label labelPrimeFactorsK;
        private System.Windows.Forms.TextBox textboxK;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.TextBox textboxProdOfK;
        private System.Windows.Forms.TextBox textboxPrimeFactK;
        private System.Windows.Forms.Button submitK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textboxD;
        private System.Windows.Forms.TextBox textboxE;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Button buttonCheckED;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textboxEncDec;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button buttonEncDec;
        private System.Windows.Forms.CheckBox checkboxEncDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

