using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakTakipProgramim
{
    public partial class arsaForm : Form
    {
        public arsaForm()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();

        DataTable dt;
        SqlDataAdapter da;

        private void satilikArsa_Load(object sender, EventArgs e)
        {
            kontrolTemizle();
            this.tabControl1.TabPages.Remove(tabPage2);
            da = new SqlDataAdapter("Select * from iller", con.con);
            dt = new DataTable();
            da.Fill(dt);
            cbIl.ValueMember = "id";
            cbIl.DisplayMember = "sehir";
            cbIl.DataSource = dt;
            con.con.Close();

        }
        SqlDataAdapter da1;
        DataTable dt1;
        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbIl.SelectedIndex != -1)
                {
                    con.con.Open();
                    da1 = new SqlDataAdapter("Select *from ilceler where sehir=" + cbIl.SelectedValue.ToString(), con.con);
                    dt1 = new DataTable();
                    da1.Fill(dt1);
                    cbIlce.ValueMember = "id";
                    cbIlce.DisplayMember = "ilce";
                    cbIlce.DataSource = dt1;
                    con.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.con.Close();
            }

        }


        int saticiid;
        bool girildimi;
        private void btnArsaEkle_Click(object sender, EventArgs e)
        {



            if (!ilanVarmi(tbIlanBasligi.Text.ToString()))
            {
                foreach (Control item in tabControl1.TabPages[0].Controls)
                {
                    if (item.Text == "")
                    {
                        girildimi = false;
                        break;
                    }
                    else
                    {
                        girildimi = true;
                    }

                }
                if (girildimi)
                {
                    con.con.Open();

                    SqlCommand cmd1 = new SqlCommand("select id from saticilar where saticiAdiSoyadi = '" + saticiismi + "'", con.con);
                    saticiid = Convert.ToInt32(cmd1.ExecuteScalar());
                    SqlCommand cmd = new SqlCommand("INSERT INTO arsaBilgi(arsaIlanBasligi,arsaFiyat,arsaMetrekare,arsaIl,arsaIlce,arsaIlanTarihi,arsaIlanSahibi,arsaAdres,arsaAidat,arsaSatisTipi,arsaAciklama,saticiId)" +
                    "Values(@arsaIlanBasligi,@arsaFiyat,@arsaMetrekare,@arsaIl,@arsaIlce,@arsaIlanTarihi,@arsaIlanSahibi,@arsaAdres,@arsaAidat,@arsaSatisTipi,@arsaAciklama,@saticiId);", con.con);


                    //konut özelliklerini ekler.
                    cmd.Parameters.AddWithValue("@arsaIlanBasligi", tbIlanBasligi.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaFiyat", tbFiyat.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaMetrekare", tbMetrekare.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaIl", cbIl.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaIlce", cbIlce.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaIlanTarihi", dtpEklenmeTarihi.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaIlanSahibi", cbArsaSahibi.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaAdres", tbAdres.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaAidat", dtpEklenmeTarihi.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaSatisTipi", cbArsaSatisTipi.Text.ToString());
                    cmd.Parameters.AddWithValue("@arsaAciklama", tbAciklama.Text.ToString());
                    cmd.Parameters.AddWithValue("@saticiId", saticiid);


                    
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                    MessageBox.Show("Tüm bilgiler veritabanına eklendi");
                    this.tabControl1.TabPages.Add(tabPage2);
                    
                    }
                else
                {
                    MessageBox.Show("Lütfen tüm bilgileri giriniz..");
                }
            }
            else
            {
                MessageBox.Show("İlan varitabanında bulunmaktadır");
            }
        }
        private bool ilanVarmi(string ilanBasligi)
        {

            bool sonuc = false;
            if (con.con.State != ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("Select count(arsaId) from arsaBilgi where arsaIlanBasligi='" + ilanBasligi + "'", con.con);
                con.con.Open();
                sonuc = Convert.ToInt32(cmd.ExecuteScalar()) > 0 ? true : false;
                con.con.Close();

            }
            return sonuc;
        }
        private void btnSaticiEkle_Click(object sender, EventArgs e)
        {
            saticiEkle saticiEkle = new saticiEkle();
            saticiEkle.Show();
        }
        DataTable dt2;
        SqlDataAdapter da2;
        private void cbArsaSahibi_Click(object sender, EventArgs e)
        {

            da2 = new SqlDataAdapter("Select *from saticilar", con.con);
            dt2 = new DataTable();
            da2.Fill(dt2);
            cbArsaSahibi.DisplayMember = "saticiAdiSoyadi";
            cbArsaSahibi.ValueMember = "id";
            cbArsaSahibi.DataSource = dt2;
            con.con.Close();
        }
        string saticiismi;
        private void cbArsaSahibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            saticiismi = cbArsaSahibi.Text.ToString();
        }

        List<PictureBox> pb = new List<PictureBox>();
        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in tabControl1.TabPages[1].Controls)
            {
                if (item is PictureBox)
                    pb.Add(item as PictureBox);
            }
            ofd.ShowDialog();
        }
        List<string> dosyaAdi = new List<string>();
        List<string> resimYol = new List<string>();
        private void ofd_FileOk(object sender, CancelEventArgs e)
        {

            try
            {

                if (ofd.FileNames.Length == 6)
                {

                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb[i + 1].Image = Image.FromFile(ofd.FileNames[i]);
                        pb[i + 1].Tag = ofd.FileNames[i];
                        dosyaAdi.Add(ofd.SafeFileNames[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Resimleri eklemek için 6 resim seçmelisiniz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = ((PictureBox)sender).Image;
            pictureBox11.Tag = ((PictureBox)sender).Tag;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (girildimi)
            {

                if (pictureBox1.Image != null)
                {
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb[i + 1].Image.Save(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i], System.Drawing.Imaging.ImageFormat.Jpeg);
                        resimYol.Add(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i]);

                    }
                    con.con.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO arsaResimler(resim1,resim2,resim3,resim4,resim5,resim6,ilanId) Values(@1,@2,@3,@4,@5,@6,(Select max(arsaId) from arsaBilgi))", con.con);
                    //Resim urllerini ekler.
                    cmd2.Parameters.AddWithValue("@1", resimYol[0].ToString());
                    cmd2.Parameters.AddWithValue("@2", resimYol[1].ToString());
                    cmd2.Parameters.AddWithValue("@3", resimYol[2].ToString());
                    cmd2.Parameters.AddWithValue("@4", resimYol[3].ToString());
                    cmd2.Parameters.AddWithValue("@5", resimYol[4].ToString());
                    cmd2.Parameters.AddWithValue("@6", resimYol[5].ToString());
                    cmd2.ExecuteNonQuery();
                    con.con.Close();
                    MessageBox.Show("Resimler başarıyla kaydedildi");
                    kontrolTemizle();
                    this.tabControl1.TabPages.Remove(tabPage2);
                    
                   
                }
                else
                {
                    MessageBox.Show("Lütfen önce konut bilgilerini giriniz...");
                    return;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in tabControl1.TabPages[0].Controls)
            {
                if (item.Text == "")
                {
                    girildimi = false;
                    break;
                }
                girildimi = true;
            }
        }
        private void kontrolTemizle()
        {
            foreach (Control item in tabControl1.TabPages[1].Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox resimKutu = (PictureBox)item;
                    resimKutu.Image = null;
                }

            }
            tbAciklama.Clear();
            tbAdres.Clear();
            tbAidatTutari.Clear();
            tbFiyat.Clear();
            tbIlanBasligi.Clear();
            tbMetrekare.Clear();
            cbArsaSahibi.SelectedIndex = -1;
            cbArsaSatisTipi.SelectedIndex = -1;
            cbIl.SelectedIndex = -1;
            cbIlce.SelectedIndex = -1;
        }
    }
}