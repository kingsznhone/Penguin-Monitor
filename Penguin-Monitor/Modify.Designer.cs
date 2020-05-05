namespace Penguin_Monitor
{
    partial class Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ModFontBtn = new System.Windows.Forms.Button();
            this.ModForeColorBtn = new System.Windows.Forms.Button();
            this.TopColorBtn = new System.Windows.Forms.Button();
            this.BrushColorBtn = new System.Windows.Forms.Button();
            this.WarningColorBtn = new System.Windows.Forms.Button();
            this.BorderColorBtn = new System.Windows.Forms.Button();
            this.TopLB = new Penguin_Monitor.BGLabel();
            this.RAMLB = new Penguin_Monitor.BGLabel();
            this.CPULB = new Penguin_Monitor.BGLabel();
            this.UploadLB = new Penguin_Monitor.BGLabel();
            this.DownloadLB = new Penguin_Monitor.BGLabel();
            this.BackgroundColorBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DefaltBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // ModFontBtn
            // 
            resources.ApplyResources(this.ModFontBtn, "ModFontBtn");
            this.ModFontBtn.Name = "ModFontBtn";
            this.ModFontBtn.UseVisualStyleBackColor = true;
            this.ModFontBtn.Click += new System.EventHandler(this.ModFontBtn_Click);
            // 
            // ModForeColorBtn
            // 
            resources.ApplyResources(this.ModForeColorBtn, "ModForeColorBtn");
            this.ModForeColorBtn.Name = "ModForeColorBtn";
            this.ModForeColorBtn.UseVisualStyleBackColor = true;
            this.ModForeColorBtn.Click += new System.EventHandler(this.ModForeColorBtn_Click);
            // 
            // TopColorBtn
            // 
            resources.ApplyResources(this.TopColorBtn, "TopColorBtn");
            this.TopColorBtn.Name = "TopColorBtn";
            this.TopColorBtn.UseVisualStyleBackColor = true;
            this.TopColorBtn.Click += new System.EventHandler(this.TopColorBtn_Click);
            // 
            // BrushColorBtn
            // 
            resources.ApplyResources(this.BrushColorBtn, "BrushColorBtn");
            this.BrushColorBtn.Name = "BrushColorBtn";
            this.BrushColorBtn.UseVisualStyleBackColor = true;
            this.BrushColorBtn.Click += new System.EventHandler(this.BrushColorBtn_Click);
            // 
            // WarningColorBtn
            // 
            resources.ApplyResources(this.WarningColorBtn, "WarningColorBtn");
            this.WarningColorBtn.Name = "WarningColorBtn";
            this.WarningColorBtn.UseVisualStyleBackColor = true;
            this.WarningColorBtn.Click += new System.EventHandler(this.WarningColorBtn_Click);
            // 
            // BorderColorBtn
            // 
            resources.ApplyResources(this.BorderColorBtn, "BorderColorBtn");
            this.BorderColorBtn.Name = "BorderColorBtn";
            this.BorderColorBtn.UseVisualStyleBackColor = true;
            this.BorderColorBtn.Click += new System.EventHandler(this.BorderColorBtn_Click);
            // 
            // TopLB
            // 
            resources.ApplyResources(this.TopLB, "TopLB");
            this.TopLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.TopLB.ForeColor = System.Drawing.Color.White;
            this.TopLB.Name = "TopLB";
            // 
            // RAMLB
            // 
            resources.ApplyResources(this.RAMLB, "RAMLB");
            this.RAMLB.BackColor = System.Drawing.Color.Black;
            this.RAMLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.RAMLB.Name = "RAMLB";
            // 
            // CPULB
            // 
            resources.ApplyResources(this.CPULB, "CPULB");
            this.CPULB.BackColor = System.Drawing.Color.Black;
            this.CPULB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.CPULB.Name = "CPULB";
            // 
            // UploadLB
            // 
            resources.ApplyResources(this.UploadLB, "UploadLB");
            this.UploadLB.BackColor = System.Drawing.Color.Black;
            this.UploadLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.UploadLB.Name = "UploadLB";
            // 
            // DownloadLB
            // 
            resources.ApplyResources(this.DownloadLB, "DownloadLB");
            this.DownloadLB.BackColor = System.Drawing.Color.Black;
            this.DownloadLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.DownloadLB.Name = "DownloadLB";
            // 
            // BackgroundColorBtn
            // 
            resources.ApplyResources(this.BackgroundColorBtn, "BackgroundColorBtn");
            this.BackgroundColorBtn.Name = "BackgroundColorBtn";
            this.BackgroundColorBtn.UseVisualStyleBackColor = true;
            this.BackgroundColorBtn.Click += new System.EventHandler(this.BackgroundColorBtn_Click);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DefaltBtn
            // 
            resources.ApplyResources(this.DefaltBtn, "DefaltBtn");
            this.DefaltBtn.Name = "DefaltBtn";
            this.DefaltBtn.UseVisualStyleBackColor = true;
            this.DefaltBtn.Click += new System.EventHandler(this.DefaltBtn_Click);
            // 
            // Modify
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WarningColorBtn);
            this.Controls.Add(this.BackgroundColorBtn);
            this.Controls.Add(this.ModForeColorBtn);
            this.Controls.Add(this.BrushColorBtn);
            this.Controls.Add(this.BorderColorBtn);
            this.Controls.Add(this.TopColorBtn);
            this.Controls.Add(this.DefaltBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ModFontBtn);
            this.Controls.Add(this.TopLB);
            this.Controls.Add(this.RAMLB);
            this.Controls.Add(this.CPULB);
            this.Controls.Add(this.UploadLB);
            this.Controls.Add(this.DownloadLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modify";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private BGLabel RAMLB;
        private BGLabel CPULB;
        private BGLabel UploadLB;
        private BGLabel DownloadLB;
        private BGLabel TopLB;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button ModFontBtn;
        private System.Windows.Forms.Button ModForeColorBtn;
        private System.Windows.Forms.Button TopColorBtn;
        private System.Windows.Forms.Button BrushColorBtn;
        private System.Windows.Forms.Button WarningColorBtn;
        private System.Windows.Forms.Button BorderColorBtn;
        private System.Windows.Forms.Button BackgroundColorBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DefaltBtn;
    }
}