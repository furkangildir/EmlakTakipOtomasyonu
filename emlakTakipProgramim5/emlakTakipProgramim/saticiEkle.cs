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
namespace emlakTakipProgramim
{
    public partial class saticiEkle : Form
    {
        public saticiEkle()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!saticiVarmi(tbAdSoyad.Text.ToString()))
            {
                if (tbAdSoyad.Text != "" && tbTelefon.Text != "" && tbMail.Text != "")
                {
                    con.con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into saticilar(saticiAdiSoyadi,saticiTelefon,saticiEmail) Values(@adiSoyadi,@telefon,@mail)", con.con);
                    cmd.Parameters.AddWithValue("@adiSoyadi", tbAdSoyad.Text.ToString());
                    cmd.Parameters.AddWithValue("@telefon", tbTelefon.Text.ToString());
                    cmd.Parameters.AddWithValue("@mail", tbMail.Text.ToString());
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                    MessageBox.Show("Satıcı Eklendi...!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen tüm gerekli bilgileri giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Girilen satıcı adı kullanılmaktadır");
            }
        }
        private bool saticiVarmi(string saticiAdSoyad)
        {

            bool sonuc = false;
            if (con.con.State != ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("Select count(id) from saticilar where saticiAdiSoyadi='" + saticiAdSoyad + "'", con.con);
                con.con.Open();
                sonuc = Convert.ToInt32(cmd.ExecuteScalar()) > 0 ? true : false;
                con.con.Close();

            }
            return sonuc;
        }
    }
}
