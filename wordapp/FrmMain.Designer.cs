namespace wordapp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnMark = new System.Windows.Forms.Button();
            this.btnUnmark = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxNew = new System.Windows.Forms.CheckBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(136, 296);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(96, 36);
            this.btnMark.TabIndex = 0;
            this.btnMark.Text = "标记为生词";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnUnmark
            // 
            this.btnUnmark.Location = new System.Drawing.Point(286, 296);
            this.btnUnmark.Name = "btnUnmark";
            this.btnUnmark.Size = new System.Drawing.Size(96, 36);
            this.btnUnmark.TabIndex = 0;
            this.btnUnmark.Text = "取消标记";
            this.btnUnmark.UseVisualStyleBackColor = true;
            this.btnUnmark.Click += new System.EventHandler(this.btnUnmark_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(439, 296);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 36);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "导出生词表";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxNew);
            this.groupBox1.Controls.Add(this.lblMeaning);
            this.groupBox1.Controls.Add(this.lblEnglish);
            this.groupBox1.Location = new System.Drawing.Point(136, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cBoxNew
            // 
            this.cBoxNew.AutoSize = true;
            this.cBoxNew.ForeColor = System.Drawing.Color.OliveDrab;
            this.cBoxNew.Location = new System.Drawing.Point(170, 157);
            this.cBoxNew.Name = "cBoxNew";
            this.cBoxNew.Size = new System.Drawing.Size(48, 16);
            this.cBoxNew.TabIndex = 2;
            this.cBoxNew.Text = "生词";
            this.cBoxNew.UseVisualStyleBackColor = true;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMeaning.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMeaning.Location = new System.Drawing.Point(114, 94);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(50, 25);
            this.lblMeaning.TabIndex = 1;
            this.lblMeaning.Text = "释义";
            this.lblMeaning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMeaning.Visible = false;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEnglish.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnglish.Location = new System.Drawing.Point(145, 45);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(54, 28);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "单词";
            this.lblEnglish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEnglish.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnUnmark);
            this.Controls.Add(this.btnMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "背单词App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnUnmark;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxNew;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblEnglish;
    }
}

