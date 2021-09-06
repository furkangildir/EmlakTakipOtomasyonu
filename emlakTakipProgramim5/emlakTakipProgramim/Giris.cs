using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakTakipProgramim
{
    public partial class Giris : Form
    {
        public Giris()
        {
            
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        public static int id;
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            frmUyeOl uyeOl = new frmUyeOl();
            uyeOl.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            con.con.Open();
            SqlCommand cmd = new SqlCommand("Select *from kullaniciBilgi where kullaniciTakmaAd=@KAdi and kullaniciSifre=@KParola", con.con);
            cmd.Parameters.AddWithValue("@KAdi", tbKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@KParola", tbSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    if (dr["t_kulId"].ToString() == "1")
                    {
                        id = Convert.ToInt32(dr["t_kulId"]);
                        anaForm form1 = new anaForm();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        id = Convert.ToInt32(dr["t_kulId"]);
                        anaForm form1 = new anaForm();
                        form1.Show();
                        this.Hide();
                    }
                }

            }
            else { MessageBox.Show("Kullanıcı Adı ve şifreniz yanlış veya üye değilsiniz...!"); }




            con.con.Close();
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

           

        }
      
            
        
    }
}
