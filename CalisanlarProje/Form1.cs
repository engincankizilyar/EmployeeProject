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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        String username = "admin";
        String password = "123";
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals(username)&&txtPassword.Text.Equals(password))
            {
                MessageBox.Show("Giriş Başarılı!!");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı Lütfen Tekrar Deneyiniz!");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yazılımcı:Engincan Kızılyar(aka:Redcliff)");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
