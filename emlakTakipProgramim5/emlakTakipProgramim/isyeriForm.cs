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
    public partial class isyeriForm : Form
    {
        public isyeriForm()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();

        DataTable dt;
        SqlDataAdapter da;

        private void isyeri_Load(object sender, System.EventArgs e)
        {
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

        private void cbIl_SelectedIndexChanged(object sender, System.EventArgs e)
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
        private void btnİsEkle_Click(object sender, System.EventArgs e)
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
                    girildimi = true;
                }
                if (girildimi)
                {
                    con.con.Open();
                    SqlCommand cmd1 = new SqlCommand("select id from saticilar where saticiAdiSoyadi = '" + saticiismi + "'", con.con);
                    saticiid = Convert.ToInt32(cmd1.ExecuteScalar());

                    SqlCommand cmd = new SqlCommand("INSERT INTO isYeriBilgi(isIlanbasligi,isFiyat,isEsya,isTur,isMetreKare,isOda,isIl,isIlce,isIlanTarihi,isSahibi,isAidat,isYasi,isKat,isSatisTipi,isIsinma,isAdres,isAciklama,saticiId)" +
                    "Values(@ilanbasligi,@fiyat,@esyalimi,@isTur,@metreKare,@odaSayisi,@il,@ilce,@eklenmeTarihi,@isSahibi,@aidatTutari,@isYasi,@bulunduguKat,@isSatisTipi,@isitma,@adres,@aciklama,@saticiId);", con.con);

                    //İş Yeri özelliklerini ekler.
                    cmd.Parameters.AddWithValue("@ilanbasligi", tbIlanBasligi.Text.ToString());
                    cmd.Parameters.AddWithValue("@fiyat", tbFiyat.Text.ToString());
                    cmd.Parameters.AddWithValue("@esyalimi", cbEsyalimi.Text.ToString());
                    cmd.Parameters.AddWithValue("@isTur", cbİsTipi.Text.ToString());
                    cmd.Parameters.AddWithValue("@metreKare", tbMetrekare.Text.ToString());
                    cmd.Parameters.AddWithValue("@odaSayisi", cbOdaSayisi.Text.ToString());
                    cmd.Parameters.AddWithValue("@il", cbIl.Text.ToString());
                    cmd.Parameters.AddWithValue("@ilce", cbIlce.Text.ToString());
                    cmd.Parameters.AddWithValue("@eklenmeTarihi", dtpEklenmeTarihi.Text.ToString());
                    cmd.Parameters.AddWithValue("@isSahibi", cbisyeriSahibi.Text.ToString());
                    cmd.Parameters.AddWithValue("@aidatTutari", tbAidatTutari.Text.ToString());
                    cmd.Parameters.AddWithValue("@isYasi", cbİsYasi.Text.ToString());
                    cmd.Parameters.AddWithValue("@bulunduguKat", cbBulunduguKat.Text.ToString());
                    cmd.Parameters.AddWithValue("@isSatisTipi", cbİsSatisTipi.Text.ToString());
                    cmd.Parameters.AddWithValue("@isitma", cbIsitma.Text.ToString());
                    cmd.Parameters.AddWithValue("@adres", tbAdres.Text.ToString());
                    cmd.Parameters.AddWithValue("@aciklama", tbAciklama.Text.ToString());
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
                SqlCommand cmd = new SqlCommand("Select count(t_isyeriId) from isYeriBilgi where isIlanBasligi='" + ilanBasligi + "'", con.con);
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
        string saticiismi;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            saticiismi = cbisyeriSahibi.Text.ToString();
        }
        SqlDataAdapter da2;
        DataTable dt2;
        private void comboBox1_Click(object sender, EventArgs e)
        {
            da2 = new SqlDataAdapter("Select *from saticilar", con.con);
            dt2 = new DataTable();
            da2.Fill(dt2);
            cbisyeriSahibi.DisplayMember = "saticiAdiSoyadi";
            cbisyeriSahibi.ValueMember = "id";
            cbisyeriSahibi.DataSource = dt2;
            con.con.Close();
        }
        List<PictureBox> pb = new List<PictureBox>();
        private void btnFotografEkle_Click(object sender, System.EventArgs e)
        {
            foreach (Control item in tabControl1.TabPages[1].Controls)
            {
                if (item is PictureBox)
                    pb.Add(item as PictureBox);
            }
            ofd.ShowDialog();
        }
        List<string> resimYol = new List<string>();
        List<string> dosyaAdi = new List<string>();
        private void ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {

            pictureBox11.Image = ((PictureBox)sender).Image;
            pictureBox11.Tag = ((PictureBox)sender).Tag;
        }
        private void btnVeritabaninaEkle_Click(object sender, EventArgs e)
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
                }


                con.con.Open();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO isResimler(resim1,resim2,resim3,resim4,resim5,resim6,ilanId) Values(@1,@2,@3,@4,@5,@6,(Select max(t_isyeriId) from isYeriBilgi))", con.con);
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
            cbBulunduguKat.SelectedIndex = -1;
            cbEsyalimi.SelectedIndex = -1;
            cbIsitma.SelectedIndex = -1;
            cbIl.SelectedIndex = -1;
            cbIlce.SelectedIndex = -1;
            cbisyeriSahibi.SelectedIndex = -1;
            cbOdaSayisi.SelectedIndex = -1;
            cbİsSatisTipi.SelectedIndex = -1;
            cbİsTipi.SelectedIndex = -1;
            cbİsYasi.SelectedIndex = -1;
        }
    }
}

