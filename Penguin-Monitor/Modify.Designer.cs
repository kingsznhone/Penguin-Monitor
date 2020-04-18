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
            this.ModFontBtn.Location = new System.Drawing.Point(142, 225);
            this.ModFontBtn.Name = "ModFontBtn";
            this.ModFontBtn.Size = new System.Drawing.Size(100, 35);
            this.ModFontBtn.TabIndex = 6;
            this.ModFontBtn.Text = "字体";
            this.ModFontBtn.UseVisualStyleBackColor = true;
            this.ModFontBtn.Click += new System.EventHandler(this.ModFontBtn_Click);
            // 
            // ModForeColorBtn
            // 
            this.ModForeColorBtn.Location = new System.Drawing.Point(274, 174);
            this.ModForeColorBtn.Name = "ModForeColorBtn";
            this.ModForeColorBtn.Size = new System.Drawing.Size(100, 35);
            this.ModForeColorBtn.TabIndex = 6;
            this.ModForeColorBtn.Text = "文字颜色";
            this.ModForeColorBtn.UseVisualStyleBackColor = true;
            this.ModForeColorBtn.Click += new System.EventHandler(this.ModForeColorBtn_Click);
            // 
            // TopColorBtn
            // 
            this.TopColorBtn.Location = new System.Drawing.Point(12, 12);
            this.TopColorBtn.Name = "TopColorBtn";
            this.TopColorBtn.Size = new System.Drawing.Size(100, 35);
            this.TopColorBtn.TabIndex = 6;
            this.TopColorBtn.Text = "顶部颜色";
            this.TopColorBtn.UseVisualStyleBackColor = true;
            this.TopColorBtn.Click += new System.EventHandler(this.TopColorBtn_Click);
            // 
            // BrushColorBtn
            // 
            this.BrushColorBtn.Location = new System.Drawing.Point(12, 174);
            this.BrushColorBtn.Name = "BrushColorBtn";
            this.BrushColorBtn.Size = new System.Drawing.Size(100, 35);
            this.BrushColorBtn.TabIndex = 6;
            this.BrushColorBtn.Text = "曲线颜色";
            this.BrushColorBtn.UseVisualStyleBackColor = true;
            this.BrushColorBtn.Click += new System.EventHandler(this.BrushColorBtn_Click);
            // 
            // WarningColorBtn
            // 
            this.WarningColorBtn.Location = new System.Drawing.Point(142, 12);
            this.WarningColorBtn.Name = "WarningColorBtn";
            this.WarningColorBtn.Size = new System.Drawing.Size(100, 35);
            this.WarningColorBtn.TabIndex = 6;
            this.WarningColorBtn.Text = "警告颜色";
            this.WarningColorBtn.UseVisualStyleBackColor = true;
            this.WarningColorBtn.Click += new System.EventHandler(this.WarningColorBtn_Click);
            // 
            // BorderColorBtn
            // 
            this.BorderColorBtn.Location = new System.Drawing.Point(274, 12);
            this.BorderColorBtn.Name = "BorderColorBtn";
            this.BorderColorBtn.Size = new System.Drawing.Size(100, 35);
            this.BorderColorBtn.TabIndex = 6;
            this.BorderColorBtn.Text = "边框颜色";
            this.BorderColorBtn.UseVisualStyleBackColor = true;
            this.BorderColorBtn.Click += new System.EventHandler(this.BorderColorBtn_Click);
            // 
            // TopLB
            // 
            this.TopLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(197)))));
            this.TopLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.TopLB.ForeColor = System.Drawing.Color.White;
            this.TopLB.Location = new System.Drawing.Point(76, 67);
            this.TopLB.Name = "TopLB";
            this.TopLB.Size = new System.Drawing.Size(240, 5);
            this.TopLB.TabIndex = 5;
            // 
            // RAMLB
            // 
            this.RAMLB.BackColor = System.Drawing.Color.Black;
            this.RAMLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RAMLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.RAMLB.Location = new System.Drawing.Point(196, 112);
            this.RAMLB.Name = "RAMLB";
            this.RAMLB.Size = new System.Drawing.Size(120, 40);
            this.RAMLB.TabIndex = 1;
            this.RAMLB.Text = "RAM 25%";
            this.RAMLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPULB
            // 
            this.CPULB.BackColor = System.Drawing.Color.Black;
            this.CPULB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CPULB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.CPULB.Location = new System.Drawing.Point(196, 72);
            this.CPULB.Name = "CPULB";
            this.CPULB.Size = new System.Drawing.Size(120, 40);
            this.CPULB.TabIndex = 2;
            this.CPULB.Text = "CPU 98%";
            this.CPULB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadLB
            // 
            this.UploadLB.BackColor = System.Drawing.Color.Black;
            this.UploadLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.UploadLB.Location = new System.Drawing.Point(76, 112);
            this.UploadLB.Name = "UploadLB";
            this.UploadLB.Size = new System.Drawing.Size(120, 40);
            this.UploadLB.TabIndex = 3;
            this.UploadLB.Text = "↑ 853.1KB/s";
            this.UploadLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownloadLB
            // 
            this.DownloadLB.BackColor = System.Drawing.Color.Black;
            this.DownloadLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownloadLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(166)))));
            this.DownloadLB.Location = new System.Drawing.Point(76, 72);
            this.DownloadLB.Name = "DownloadLB";
            this.DownloadLB.Size = new System.Drawing.Size(120, 40);
            this.DownloadLB.TabIndex = 4;
            this.DownloadLB.Text = "↓ 7.8MB/s";
            this.DownloadLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackgroundColorBtn
            // 
            this.BackgroundColorBtn.Location = new System.Drawing.Point(142, 174);
            this.BackgroundColorBtn.Name = "BackgroundColorBtn";
            this.BackgroundColorBtn.Size = new System.Drawing.Size(100, 35);
            this.BackgroundColorBtn.TabIndex = 6;
            this.BackgroundColorBtn.Text = "背景颜色";
            this.BackgroundColorBtn.UseVisualStyleBackColor = true;
            this.BackgroundColorBtn.Click += new System.EventHandler(this.BackgroundColorBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(274, 225);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 35);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DefaltBtn
            // 
            this.DefaltBtn.Location = new System.Drawing.Point(12, 225);
            this.DefaltBtn.Name = "DefaltBtn";
            this.DefaltBtn.Size = new System.Drawing.Size(100, 35);
            this.DefaltBtn.TabIndex = 6;
            this.DefaltBtn.Text = "恢复默认";
            this.DefaltBtn.UseVisualStyleBackColor = true;
            this.DefaltBtn.Click += new System.EventHandler(this.DefaltBtn_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 273);
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
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modify";
            this.Text = "自定义";
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