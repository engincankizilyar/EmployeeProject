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
    public partial class Duzenle : Form
    {
        public Duzenle()
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
        private void Duzenle_Load(object sender, EventArgs e)
        {
            showInfos();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        //Calisanlar ListView'ine Çift Tıklandığında Formdaki fields'ları Doldurması için ListView'e Double Click Eventi ile Çeşitlilik Kazandırıyoruz//
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
        private void btnSil_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            connect.Open();
            SqlCommand komut = new SqlCommand("Update calisanbigli set id='" + txtID.Text.ToString() + "',adsoyad='" + txtAdsoyad.Text.ToString() + "',departman='" + cboxDepartman.Text.ToString() + "',maas='" + txtMaas.Text.ToString() + "',telefon='" + txtTel.Text.ToString() + "',tc='" + txtTc.Text.ToString() + "'where id="+id +"",connect);

            komut.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Çalışan Bilgileri Başarıyla Güncellendi.!");
            showInfos();
            //Düzenleme işleminden sonra Kullanıcı açısından daha hoş görünmesi için formdaki fields'ların içlerini tekrar boşaltıyoruz//
            txtID.Clear();
            txtAdsoyad.Clear();
            txtMaas.Clear();
            txtTel.Clear();
            txtTc.Clear();
            cboxDepartman.Text = "";
        }

        
    }
}
