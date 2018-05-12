namespace Hammadde_Taşıma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_araç = new System.Windows.Forms.PictureBox();
            this.progressBar_hammadde = new System.Windows.Forms.ProgressBar();
            this.label_alt = new System.Windows.Forms.Label();
            this.button_ev = new System.Windows.Forms.Button();
            this.button_ist1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer_x = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_ist2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button_ist3 = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.timer_y = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_araç)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_araç
            // 
            this.pictureBox_araç.BackColor = System.Drawing.Color.Olive;
            this.pictureBox_araç.Location = new System.Drawing.Point(140, 417);
            this.pictureBox_araç.Name = "pictureBox_araç";
            this.pictureBox_araç.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_araç.TabIndex = 0;
            this.pictureBox_araç.TabStop = false;
            // 
            // progressBar_hammadde
            // 
            this.progressBar_hammadde.Location = new System.Drawing.Point(125, 530);
            this.progressBar_hammadde.Name = "progressBar_hammadde";
            this.progressBar_hammadde.Size = new System.Drawing.Size(100, 23);
            this.progressBar_hammadde.TabIndex = 1;
            this.progressBar_hammadde.Value = 100;
            // 
            // label_alt
            // 
            this.label_alt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_alt.Location = new System.Drawing.Point(10, 470);
            this.label_alt.Name = "label_alt";
            this.label_alt.Size = new System.Drawing.Size(950, 20);
            this.label_alt.TabIndex = 2;
            // 
            // button_ev
            // 
            this.button_ev.Location = new System.Drawing.Point(140, 500);
            this.button_ev.Name = "button_ev";
            this.button_ev.Size = new System.Drawing.Size(75, 23);
            this.button_ev.TabIndex = 3;
            this.button_ev.Text = "Ev";
            this.button_ev.UseVisualStyleBackColor = true;
            this.button_ev.Click += new System.EventHandler(this.button_ev_Click);
            // 
            // button_ist1
            // 
            this.button_ist1.Location = new System.Drawing.Point(612, 500);
            this.button_ist1.Name = "button_ist1";
            this.button_ist1.Size = new System.Drawing.Size(75, 23);
            this.button_ist1.TabIndex = 5;
            this.button_ist1.Text = "İstasyon 1";
            this.button_ist1.UseVisualStyleBackColor = true;
            this.button_ist1.Click += new System.EventHandler(this.button_ist1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(597, 528);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // timer_x
            // 
            this.timer_x.Enabled = true;
            this.timer_x.Interval = 1;
            this.timer_x.Tick += new System.EventHandler(this.timer_x_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(940, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 372);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(92, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(786, 20);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 372);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(92, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 220);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(858, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 220);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(950, 20);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(92, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(786, 20);
            this.label7.TabIndex = 12;
            // 
            // button_ist2
            // 
            this.button_ist2.Location = new System.Drawing.Point(612, 12);
            this.button_ist2.Name = "button_ist2";
            this.button_ist2.Size = new System.Drawing.Size(75, 23);
            this.button_ist2.TabIndex = 16;
            this.button_ist2.Text = "İstasyon 2";
            this.button_ist2.UseVisualStyleBackColor = true;
            this.button_ist2.Click += new System.EventHandler(this.button_ist2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(597, 40);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 15;
            this.progressBar2.Value = 100;
            // 
            // button_ist3
            // 
            this.button_ist3.Location = new System.Drawing.Point(140, 12);
            this.button_ist3.Name = "button_ist3";
            this.button_ist3.Size = new System.Drawing.Size(75, 23);
            this.button_ist3.TabIndex = 14;
            this.button_ist3.Text = "İstasyon 3";
            this.button_ist3.UseVisualStyleBackColor = true;
            this.button_ist3.Click += new System.EventHandler(this.button_ist3_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(125, 42);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.TabIndex = 13;
            this.progressBar3.Value = 100;
            // 
            // timer_y
            // 
            this.timer_y.Enabled = true;
            this.timer_y.Interval = 1;
            this.timer_y.Tick += new System.EventHandler(this.timer_y_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 571);
            this.Controls.Add(this.button_ist2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.button_ist3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ist1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_ev);
            this.Controls.Add(this.label_alt);
            this.Controls.Add(this.progressBar_hammadde);
            this.Controls.Add(this.pictureBox_araç);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hammadde Taşıma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_araç)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_araç;
        private System.Windows.Forms.ProgressBar progressBar_hammadde;
        private System.Windows.Forms.Label label_alt;
        private System.Windows.Forms.Button button_ev;
        private System.Windows.Forms.Button button_ist1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ist2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button_ist3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Timer timer_y;
    }
}

