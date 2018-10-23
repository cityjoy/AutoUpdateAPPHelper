namespace KnightsWarriorAutoupdater
{
    partial class DownloadProgress
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadProgress));
            this.labelCurrentItem = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.progressBarCurrent = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentItem
            // 
            this.labelCurrentItem.AutoSize = true;
            this.labelCurrentItem.Location = new System.Drawing.Point(112, 106);
            this.labelCurrentItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentItem.Name = "labelCurrentItem";
            this.labelCurrentItem.Size = new System.Drawing.Size(0, 15);
            this.labelCurrentItem.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(513, 11);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(111, 29);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Cancel";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OnCancel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBarTotal);
            this.panel2.Controls.Add(this.progressBarCurrent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelCurrent);
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(-4, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 166);
            this.panel2.TabIndex = 4;
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(44, 109);
            this.progressBarTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(584, 15);
            this.progressBarTotal.Step = 1;
            this.progressBarTotal.TabIndex = 4;
            // 
            // progressBarCurrent
            // 
            this.progressBarCurrent.Location = new System.Drawing.Point(43, 43);
            this.progressBarCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarCurrent.Name = "progressBarCurrent";
            this.progressBarCurrent.Size = new System.Drawing.Size(584, 15);
            this.progressBarCurrent.Step = 1;
            this.progressBarCurrent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "进度：";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(40, 9);
            this.labelCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(76, 15);
            this.labelCurrent.TabIndex = 3;
            this.labelCurrent.Text = "下载中...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "准备应用程序...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonOk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 52);
            this.panel3.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 79);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(664, 2);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 248);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(664, 2);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "正在更新软件,请稍等。";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(545, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 79);
            this.panel1.TabIndex = 3;
            // 
            // DownloadProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 302);
            this.ControlBox = false;
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCurrentItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新软件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentItem;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.ProgressBar progressBarCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}