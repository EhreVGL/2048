namespace _2048
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ana_panel = new System.Windows.Forms.Panel();
            this.prodby = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.basla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kare_label1 = new System.Windows.Forms.Label();
            this.kare_label2 = new System.Windows.Forms.Label();
            this.kare_label3 = new System.Windows.Forms.Label();
            this.kare_label4 = new System.Windows.Forms.Label();
            this.kare_label5 = new System.Windows.Forms.Label();
            this.kare_label6 = new System.Windows.Forms.Label();
            this.kare_label7 = new System.Windows.Forms.Label();
            this.kare_label8 = new System.Windows.Forms.Label();
            this.kare_label9 = new System.Windows.Forms.Label();
            this.kare_label10 = new System.Windows.Forms.Label();
            this.kare_label11 = new System.Windows.Forms.Label();
            this.kare_label12 = new System.Windows.Forms.Label();
            this.kare_label13 = new System.Windows.Forms.Label();
            this.kare_label14 = new System.Windows.Forms.Label();
            this.kare_label15 = new System.Windows.Forms.Label();
            this.kare_label16 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.ana_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ana_panel
            // 
            this.ana_panel.BackColor = System.Drawing.Color.DarkSalmon;
            this.ana_panel.Controls.Add(this.prodby);
            this.ana_panel.Controls.Add(this.cikis);
            this.ana_panel.Controls.Add(this.basla);
            this.ana_panel.Controls.Add(this.pictureBox1);
            this.ana_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ana_panel.Location = new System.Drawing.Point(0, 0);
            this.ana_panel.Name = "ana_panel";
            this.ana_panel.Size = new System.Drawing.Size(958, 661);
            this.ana_panel.TabIndex = 0;
            // 
            // prodby
            // 
            this.prodby.AutoSize = true;
            this.prodby.Location = new System.Drawing.Point(429, 615);
            this.prodby.Name = "prodby";
            this.prodby.Size = new System.Drawing.Size(85, 13);
            this.prodby.TabIndex = 3;
            this.prodby.Text = "prodby EhreVGL";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Salmon;
            this.cikis.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold);
            this.cikis.ForeColor = System.Drawing.Color.Thistle;
            this.cikis.Location = new System.Drawing.Point(374, 433);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(168, 75);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.Color.Salmon;
            this.basla.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold);
            this.basla.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.basla.Location = new System.Drawing.Point(374, 352);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(168, 75);
            this.basla.TabIndex = 1;
            this.basla.Text = "BAŞLA";
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2048.Properties.Resources.anasayfa;
            this.pictureBox1.Location = new System.Drawing.Point(312, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kare_label1
            // 
            this.kare_label1.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label1.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold);
            this.kare_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label1.Location = new System.Drawing.Point(255, 30);
            this.kare_label1.Name = "kare_label1";
            this.kare_label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label1.Size = new System.Drawing.Size(120, 120);
            this.kare_label1.TabIndex = 1;
            this.kare_label1.Text = "1";
            this.kare_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label2
            // 
            this.kare_label2.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label2.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label2.Location = new System.Drawing.Point(385, 30);
            this.kare_label2.Name = "kare_label2";
            this.kare_label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label2.Size = new System.Drawing.Size(120, 120);
            this.kare_label2.TabIndex = 1;
            this.kare_label2.Text = "1";
            this.kare_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label3
            // 
            this.kare_label3.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label3.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label3.Location = new System.Drawing.Point(515, 30);
            this.kare_label3.Name = "kare_label3";
            this.kare_label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label3.Size = new System.Drawing.Size(120, 120);
            this.kare_label3.TabIndex = 2;
            this.kare_label3.Text = "1";
            this.kare_label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label4
            // 
            this.kare_label4.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label4.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label4.Location = new System.Drawing.Point(645, 30);
            this.kare_label4.Name = "kare_label4";
            this.kare_label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label4.Size = new System.Drawing.Size(120, 120);
            this.kare_label4.TabIndex = 3;
            this.kare_label4.Text = "1";
            this.kare_label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label5
            // 
            this.kare_label5.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label5.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label5.Location = new System.Drawing.Point(255, 160);
            this.kare_label5.Name = "kare_label5";
            this.kare_label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label5.Size = new System.Drawing.Size(120, 120);
            this.kare_label5.TabIndex = 4;
            this.kare_label5.Text = "1";
            this.kare_label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label6
            // 
            this.kare_label6.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label6.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label6.Location = new System.Drawing.Point(385, 160);
            this.kare_label6.Name = "kare_label6";
            this.kare_label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label6.Size = new System.Drawing.Size(120, 120);
            this.kare_label6.TabIndex = 5;
            this.kare_label6.Text = "1";
            this.kare_label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label7
            // 
            this.kare_label7.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label7.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label7.Location = new System.Drawing.Point(515, 160);
            this.kare_label7.Name = "kare_label7";
            this.kare_label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label7.Size = new System.Drawing.Size(120, 120);
            this.kare_label7.TabIndex = 6;
            this.kare_label7.Text = "1";
            this.kare_label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label8
            // 
            this.kare_label8.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label8.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label8.Location = new System.Drawing.Point(645, 160);
            this.kare_label8.Name = "kare_label8";
            this.kare_label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label8.Size = new System.Drawing.Size(120, 120);
            this.kare_label8.TabIndex = 7;
            this.kare_label8.Text = "1";
            this.kare_label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label9
            // 
            this.kare_label9.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label9.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label9.Location = new System.Drawing.Point(255, 290);
            this.kare_label9.Name = "kare_label9";
            this.kare_label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label9.Size = new System.Drawing.Size(120, 120);
            this.kare_label9.TabIndex = 8;
            this.kare_label9.Text = "1";
            this.kare_label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label10
            // 
            this.kare_label10.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label10.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label10.Location = new System.Drawing.Point(385, 290);
            this.kare_label10.Name = "kare_label10";
            this.kare_label10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label10.Size = new System.Drawing.Size(120, 120);
            this.kare_label10.TabIndex = 9;
            this.kare_label10.Text = "1";
            this.kare_label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label11
            // 
            this.kare_label11.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label11.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label11.Location = new System.Drawing.Point(515, 290);
            this.kare_label11.Name = "kare_label11";
            this.kare_label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label11.Size = new System.Drawing.Size(120, 120);
            this.kare_label11.TabIndex = 10;
            this.kare_label11.Text = "1";
            this.kare_label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label12
            // 
            this.kare_label12.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label12.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label12.Location = new System.Drawing.Point(645, 290);
            this.kare_label12.Name = "kare_label12";
            this.kare_label12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label12.Size = new System.Drawing.Size(120, 120);
            this.kare_label12.TabIndex = 11;
            this.kare_label12.Text = "1";
            this.kare_label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label13
            // 
            this.kare_label13.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label13.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label13.Location = new System.Drawing.Point(255, 420);
            this.kare_label13.Name = "kare_label13";
            this.kare_label13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label13.Size = new System.Drawing.Size(120, 120);
            this.kare_label13.TabIndex = 12;
            this.kare_label13.Text = "1";
            this.kare_label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label14
            // 
            this.kare_label14.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label14.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label14.Location = new System.Drawing.Point(385, 420);
            this.kare_label14.Name = "kare_label14";
            this.kare_label14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label14.Size = new System.Drawing.Size(120, 120);
            this.kare_label14.TabIndex = 13;
            this.kare_label14.Text = "1";
            this.kare_label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label15
            // 
            this.kare_label15.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label15.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label15.Location = new System.Drawing.Point(515, 420);
            this.kare_label15.Name = "kare_label15";
            this.kare_label15.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label15.Size = new System.Drawing.Size(120, 120);
            this.kare_label15.TabIndex = 14;
            this.kare_label15.Text = "1";
            this.kare_label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kare_label16
            // 
            this.kare_label16.BackColor = System.Drawing.Color.PeachPuff;
            this.kare_label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kare_label16.Font = new System.Drawing.Font("Constantia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kare_label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kare_label16.Location = new System.Drawing.Point(645, 420);
            this.kare_label16.Name = "kare_label16";
            this.kare_label16.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.kare_label16.Size = new System.Drawing.Size(120, 120);
            this.kare_label16.TabIndex = 15;
            this.kare_label16.Text = "1";
            this.kare_label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(94, 573);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(540, 37);
            this.label32.TabIndex = 16;
            this.label32.Text = "Yön tuşları ile oyunu oynayabilirsiniz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.kare_label16);
            this.panel1.Controls.Add(this.kare_label15);
            this.panel1.Controls.Add(this.kare_label14);
            this.panel1.Controls.Add(this.kare_label13);
            this.panel1.Controls.Add(this.kare_label12);
            this.panel1.Controls.Add(this.kare_label11);
            this.panel1.Controls.Add(this.kare_label10);
            this.panel1.Controls.Add(this.kare_label9);
            this.panel1.Controls.Add(this.kare_label8);
            this.panel1.Controls.Add(this.kare_label7);
            this.panel1.Controls.Add(this.kare_label6);
            this.panel1.Controls.Add(this.kare_label5);
            this.panel1.Controls.Add(this.kare_label4);
            this.panel1.Controls.Add(this.kare_label3);
            this.panel1.Controls.Add(this.kare_label2);
            this.panel1.Controls.Add(this.kare_label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 661);
            this.panel1.TabIndex = 16;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(95, 615);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(734, 37);
            this.label33.TabIndex = 17;
            this.label33.Text = "Hareket edemeyecek duruma gelirseniz oyun biter.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 661);
            this.Controls.Add(this.ana_panel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "2048";
            this.ana_panel.ResumeLayout(false);
            this.ana_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ana_panel;
        private System.Windows.Forms.Label prodby;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label kare_label16;
        private System.Windows.Forms.Label kare_label15;
        private System.Windows.Forms.Label kare_label14;
        private System.Windows.Forms.Label kare_label13;
        private System.Windows.Forms.Label kare_label12;
        private System.Windows.Forms.Label kare_label11;
        private System.Windows.Forms.Label kare_label10;
        private System.Windows.Forms.Label kare_label9;
        private System.Windows.Forms.Label kare_label8;
        private System.Windows.Forms.Label kare_label7;
        private System.Windows.Forms.Label kare_label6;
        private System.Windows.Forms.Label kare_label5;
        private System.Windows.Forms.Label kare_label4;
        private System.Windows.Forms.Label kare_label3;
        private System.Windows.Forms.Label kare_label2;
        private System.Windows.Forms.Label kare_label1;
    }
}

