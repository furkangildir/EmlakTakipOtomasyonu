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
    public partial class frmUyeOl : Form
    {
        public frmUyeOl()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (!kullaniciVarmi(tbKullaniciAdi.Text.ToString()))
            {
                if (tbKullaniciAdi.Text != "" && tbAdi.Text != "" && tbSoyadi.Text != "" && tbSifre.Text != "" && tbMail.Text != "" && tbTelefon.Text != "")
                {
                    con.con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into kullaniciBilgi(kullaniciTakmaAd,kullaniciAdi,kullaniciSoyadi,kullaniciSifre,kullaniciMail,kullaniciTelefon) Values(@kullaniciAdi,@Ad,@Soyad,@Sifre,@Mail,@Telefon);" +
                        "Insert into yetkiler(kulId) Values((Select max(t_kulId) from kullaniciBilgi))", con.con);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", tbKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Ad", tbAdi.Text.ToString());
                    cmd.Parameters.AddWithValue("@Soyad", tbSoyadi.Text.ToString());
                    cmd.Parameters.AddWithValue("@Sifre", tbSifre.Text.ToString());
                    cmd.Parameters.AddWithValue("@Mail", tbMail.Text.ToString());
                    cmd.Parameters.AddWithValue("@Telefon", tbTelefon.Text.ToString());
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                    MessageBox.Show("Üyeliğiniz başarıyla gerçekleşti..");
                    this.Close();
                    

                }
                else
                {
                    MessageBox.Show("Lütfen gerekli bilgileri giriniz");
                }
            }
            else
            {
                MessageBox.Show("Girilen kullanıcı adı kullanılmaktadır");
            }
        }

        private bool kullaniciVarmi(string kullaniciAd)
        {

            bool sonuc = false;
            if (con.con.State != ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("Select count(t_kulId) from kullaniciBilgi where kullaniciTakmaAd='" + kullaniciAd + "'", con.con);
                con.con.Open();
                sonuc = Convert.ToInt32(cmd.ExecuteScalar()) > 0 ? true : false;
                con.con.Close();

            }
            return sonuc;
        }
    }
}
