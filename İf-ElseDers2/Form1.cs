using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İf_ElseDers2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int ort = Convert.ToInt32(txtbOrtalama.Text);
                int dev = Convert.ToInt32(txtbDevamsizlik.Text);

                if (ort>=70 && dev<=16)
                {
                    lblDurum.Text = "Durum: Helal Mezun oldunuz";
                }
                else
                {
                    lblDurum.Text = "Durum: Bravo Okulu uzattınız";
                }
            }
            catch
            {
                MessageBox.Show("Sayı girmelisiniz", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            if (rbSari.Checked)
            {
                gbRenkSec.BackColor = Color.Yellow;
            }
            else if( rbLacivert.Checked)
            {
                gbRenkSec.BackColor = Color.Aqua;
            }
            else if(rbYesil.Checked)
            {
                gbRenkSec.BackColor = Color.Green;
            }
            else
            {
                gbRenkSec.BackColor = Color.Gold;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMevsimler.Items.Add("İlkbahar");
            cbMevsimler.Items.Add("Yaz");
            cbMevsimler.Items.Add("Sonbahar");
            cbMevsimler.Items.Add("Kış");
        }

        private void cbMevsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAylar.Items.Clear();
            string secilen =Convert.ToString(cbMevsimler.SelectedItem);
            if (secilen=="Yaz")
            {
                lbAylar.Items.Add("Haziran");
                lbAylar.Items.Add("Temmuz");
                lbAylar.Items.Add("Ağustos");

            }
            else if (secilen=="Sonbahar")
            {
                lbAylar.Items.Add("Eylül");
                lbAylar.Items.Add("Ekim");
                lbAylar.Items.Add("Kasım");

            }
            else if(secilen=="Kış")
            {
                lbAylar.Items.Add("Aralık");
                lbAylar.Items.Add("Ocak");
                lbAylar.Items.Add("Şubat");
            }
            else if(secilen=="İlkbahar")
            {
                lbAylar.Items.Add("Mart");
                lbAylar.Items.Add("Nisan");
                lbAylar.Items.Add("Mayıs");
            }

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rSayi = rnd.Next(1,100);
            lbRasgeleSayi.Items.Add(rSayi);

        }
    }
}
