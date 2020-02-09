using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalisanlarProje
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGörüntüle_Click(object sender, EventArgs e)
        {
            Goruntule goruntule = new Goruntule();
            goruntule.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AdminGiris giris = new AdminGiris();
            giris.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil sil = new Sil();
            sil.Show();
            this.Hide();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            Duzenle duzenle = new Duzenle();
            duzenle.Show();
            this.Hide();
        }
    }
}
