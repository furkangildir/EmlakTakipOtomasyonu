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
    public partial class Alicilar : Form
    {
        public Alicilar()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        DataTable dt = new DataTable();
        private void Alicilar_Load(object sender, EventArgs e)
        {
            aliciGetir();
            ilanBasligiGetir();
            dgAlicilar_FormatAlicilar();
            kontrolTemizle();
        }
        private void aliciGetir()
        {
            con.con.Open();
            dt.Columns.Clear();
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select *from Alicilar", con.con);
            da.Fill(dt);
            dgAlicilar.DataSource = dt;
            con.con.Close();
        }
        public void dgAlicilar_FormatAlicilar()
        {
            dgAlicilar.Columns["id"].HeaderText = "İd";
            dgAlicilar.Columns["aliciAd"].HeaderText = "Adı";
            dgAlicilar.Columns["aliciSoyad"].HeaderText = "Soyadı";
            dgAlicilar.Columns["alicitelefon"].HeaderText = "Telefon";
            dgAlicilar.Columns["aliciMail"].HeaderText = "Mail Adresi";
            dgAlicilar.Columns["aliciEmlakTuru"].HeaderText = "Aldığı Emlağın Türü";
            dgAlicilar.Columns["aliciIlanBasligi"].HeaderText = "Aldığı Emlağın Başlığı";
            dgAlicilar.Columns["aliciEmlakTuru"].Width = 140;
            dgAlicilar.Columns["id"].Width = 50;
            dgAlicilar.Columns["aliciIlanBasligi"].Width = 150;
            dgAlicilar.Columns["aliciAd"].Width = 80;
            dgAlicilar.Columns["aliciSoyad"].Width = 80;
            dgAlicilar.DefaultCellStyle.BackColor = Color.GhostWhite;
            dgAlicilar.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgAlicilar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgAlicilar.Font = new Font("Tahoma", 8.0F,FontStyle.Regular);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbAd.Text.ToString() != "" && tbSoyad.Text.ToString() != "" && tbMail.Text.ToString() != "" && tbTelefon.Text.ToString() != "" && cbEmlakTuru.Text.ToString() != "" && cbIlanBasligi.Text.ToString() != "")
            {
                if (aliciVarmi(tbAd.Text.ToString(), tbSoyad.Text.ToString(),cbIlanBasligi.Text.ToString()))
                {
                    con.con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Alicilar(aliciAd,aliciSoyad,alicitelefon,aliciMail,aliciEmlakTuru,aliciIlanBasligi) Values(@aliciAd,@aliciSoyad,@alicitelefon,@aliciMail,@aliciEmlakTuru,@aliciIlanBasligi)", con.con);
                    cmd.Parameters.AddWithValue("@aliciAd", tbAd.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciSoyad", tbSoyad.Text.ToString());
                    cmd.Parameters.AddWithValue("@alicitelefon", tbTelefon.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciMail", tbMail.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciEmlakTuru", cbEmlakTuru.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciIlanBasligi", cbIlanBasligi.Text.ToString());
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                    MessageBox.Show("Alıcı kaydedildi");
                    aliciGetir();
                    dgAlicilar_FormatAlicilar();
                    kontrolTemizle();
                }
                else
                {
                    MessageBox.Show("Aynı ilana ait alıcı zaten var");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz!");
            }
                }
        DataSet ds = new DataSet();
        SqlDataAdapter da1,da2,da3;
        private void ilanBasligiGetir()
        {
           
            ds.Clear();
            ds.Tables.Clear();
            if (cbEmlakTuru.SelectedIndex != -1) { 

            if (cbEmlakTuru.Text.ToString() == "Konut") { 
           
            da1 = new SqlDataAdapter("Select ilanBasligi from konutBilgi ",con.con);
                   
                    da1.Fill(ds,"konutBilgi");
                    cbIlanBasligi.DataSource = ds.Tables["konutBilgi"];
                    cbIlanBasligi.DisplayMember = "ilanBasligi";
                    con.con.Close();
                }
            if (cbEmlakTuru.Text.ToString() == "Arsa")
            {
                da2 = new SqlDataAdapter("Select arsaIlanBasligi from arsaBilgi ", con.con);
                  
                    da2.Fill(ds, "arsaBilgi");
                    cbIlanBasligi.DataSource = ds.Tables["arsaBilgi"];
                    cbIlanBasligi.DisplayMember = "arsaIlanBasligi";
                    con.con.Close();
                    
                }
            if (cbEmlakTuru.Text.ToString() == "İşyeri")
            {
                da3 = new SqlDataAdapter("Select isIlanbasligi from isYeriBilgi ", con.con);
                
                    da3.Fill(ds, "isIlanbasligi");
                    cbIlanBasligi.DataSource = ds.Tables["isIlanbasligi"];
                    cbIlanBasligi.DisplayMember = "isIlanbasligi";
                    con.con.Close();
                }
               
            }
        }

        private void cbEmlakTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilanBasligiGetir();
        }

        private void dgAlicilar_CurrentCellChanged(object sender, EventArgs e)
        {

        }
        private bool ayniAliciKaydiVarmi(string aliciAd,string aliciSoyad,string alicitelefon,string aliciMail,string aliciEmlakTuru,string aliciIlanBasligi)
        {
            bool sonuc = false;
            if (con.con.State != ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("Select count(id) from Alicilar where aliciAd='" + aliciAd + "' and aliciSoyad='" + aliciSoyad + "' and alicitelefon='" + alicitelefon + "' and aliciMail='" + aliciMail + "' and aliciEmlakTuru='" + aliciEmlakTuru + "' and aliciIlanBasligi='" + aliciIlanBasligi + "'", con.con);
                con.con.Open();
                sonuc = Convert.ToInt32(cmd.ExecuteScalar()) > 0 ? false : true;
                con.con.Close();

            }
            return sonuc;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (tbAd.Text.ToString() != "" && tbSoyad.Text.ToString() != "" && tbMail.Text.ToString() != "" && tbTelefon.Text.ToString() != "" && cbEmlakTuru.Text.ToString() != "" && cbIlanBasligi.Text.ToString() != "")
            {
                if (ayniAliciKaydiVarmi(tbAd.Text.ToString(), tbSoyad.Text.ToString(),tbTelefon.Text.ToString(),tbMail.Text.ToString(),cbEmlakTuru.Text.ToString(), cbIlanBasligi.Text.ToString()))
                {

                    DialogResult cevap;
                    cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)

                        con.con.Open();
                    SqlCommand cmd = new SqlCommand("Update Alicilar Set aliciAd=@aliciAd,aliciSoyad=@aliciSoyad,alicitelefon=@aliciTelefon,aliciMail=@aliciMail,aliciEmlakTuru=@aliciEmlakTuru,aliciIlanBasligi=@aliciIlanBasligi where id='" + secilenSatirId + "' ", con.con);
                    cmd.Parameters.AddWithValue("@aliciAd", tbAd.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciSoyad", tbSoyad.Text.ToString());
                    cmd.Parameters.AddWithValue("@alicitelefon", tbTelefon.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciMail", tbMail.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciEmlakTuru", cbEmlakTuru.Text.ToString());
                    cmd.Parameters.AddWithValue("@aliciIlanBasligi", cbIlanBasligi.Text.ToString());
                    cmd.ExecuteNonQuery();
                    con.con.Close();

                    MessageBox.Show("Kayıt güncellendi!");
                    aliciGetir();
                    kontrolTemizle();



                }
                else { MessageBox.Show("Bu kayıt zaten var!.."); }
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz!");
            }

        }

        private void dgAlicilar_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgAlicilar.Rows.Count; i++)
            {
                DataGridViewRow sayi = dgAlicilar.Rows[i];
                if (i % 2 == 0)
                {
                    dgAlicilar.Rows[i].DefaultCellStyle.BackColor = Color.Coral;  
                   
                }
                else
                {
                    dgAlicilar.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
               
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    con.con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Alicilar where id='"+dgAlicilar.CurrentRow.Cells[0].Value.ToString()+"'",con.con);
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                    aliciGetir();
                    kontrolTemizle();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        int secilenSatirId;
        private void dgAlicilar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgAlicilar.Rows[e.RowIndex].Cells[0].Value!= null) { 
            secilenSatirId = Convert.ToInt16(dt.Rows[e.RowIndex]["id"]);
            tbAd.Text = dt.Rows[e.RowIndex]["aliciAd"].ToString();
            tbSoyad.Text = dt.Rows[e.RowIndex]["aliciSoyad"].ToString();
            tbTelefon.Text = dt.Rows[e.RowIndex]["alicitelefon"].ToString();
            tbMail.Text = dt.Rows[e.RowIndex]["aliciMail"].ToString();
            cbEmlakTuru.Text = dt.Rows[e.RowIndex]["aliciEmlakTuru"].ToString();
            cbIlanBasligi.Text = dt.Rows[e.RowIndex]["aliciIlanBasligi"].ToString();
            
            }
        }
        private void kontrolTemizle()
        {
            tbAd.Clear();
            tbMail.Clear();
            tbSoyad.Clear();
            tbTelefon.Clear();
            cbEmlakTuru.Text ="";
            cbIlanBasligi.Text = "";
        }
        private bool aliciVarmi(string aliciAd,string aliciSoyad,string ilanBasligi)
        { 
            bool sonuc = false;
            if (con.con.State != ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("Select count(id) from Alicilar where aliciAd='" + aliciAd + "' and aliciSoyad='"+aliciSoyad+ "' and aliciIlanBasligi='" + ilanBasligi + "'", con.con);
                con.con.Open();
                sonuc = Convert.ToInt32(cmd.ExecuteScalar()) > 0 ? false :true;
                con.con.Close();

            }
            return sonuc;
        }

    }
    }

