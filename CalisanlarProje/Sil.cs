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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MSI; Initial Catalog=Calisanlar;Persist Security Info=False; User ID=sa; Password=123");
        //Ana Yordam verileri Databse'deki Göstermek için bu yordam kullanılacak//
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
        private void CalisanlarListe_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(CalisanlarListe.SelectedItems[0].SubItems[0].Text);

            txtID.Text = CalisanlarListe.SelectedItems[0].SubItems[0].Text;
            txtAdsoyad.Text = CalisanlarListe.SelectedItems[0].SubItems[1].Text;
            cboxDepartman.Text = CalisanlarListe.SelectedItems[0].SubItems[2].Text;
            txtMaas.Text = CalisanlarListe.SelectedItems[0].SubItems[3].Text;
            txtTel.Text = CalisanlarListe.SelectedItems[0].SubItems[4].Text;
            txtTc.Text = CalisanlarListe.SelectedItems[0].SubItems[5].Text;
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            showInfos();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            connect.Open();
            SqlCommand komut = new SqlCommand("Delete from calisanbigli where id=(" + id + ")",connect);
            komut.ExecuteNonQuery();

            txtID.Clear();
            txtAdsoyad.Clear();
            cboxDepartman.Text = "";
            txtMaas.Clear();
            txtTc.Clear();
            txtTel.Clear();

            connect.Close();
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
