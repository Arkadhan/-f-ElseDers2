
namespace İf_ElseDers2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbOrtalama = new System.Windows.Forms.TextBox();
            this.txtbDevamsizlik = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.gbRenkSec = new System.Windows.Forms.GroupBox();
            this.rbSari = new System.Windows.Forms.RadioButton();
            this.rbLacivert = new System.Windows.Forms.RadioButton();
            this.rbYesil = new System.Windows.Forms.RadioButton();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.gbMevsimler = new System.Windows.Forms.GroupBox();
            this.lbAylar = new System.Windows.Forms.ListBox();
            this.cbMevsimler = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbRasgeleSayi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbRenkSec.SuspendLayout();
            this.gbMevsimler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devamsızlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ortalama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.txtbDevamsizlik);
            this.groupBox1.Controls.Add(this.txtbOrtalama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geçti Kaldı Durumu";
            // 
            // txtbOrtalama
            // 
            this.txtbOrtalama.Location = new System.Drawing.Point(102, 21);
            this.txtbOrtalama.Name = "txtbOrtalama";
            this.txtbOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtbOrtalama.TabIndex = 2;
            // 
            // txtbDevamsizlik
            // 
            this.txtbDevamsizlik.Location = new System.Drawing.Point(103, 47);
            this.txtbDevamsizlik.Name = "txtbDevamsizlik";
            this.txtbDevamsizlik.Size = new System.Drawing.Size(100, 20);
            this.txtbDevamsizlik.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(102, 73);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(40, 120);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(41, 13);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum:";
            // 
            // gbRenkSec
            // 
            this.gbRenkSec.Controls.Add(this.btnRenkDegistir);
            this.gbRenkSec.Controls.Add(this.rbYesil);
            this.gbRenkSec.Controls.Add(this.rbLacivert);
            this.gbRenkSec.Controls.Add(this.rbSari);
            this.gbRenkSec.Location = new System.Drawing.Point(336, 35);
            this.gbRenkSec.Name = "gbRenkSec";
            this.gbRenkSec.Size = new System.Drawing.Size(201, 151);
            this.gbRenkSec.TabIndex = 3;
            this.gbRenkSec.TabStop = false;
            this.gbRenkSec.Text = "Renk Seçin";
            // 
            // rbSari
            // 
            this.rbSari.AutoSize = true;
            this.rbSari.Location = new System.Drawing.Point(23, 30);
            this.rbSari.Name = "rbSari";
            this.rbSari.Size = new System.Drawing.Size(43, 17);
            this.rbSari.TabIndex = 0;
            this.rbSari.TabStop = true;
            this.rbSari.Text = "Sarı";
            this.rbSari.UseVisualStyleBackColor = true;
            // 
            // rbLacivert
            // 
            this.rbLacivert.AutoSize = true;
            this.rbLacivert.Location = new System.Drawing.Point(23, 57);
            this.rbLacivert.Name = "rbLacivert";
            this.rbLacivert.Size = new System.Drawing.Size(63, 17);
            this.rbLacivert.TabIndex = 1;
            this.rbLacivert.TabStop = true;
            this.rbLacivert.Text = "Lacivert";
            this.rbLacivert.UseVisualStyleBackColor = true;
            // 
            // rbYesil
            // 
            this.rbYesil.AutoSize = true;
            this.rbYesil.Location = new System.Drawing.Point(22, 80);
            this.rbYesil.Name = "rbYesil";
            this.rbYesil.Size = new System.Drawing.Size(47, 17);
            this.rbYesil.TabIndex = 2;
            this.rbYesil.TabStop = true;
            this.rbYesil.Text = "Yeşil";
            this.rbYesil.UseVisualStyleBackColor = true;
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(54, 111);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(91, 26);
            this.btnRenkDegistir.TabIndex = 3;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // gbMevsimler
            // 
            this.gbMevsimler.Controls.Add(this.cbMevsimler);
            this.gbMevsimler.Controls.Add(this.lbAylar);
            this.gbMevsimler.Location = new System.Drawing.Point(38, 209);
            this.gbMevsimler.Name = "gbMevsimler";
            this.gbMevsimler.Size = new System.Drawing.Size(255, 173);
            this.gbMevsimler.TabIndex = 4;
            this.gbMevsimler.TabStop = false;
            this.gbMevsimler.Text = "Mevsimler";
            // 
            // lbAylar
            // 
            this.lbAylar.FormattingEnabled = true;
            this.lbAylar.Location = new System.Drawing.Point(21, 64);
            this.lbAylar.Name = "lbAylar";
            this.lbAylar.Size = new System.Drawing.Size(120, 95);
            this.lbAylar.TabIndex = 0;
            // 
            // cbMevsimler
            // 
            this.cbMevsimler.FormattingEnabled = true;
            this.cbMevsimler.Location = new System.Drawing.Point(21, 37);
            this.cbMevsimler.Name = "cbMevsimler";
            this.cbMevsimler.Size = new System.Drawing.Size(121, 21);
            this.cbMevsimler.TabIndex = 1;
            this.cbMevsimler.SelectedIndexChanged += new System.EventHandler(this.cbMevsimler_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRasgeleSayi);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(337, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sayı Üret";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbRasgeleSayi
            // 
            this.lbRasgeleSayi.FormattingEnabled = true;
            this.lbRasgeleSayi.Location = new System.Drawing.Point(53, 35);
            this.lbRasgeleSayi.Name = "lbRasgeleSayi";
            this.lbRasgeleSayi.Size = new System.Drawing.Size(120, 95);
            this.lbRasgeleSayi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMevsimler);
            this.Controls.Add(this.gbRenkSec);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRenkSec.ResumeLayout(false);
            this.gbRenkSec.PerformLayout();
            this.gbMevsimler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtbDevamsizlik;
        private System.Windows.Forms.TextBox txtbOrtalama;
        private System.Windows.Forms.GroupBox gbRenkSec;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.RadioButton rbYesil;
        private System.Windows.Forms.RadioButton rbLacivert;
        private System.Windows.Forms.RadioButton rbSari;
        private System.Windows.Forms.GroupBox gbMevsimler;
        private System.Windows.Forms.ComboBox cbMevsimler;
        private System.Windows.Forms.ListBox lbAylar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbRasgeleSayi;
        private System.Windows.Forms.Button button1;
    }
}

