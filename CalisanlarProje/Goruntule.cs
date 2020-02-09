using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CalisanlarProje
{
    public partial class Goruntule : Form
    {
        public Goruntule()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MSI; Initial Catalog=Calisanlar;Persist Security Info=False; User ID=sa; Password=123");

        private void showInfos()
        {
            CalisanlarListe.Items.Clear();
            connect.Open();

            SqlCommand komut = new SqlCommand("Select * from calisanbigli", connect);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = read["id"].ToString();
                ekle.SubItems.Add(read["adsoyad"].ToString());
                ekle.SubItems.Add(read["departman"].ToString());
                ekle.SubItems.Add(read["maas"].ToString());
                ekle.SubItems.Add(read["telefon"].ToString());
                ekle.SubItems.Add(read["tc"].ToString());

                CalisanlarListe.Items.Add(ekle);
            }
            connect.Close();
        }
        private void Goruntule_Load(object sender, EventArgs e)
        {
            showInfos();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
