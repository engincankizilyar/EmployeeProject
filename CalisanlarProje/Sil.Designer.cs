﻿namespace CalisanlarProje
{
    partial class Sil
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
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.cboxDepartman = new System.Windows.Forms.ComboBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CalisanlarListe = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(686, 332);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 64);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Çalışan Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(686, 199);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(158, 22);
            this.txtTel.TabIndex = 35;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(686, 276);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(158, 22);
            this.txtTc.TabIndex = 34;
            // 
            // cboxDepartman
            // 
            this.cboxDepartman.FormattingEnabled = true;
            this.cboxDepartman.Items.AddRange(new object[] {
            "Bilişim",
            "Yönetim",
            "Sağlık",
            "Temizlik",
            "Güvenlik"});
            this.cboxDepartman.Location = new System.Drawing.Point(302, 286);
            this.cboxDepartman.Name = "cboxDepartman";
            this.cboxDepartman.Size = new System.Drawing.Size(158, 24);
            this.cboxDepartman.TabIndex = 33;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(302, 354);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(158, 22);
            this.txtMaas.TabIndex = 32;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(302, 216);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(158, 22);
            this.txtAdsoyad.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(302, 149);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 22);
            this.txtID.TabIndex = 30;
            // 
            // CalisanlarListe
            // 
            this.CalisanlarListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adsoyad,
            this.departman,
            this.maas,
            this.telefon,
            this.tc});
            this.CalisanlarListe.HideSelection = false;
            this.CalisanlarListe.Location = new System.Drawing.Point(52, 421);
            this.CalisanlarListe.Name = "CalisanlarListe";
            this.CalisanlarListe.Size = new System.Drawing.Size(920, 260);
            this.CalisanlarListe.TabIndex = 29;
            this.CalisanlarListe.UseCompatibleStateImageBehavior = false;
            this.CalisanlarListe.View = System.Windows.Forms.View.Details;
            this.CalisanlarListe.DoubleClick += new System.EventHandler(this.CalisanlarListe_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "Ad-Soyad";
            this.adsoyad.Width = 147;
            // 
            // departman
            // 
            this.departman.Text = "Departman";
            this.departman.Width = 141;
            // 
            // maas
            // 
            this.maas.Text = "Maaş";
            this.maas.Width = 109;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon No";
            this.telefon.Width = 196;
            // 
            // tc
            // 
            this.tc.Text = "TC No";
            this.tc.Width = 185;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(559, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 39);
            this.label6.TabIndex = 28;
            this.label6.Text = "TC No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(541, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 39);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(120, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(120, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Departman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(120, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(120, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(341, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 67);
            this.label7.TabIndex = 38;
            this.label7.Text = "Çalışan Silme Modülü";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGeri.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ForeColor = System.Drawing.Color.Black;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(142, 51);
            this.btnGeri.TabIndex = 41;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CalisanlarProje.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(271, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalisanlarProje.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(702, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CalisanlarProje.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(566, 332);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1053, 711);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.cboxDepartman);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtAdsoyad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CalisanlarListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sil";
            this.Text = "Çalışan Sil";
            this.Load += new System.EventHandler(this.Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.ComboBox cboxDepartman;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListView CalisanlarListe;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader departman;
        private System.Windows.Forms.ColumnHeader maas;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeri;
    }
}