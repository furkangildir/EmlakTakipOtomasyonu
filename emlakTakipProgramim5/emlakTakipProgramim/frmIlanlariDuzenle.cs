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
    public partial class frmIlanlariDuzenle : Form
    {
        public frmIlanlariDuzenle()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        public static string ilanTuru;
        private void cbIlanTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbIlanTuru.Text == "Konut İlanları")
            {

                emlakIdFotograf = 0;
                ilanTuru = cbIlanTuru.Text.ToString();
                kontrolaktifleştir();
                konutIlanlariniGetir();
                kontrolTemizle();
                cbEmlakKonutTuruDoldur();
                dgIlanlariDuzemle_FormatKonutBilgi();
                dgIlanlariDuzenle.ClearSelection();

            }
            if (cbIlanTuru.Text == "İşyeri İlanları")
            {

                emlakIdFotograf = 0;
                ilanTuru = cbIlanTuru.Text.ToString();
                kontrolaktifleştir();
                isyeriIlanlariniGetir();
                kontrolTemizle();
                cbEmlakİsyeriTuruDoldur();
                dgIlanlariDuzemle_FormatIsyeriBilgi();
                dgIlanlariDuzenle.ClearSelection();

            }
            if (cbIlanTuru.Text == "Arsa İlanları")
            {
                foreach (DataGridViewColumn item in dgIlanlariDuzenle.Columns)
                {
                    item.ReadOnly = true;
                }
                emlakIdFotograf = 0;
                ilanTuru = cbIlanTuru.Text.ToString();
                kontrolpasifleştir();
                arsaIlanlariniGetir();
                kontrolTemizle();
                dgIlanlariDuzemle_FormatArsaBilgi();
                dgIlanlariDuzenle.ClearSelection();

            }
            foreach (DataGridViewTextBoxColumn item in dgIlanlariDuzenle.Columns)
            {
                item.ReadOnly = true;
            }

        }
        private void cbEmlakKonutTuruDoldur()
        {
            cbEmlakYapiTuru.Items.Clear();
            cbEmlakYapiTuru.Items.Add("Ahşap Ev");
            cbEmlakYapiTuru.Items.Add("Apartman");
            cbEmlakYapiTuru.Items.Add("Apartman Dairesi");
            cbEmlakYapiTuru.Items.Add("Çiftlik Evi");
            cbEmlakYapiTuru.Items.Add("Dağ Evi");
            cbEmlakYapiTuru.Items.Add("Daire (Bahçe Dublex)");
            cbEmlakYapiTuru.Items.Add("Daire(Çatı Dublex)");
            cbEmlakYapiTuru.Items.Add("Dublex");
            cbEmlakYapiTuru.Items.Add("Fourlex");
            cbEmlakYapiTuru.Items.Add("İkiz Ev");
            cbEmlakYapiTuru.Items.Add("Köşk");
            cbEmlakYapiTuru.Items.Add("Köy Evi");
            cbEmlakYapiTuru.Items.Add("Malikane");
            cbEmlakYapiTuru.Items.Add("Müstakil Ev");
            cbEmlakYapiTuru.Items.Add("Residence");
            cbEmlakYapiTuru.Items.Add("Stüdyo");
            cbEmlakYapiTuru.Items.Add("Townhouse");
            cbEmlakYapiTuru.Items.Add("Triplex");
            cbEmlakYapiTuru.Items.Add("Villa");
            cbEmlakYapiTuru.Items.Add("Yalı");
            cbEmlakYapiTuru.Items.Add("Taş Ev");
            cbEmlakYapiTuru.Items.Add("Apart");

        }
        private void cbEmlakİsyeriTuruDoldur()
        {
            cbEmlakYapiTuru.Items.Clear();
            cbEmlakYapiTuru.Items.Add("Akaryakıt İstasyonu");
            cbEmlakYapiTuru.Items.Add("Apartman Dairesi");
            cbEmlakYapiTuru.Items.Add("Atölye");
            cbEmlakYapiTuru.Items.Add("AVM");
            cbEmlakYapiTuru.Items.Add("Büfe");
            cbEmlakYapiTuru.Items.Add("Büro & Ofis");
            cbEmlakYapiTuru.Items.Add("Çiftlik");
            cbEmlakYapiTuru.Items.Add("Depo & Antrepo");
            cbEmlakYapiTuru.Items.Add("Düğün Salonu");
            cbEmlakYapiTuru.Items.Add("Dükkan & Mağaza");
            cbEmlakYapiTuru.Items.Add("Fabrika");
            cbEmlakYapiTuru.Items.Add("İmalathane");
            cbEmlakYapiTuru.Items.Add("İş Hanı Katı & Ofisi");
            cbEmlakYapiTuru.Items.Add("Komple Bina");
            cbEmlakYapiTuru.Items.Add("Otopark");
            cbEmlakYapiTuru.Items.Add("Pazar Yeri");
            cbEmlakYapiTuru.Items.Add("Plaza Katı");
        }
        private void konutIlanlariniGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from konutBilgi", con.con);
            dt1.Columns.Clear();
            dt1.Clear();
            dt2.Columns.Clear();
            dt2.Clear();
            dt3.Columns.Clear();
            dt3.Clear();
            da.Fill(dt3);
            dgIlanlariDuzenle.DataSource = dt3;
            con.con.Close();

        }
        private void isyeriIlanlariniGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from isYeriBilgi", con.con);
            dt3.Columns.Clear();
            dt3.Clear();
            dt1.Columns.Clear();
            dt1.Clear();
            dt2.Columns.Clear();
            dt2.Clear();
            da.Fill(dt2);
            dgIlanlariDuzenle.DataSource = dt2;
            con.con.Close();
        }
        private void arsaIlanlariniGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select *from arsaBilgi", con.con);
            dt2.Columns.Clear();
            dt2.Clear();
            dt3.Columns.Clear();
            dt3.Clear();
            dt1.Columns.Clear();
            dt1.Clear();
            da.Fill(dt1);
            dgIlanlariDuzenle.DataSource = dt1;
            con.con.Close();
        }

        private int emlakSahibiIdGetir()
        {
            con.con.Open();
            int saticiId = 0;
            SqlCommand cmd = new SqlCommand("Select id from saticilar where saticiAdiSoyadi='" + cbKonutSahibi.Text.ToString() + "'", con.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    saticiId = Convert.ToInt32(dr["id"]);
                }

            }
            con.con.Close();
            return saticiId;
        }
        private bool ilanVarmi(string commandString)
        {

            bool sonuc = false;
            if (con.con.State != ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(commandString, con.con);
                con.con.Open();
                sonuc = Convert.ToInt32(cmd.ExecuteScalar()) > 1 ? true : false;
                con.con.Close();

            }
            return sonuc;
        }
        public void dgIlanlariDuzemle_FormatKonutBilgi()
        {
            dgIlanlariDuzenle.Columns["konutId"].HeaderText = "İd";
            dgIlanlariDuzenle.Columns["ilanBasligi"].HeaderText = "İlan Başlığı";
            dgIlanlariDuzenle.Columns["fiyat"].HeaderText = "Fiyat";
            dgIlanlariDuzenle.Columns["esyalimi"].HeaderText = "Eşyalı mı?";
            dgIlanlariDuzenle.Columns["konutTipi"].HeaderText = "Konut Tipi";
            dgIlanlariDuzenle.Columns["metreKare"].HeaderText = "Metrekare";
            dgIlanlariDuzenle.Columns["odaSayisi"].HeaderText = "Oda Sayısı";
            dgIlanlariDuzenle.Columns["il"].HeaderText = "İl";
            dgIlanlariDuzenle.Columns["ilce"].HeaderText = "İlçe";
            dgIlanlariDuzenle.Columns["eklenmeTarihi"].HeaderText = "Eklenme Tarihi";
            dgIlanlariDuzenle.Columns["konutSahibi"].HeaderText = "Konut Sahibi";
            dgIlanlariDuzenle.Columns["aidatTutari"].HeaderText = "Aidat Tutarı";
            dgIlanlariDuzenle.Columns["konutYasi"].HeaderText = "Konut Yaşı";
            dgIlanlariDuzenle.Columns["bulunduguKat"].HeaderText = "Bulunduğu Kat";
            dgIlanlariDuzenle.Columns["konutSatisTipi"].HeaderText = "Konut Satış Tipi";
            dgIlanlariDuzenle.Columns["isitma"].HeaderText = "Isıtma";
            dgIlanlariDuzenle.Columns["adres"].HeaderText = "Adres";
            dgIlanlariDuzenle.Columns["aciklama"].HeaderText = "Açıklama";
            dgIlanlariDuzenle.Columns["saticiId"].HeaderText = "Satıcı Id";
            dgIlanlariDuzenle.Columns["fotografButon"].Width = 0;
            dgIlanlariDuzenle.DefaultCellStyle.BackColor = Color.GhostWhite;
            dgIlanlariDuzenle.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgIlanlariDuzenle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgIlanlariDuzenle.Font = new Font("Tahoma", 8.0F, FontStyle.Regular);
        }
        public void dgIlanlariDuzemle_FormatIsyeriBilgi()
        {
            dgIlanlariDuzenle.Columns["t_isyeriId"].HeaderText = "İd";
            dgIlanlariDuzenle.Columns["isIlanbasligi"].HeaderText = "İlan Başlığı";
            dgIlanlariDuzenle.Columns["isFiyat"].HeaderText = "Fiyat";
            dgIlanlariDuzenle.Columns["isEsya"].HeaderText = "Eşyalı mı?";
            dgIlanlariDuzenle.Columns["isTur"].HeaderText = "İşyeri Tipi";
            dgIlanlariDuzenle.Columns["isMetreKare"].HeaderText = "Metrekare";
            dgIlanlariDuzenle.Columns["isOda"].HeaderText = "Oda Sayısı";
            dgIlanlariDuzenle.Columns["isIl"].HeaderText = "İl";
            dgIlanlariDuzenle.Columns["isIlce"].HeaderText = "İlçe";
            dgIlanlariDuzenle.Columns["isIlanTarihi"].HeaderText = "Ekleneme Tarihi";
            dgIlanlariDuzenle.Columns["isSahibi"].HeaderText = "İşyeri Sahibi";
            dgIlanlariDuzenle.Columns["isAidat"].HeaderText = "Aidat Tutarı";
            dgIlanlariDuzenle.Columns["isYasi"].HeaderText = "İşyeri Yaşı";
            dgIlanlariDuzenle.Columns["isKat"].HeaderText = "Bulunduğu Kat";
            dgIlanlariDuzenle.Columns["isSatisTipi"].HeaderText = "İşyeri Satış Tipi";
            dgIlanlariDuzenle.Columns["isIsinma"].HeaderText = "Isıtma";
            dgIlanlariDuzenle.Columns["isAdres"].HeaderText = "Adres";
            dgIlanlariDuzenle.Columns["isAciklama"].HeaderText = "Açıklama";
            dgIlanlariDuzenle.Columns["saticiId"].HeaderText = "Satıcı Id";

            dgIlanlariDuzenle.Columns["fotografButon"].Width = 0;
            dgIlanlariDuzenle.DefaultCellStyle.BackColor = Color.GhostWhite;
            dgIlanlariDuzenle.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgIlanlariDuzenle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgIlanlariDuzenle.Font = new Font("Tahoma", 8.0F, FontStyle.Regular);
        }
        public void dgIlanlariDuzemle_FormatArsaBilgi()
        {
            dgIlanlariDuzenle.Columns["arsaId"].HeaderText = "İd";
            dgIlanlariDuzenle.Columns["arsaIlanBasligi"].HeaderText = "İlan Başlığı";
            dgIlanlariDuzenle.Columns["arsaFiyat"].HeaderText = "Fiyat";
            dgIlanlariDuzenle.Columns["arsaMetreKare"].HeaderText = "Metrekare";
            dgIlanlariDuzenle.Columns["arsaIl"].HeaderText = "İl";
            dgIlanlariDuzenle.Columns["arsaIlce"].HeaderText = "İlçe";
            dgIlanlariDuzenle.Columns["arsaIlanTarihi"].HeaderText = "Eklenme Tarihi";
            dgIlanlariDuzenle.Columns["arsaIlanSahibi"].HeaderText = "Arsa Sahibi";
            dgIlanlariDuzenle.Columns["arsaAidat"].HeaderText = "Aidat Tutarı";
            dgIlanlariDuzenle.Columns["arsaSatisTipi"].HeaderText = "Arsa Satış Tipi";
            dgIlanlariDuzenle.Columns["arsaAdres"].HeaderText = "Adres";
            dgIlanlariDuzenle.Columns["arsaAciklama"].HeaderText = "Açıklama";
            dgIlanlariDuzenle.Columns["saticiId"].HeaderText = "Satıcı Id";

            dgIlanlariDuzenle.Columns["fotografButon"].Width = 0;
            dgIlanlariDuzenle.DefaultCellStyle.BackColor = Color.GhostWhite;
            dgIlanlariDuzenle.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgIlanlariDuzenle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgIlanlariDuzenle.Font = new Font("Tahoma", 8.0F, FontStyle.Regular);
        }
        private void dgIlanlariDuzenle_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgIlanlariDuzenle.Rows.Count; i++)
            {
                DataGridViewRow sayi = dgIlanlariDuzenle.Rows[i];
                if (i % 2 == 0)
                {
                    dgIlanlariDuzenle.Rows[i].DefaultCellStyle.BackColor = Color.Coral;

                }
                else
                {
                    dgIlanlariDuzenle.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

            }

        }
        int ilanId;


        private void frmIlanlariDuzenle_Load(object sender, EventArgs e)
        {
            foreach (DataGridTextBoxColumn item in dgIlanlariDuzenle.Columns)
            {
                item.ReadOnly = true;
            }
            SqlDataAdapter da = new SqlDataAdapter("Select * from iller", con.con);
            DataTable dt4 = new DataTable();
            da.Fill(dt4);
            cbIl.ValueMember = "id";
            cbIl.DisplayMember = "sehir";
            cbIl.DataSource = dt4;
            saticilariGetir();
            kontrolTemizle();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbIl.SelectedIndex != -1)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select *from ilceler where sehir=" + cbIl.SelectedValue.ToString(), con.con);
                    DataTable dt5 = new DataTable();
                    da.Fill(dt5);
                    cbIlce.ValueMember = "id";
                    cbIlce.DisplayMember = "ilce";
                    cbIlce.DataSource = dt5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saticilariGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select *from saticilar", con.con);
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6.Columns.Clear();
            da.Fill(dt6);
            cbKonutSahibi.DisplayMember = "saticiAdiSoyadi";
            cbKonutSahibi.ValueMember = "id";
            cbKonutSahibi.DataSource = dt6;
        }
        private void btnSaticiEkle_Click(object sender, EventArgs e)
        {
            saticiEkle saticiekle = new saticiEkle();
            saticiekle.Show();
        }

        private void cbKonutSahibi_Click(object sender, EventArgs e)
        {
            saticilariGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cbIlanTuru.Text == "Konut İlanları")
            {
                if (tbIlanBasligi.Text.ToString() != "" && tbFiyat.Text.ToString() != "" && tbMetrekare.Text.ToString() != "" && tbAidatTutari.Text.ToString() != "" && dtpEklenmeTarihi.Text.ToString() != "" && tbAdres.Text.ToString() != "" && tbAciklama.Text.ToString() != "")
                {
                    if (!ilanVarmi("Select count(konutId) from konutBilgi where ilanBasligi = '" + tbIlanBasligi.Text.ToString() + "'"))
                    {
                        DialogResult cevap;
                        cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap == DialogResult.Yes)
                        {
                            int saticiId = emlakSahibiIdGetir();
                            if (con.con.State != ConnectionState.Open)
                            {
                                con.con.Open();
                            }
                            SqlCommand cmd = new SqlCommand("Update konutBilgi set ilanbasligi=@ilanbasligi,fiyat=@fiyat,esyalimi=@esyalimi,konutTipi=@konutTipi,metreKare=@metreKare,odaSayisi=@odaSayisi,il=@il,ilce=@ilce,eklenmeTarihi=@eklenmeTarihi,konutSahibi=@konutSahibi,aidatTutari=@aidatTutari,konutYasi=@konutYasi,bulunduguKat=@bulunduguKat,konutSatisTipi=@konutSatisTipi,isitma=@isitma,adres=@adres,aciklama=@aciklama,saticiId=@saticiId where konutId='" + ilanId + "'", con.con);
                            cmd.Parameters.AddWithValue("@ilanbasligi", tbIlanBasligi.Text.ToString());
                            cmd.Parameters.AddWithValue("@fiyat", tbFiyat.Text.ToString());
                            cmd.Parameters.AddWithValue("@esyalimi", cbEsyalimi.Text.ToString());
                            cmd.Parameters.AddWithValue("@konutTipi", cbEmlakYapiTuru.Text.ToString());
                            cmd.Parameters.AddWithValue("@metreKare", tbMetrekare.Text.ToString());
                            cmd.Parameters.AddWithValue("@odaSayisi", cbOdaSayisi.Text.ToString());
                            cmd.Parameters.AddWithValue("@il", cbIl.Text.ToString());
                            cmd.Parameters.AddWithValue("@ilce", cbIlce.Text.ToString());
                            cmd.Parameters.AddWithValue("@eklenmeTarihi", dtpEklenmeTarihi.Text.ToString());
                            cmd.Parameters.AddWithValue("@konutSahibi", cbKonutSahibi.Text.ToString());
                            cmd.Parameters.AddWithValue("@aidatTutari", tbAidatTutari.Text.ToString());
                            cmd.Parameters.AddWithValue("@konutYasi", cbKonutYasi.Text.ToString());
                            cmd.Parameters.AddWithValue("@bulunduguKat", cbBulunduguKat.Text.ToString());
                            cmd.Parameters.AddWithValue("@konutSatisTipi", cbkonutSatisTipi.Text.ToString());
                            cmd.Parameters.AddWithValue("@isitma", cbIsitma.Text.ToString());
                            cmd.Parameters.AddWithValue("@adres", tbAdres.Text.ToString());
                            cmd.Parameters.AddWithValue("@aciklama", tbAciklama.Text.ToString());
                            cmd.Parameters.AddWithValue("@saticiId", saticiId.ToString());
                            cmd.ExecuteNonQuery();
                            con.con.Close();
                            konutIlanlariniGetir();
                            dgIlanlariDuzemle_FormatKonutBilgi();
                        }

                    }
                    else
                    {
                        MessageBox.Show("İlan zaten var!Lütfen farklı bir ilan ismi giriniz..");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm bilgileri giriniz!");
                }
            }
            if (cbIlanTuru.Text == "İşyeri İlanları")
            {
                if (tbIlanBasligi.Text.ToString() != "" && tbFiyat.Text.ToString() != "" && tbMetrekare.Text.ToString() != "" && tbAidatTutari.Text.ToString() != "" && dtpEklenmeTarihi.Text.ToString() != "" && tbAdres.Text.ToString() != "" && tbAciklama.Text.ToString() != "")
                {
                    if (!ilanVarmi("Select count(t_isyeriId) from isYeriBilgi where isIlanbasligi = '" + tbIlanBasligi.Text.ToString() + "'"))
                    {

                        DialogResult cevap;
                        cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap == DialogResult.Yes)
                        {
                            int saticiId = emlakSahibiIdGetir();
                            if (con.con.State != ConnectionState.Open)
                            {
                                con.con.Open();
                            }
                            SqlCommand cmd1 = new SqlCommand("Update isYeriBilgi set isIlanbasligi=@ilanbasligi,isFiyat=@fiyat,isEsya=@esyalimi,isTur=@isTur,isMetreKare=@metreKare,isOda=@odaSayisi,isIl=@il,isIlce=@ilce,isIlanTarihi=@eklenmeTarihi,isSahibi=@isSahibi,isAidat=@aidatTutari,isYasi=@isYasi,isKat=@bulunduguKat,isSatisTipi=@isSatisTipi,isIsinma=@isitma,isAdres=@adres,isAciklama=@aciklama,saticiId=@saticiId where t_isyeriId='" + ilanId + "'", con.con);
                            cmd1.Parameters.AddWithValue("@ilanbasligi", tbIlanBasligi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@fiyat", tbFiyat.Text.ToString());
                            cmd1.Parameters.AddWithValue("@esyalimi", cbEsyalimi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@isTur", cbEmlakYapiTuru.Text.ToString());
                            cmd1.Parameters.AddWithValue("@metreKare", tbMetrekare.Text.ToString());
                            cmd1.Parameters.AddWithValue("@odaSayisi", cbOdaSayisi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@il", cbIl.Text.ToString());
                            cmd1.Parameters.AddWithValue("@ilce", cbIlce.Text.ToString());
                            cmd1.Parameters.AddWithValue("@eklenmeTarihi", dtpEklenmeTarihi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@isSahibi", cbKonutSahibi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@aidatTutari", tbAidatTutari.Text.ToString());
                            cmd1.Parameters.AddWithValue("@isYasi", cbKonutYasi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@bulunduguKat", cbBulunduguKat.Text.ToString());
                            cmd1.Parameters.AddWithValue("@isSatisTipi", cbkonutSatisTipi.Text.ToString());
                            cmd1.Parameters.AddWithValue("@isitma", cbIsitma.Text.ToString());
                            cmd1.Parameters.AddWithValue("@adres", tbAdres.Text.ToString());
                            cmd1.Parameters.AddWithValue("@aciklama", tbAciklama.Text.ToString());
                            cmd1.Parameters.AddWithValue("@saticiId", saticiId.ToString());
                            cmd1.ExecuteNonQuery();
                            con.con.Close();
                            isyeriIlanlariniGetir();
                            dgIlanlariDuzemle_FormatIsyeriBilgi();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İlan zaten var!Lütfen farklı bir ilan ismi giriniz..");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm bilgileri giriniz!");
                }
            }
            if (cbIlanTuru.Text == "Arsa İlanları")
            {

                if (tbIlanBasligi.Text.ToString() != "" && tbFiyat.Text.ToString() != "" && tbMetrekare.Text.ToString() != "" && tbAidatTutari.Text.ToString() != "" && dtpEklenmeTarihi.Text.ToString() != "" && tbAdres.Text.ToString() != "" && tbAciklama.Text.ToString() != "")
                {
                    if (!ilanVarmi("Select count(arsaId) from arsaBilgi where arsaIlanBasligi = '" + tbIlanBasligi.Text.ToString() + "'"))
                    {
                        DialogResult cevap;
                        cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap == DialogResult.Yes)
                        {
                            int saticiId = emlakSahibiIdGetir();
                            if (con.con.State != ConnectionState.Open)
                            {
                                con.con.Open();
                            }
                            SqlCommand cmd3 = new SqlCommand("Update arsaBilgi set arsaIlanBasligi=@ilanbasligi,arsaFiyat=@fiyat,arsaMetreKare=@metreKare,arsaIl=@il,arsaIlce=@ilce,arsaIlanTarihi=@eklenmeTarihi,arsaIlanSahibi=@arsaSahibi,arsaAidat=@aidatTutari,arsaSatisTipi=@arsaSatisTipi,arsaAdres=@adres,arsaAciklama=@aciklama,saticiId=@saticiId where arsaId='" + ilanId + "'", con.con);
                            cmd3.Parameters.AddWithValue("@ilanbasligi", tbIlanBasligi.Text.ToString());
                            cmd3.Parameters.AddWithValue("@fiyat", tbFiyat.Text.ToString());
                            cmd3.Parameters.AddWithValue("@metreKare", tbMetrekare.Text.ToString());
                            cmd3.Parameters.AddWithValue("@il", cbIl.Text.ToString());
                            cmd3.Parameters.AddWithValue("@ilce", cbIlce.Text.ToString());
                            cmd3.Parameters.AddWithValue("@eklenmeTarihi", dtpEklenmeTarihi.Text.ToString());
                            cmd3.Parameters.AddWithValue("@arsaSahibi", cbKonutSahibi.Text.ToString());
                            cmd3.Parameters.AddWithValue("@aidatTutari", tbAidatTutari.Text.ToString());
                            cmd3.Parameters.AddWithValue("@arsaSatisTipi", cbkonutSatisTipi.Text.ToString());
                            cmd3.Parameters.AddWithValue("@adres", tbAdres.Text.ToString());
                            cmd3.Parameters.AddWithValue("@aciklama", tbAciklama.Text.ToString());
                            cmd3.Parameters.AddWithValue("@saticiId", saticiId.ToString());
                            cmd3.ExecuteNonQuery();
                            con.con.Close();
                            arsaIlanlariniGetir();
                            dgIlanlariDuzemle_FormatArsaBilgi();
                        }

                    }
                    else
                    {
                        MessageBox.Show("İlan zaten var!Lütfen farklı bir ilan ismi giriniz..");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm bilgileri giriniz!");
                }
            }
        }

        private void kontrolTemizle()
        {
            tbIlanBasligi.Clear();
            tbFiyat.Clear();
            tbMetrekare.Clear();
            dtpEklenmeTarihi.Text = "";
            tbAidatTutari.Clear();
            tbAdres.Clear();
            tbAciklama.Clear();
            cbEmlakYapiTuru.SelectedIndex = -1;
            cbBulunduguKat.SelectedIndex = -1;
            cbEsyalimi.SelectedIndex = -1;
            cbIl.SelectedIndex = -1;
            cbIlce.SelectedIndex = -1;
            cbIsitma.SelectedIndex = -1;
            cbKonutSahibi.SelectedIndex = -1;
            cbkonutSatisTipi.SelectedIndex = -1;
            cbKonutYasi.SelectedIndex = -1;
            cbOdaSayisi.SelectedIndex = -1;
        }
        public static int emlakIdFotograf;
        private void dgIlanlariDuzenle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cbIlanTuru.Text == "Konut İlanları")
            {
  
                    if (dgIlanlariDuzenle.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        emlakIdFotograf = Convert.ToInt32(dgIlanlariDuzenle.Rows[e.RowIndex].Cells[0].Value);

                        cbEmlakKonutTuruDoldur();
                        ilanId = Convert.ToInt16(dt3.Rows[e.RowIndex]["konutId"]);
                        tbIlanBasligi.Text = dt3.Rows[e.RowIndex]["ilanBasligi"].ToString();
                        tbFiyat.Text = dt3.Rows[e.RowIndex]["fiyat"].ToString();
                        cbEsyalimi.Text = dt3.Rows[e.RowIndex]["esyalimi"].ToString();
                        cbEmlakYapiTuru.Text = dt3.Rows[e.RowIndex]["konutTipi"].ToString();
                        tbMetrekare.Text = dt3.Rows[e.RowIndex]["metreKare"].ToString();
                        cbOdaSayisi.Text = dt3.Rows[e.RowIndex]["odaSayisi"].ToString();
                        cbIl.Text = dt3.Rows[e.RowIndex]["il"].ToString();
                        cbIlce.Text = dt3.Rows[e.RowIndex]["ilce"].ToString();
                        dtpEklenmeTarihi.Text = dt3.Rows[e.RowIndex]["eklenmeTarihi"].ToString();
                        cbKonutSahibi.Text = dt3.Rows[e.RowIndex]["konutSahibi"].ToString();
                        tbAidatTutari.Text = dt3.Rows[e.RowIndex]["aidatTutari"].ToString();
                        cbKonutYasi.Text = dt3.Rows[e.RowIndex]["konutYasi"].ToString();
                        cbBulunduguKat.Text = dt3.Rows[e.RowIndex]["bulunduguKat"].ToString();
                        cbkonutSatisTipi.Text = dt3.Rows[e.RowIndex]["konutSatisTipi"].ToString();
                        cbIsitma.Text = dt3.Rows[e.RowIndex]["isitma"].ToString();
                        tbAdres.Text = dt3.Rows[e.RowIndex]["adres"].ToString();
                        tbAciklama.Text = dt3.Rows[e.RowIndex]["aciklama"].ToString();

                  

                }
            }
            if (cbIlanTuru.Text == "İşyeri İlanları")
            {

                
                    if (dgIlanlariDuzenle.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        emlakIdFotograf = Convert.ToInt32(dgIlanlariDuzenle.Rows[e.RowIndex].Cells[0].Value);

                        cbEmlakİsyeriTuruDoldur();
                        ilanId = Convert.ToInt16(dt2.Rows[e.RowIndex]["t_isyeriId"]);
                        tbIlanBasligi.Text = dt2.Rows[e.RowIndex]["isIlanbasligi"].ToString();
                        tbFiyat.Text = dt2.Rows[e.RowIndex]["isFiyat"].ToString();
                        cbEsyalimi.Text = dt2.Rows[e.RowIndex]["isEsya"].ToString();
                        cbEmlakYapiTuru.Text = dt2.Rows[e.RowIndex]["isTur"].ToString();
                        tbMetrekare.Text = dt2.Rows[e.RowIndex]["isMetreKare"].ToString();
                        cbOdaSayisi.Text = dt2.Rows[e.RowIndex]["isOda"].ToString();
                        cbIl.Text = dt2.Rows[e.RowIndex]["isIl"].ToString();
                        cbIlce.Text = dt2.Rows[e.RowIndex]["isIlce"].ToString();
                        dtpEklenmeTarihi.Text = dt2.Rows[e.RowIndex]["isIlanTarihi"].ToString();
                        cbKonutSahibi.Text = dt2.Rows[e.RowIndex]["isSahibi"].ToString();
                        tbAidatTutari.Text = dt2.Rows[e.RowIndex]["isAidat"].ToString();
                        cbKonutYasi.Text = dt2.Rows[e.RowIndex]["isYasi"].ToString();
                        cbBulunduguKat.Text = dt2.Rows[e.RowIndex]["isKat"].ToString();
                        cbkonutSatisTipi.Text = dt2.Rows[e.RowIndex]["isSatisTipi"].ToString();
                        cbIsitma.Text = dt2.Rows[e.RowIndex]["isIsinma"].ToString();
                        tbAdres.Text = dt2.Rows[e.RowIndex]["isAdres"].ToString();
                        tbAciklama.Text = dt2.Rows[e.RowIndex]["isAciklama"].ToString();
                    
                }
            }
            if (cbIlanTuru.Text == "Arsa İlanları")
            {
               
                    if (dgIlanlariDuzenle.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        emlakIdFotograf = Convert.ToInt32(dgIlanlariDuzenle.Rows[e.RowIndex].Cells[0].Value);

                        ilanId = Convert.ToInt16(dt1.Rows[e.RowIndex]["arsaId"]);
                        tbIlanBasligi.Text = dt1.Rows[e.RowIndex]["arsaIlanBasligi"].ToString();
                        tbFiyat.Text = dt1.Rows[e.RowIndex]["arsaFiyat"].ToString();
                        tbMetrekare.Text = dt1.Rows[e.RowIndex]["arsaMetrekare"].ToString();
                        cbIl.Text = dt1.Rows[e.RowIndex]["arsaIl"].ToString();
                        cbIlce.Text = dt1.Rows[e.RowIndex]["arsaIlce"].ToString();
                        dtpEklenmeTarihi.Text = dt1.Rows[e.RowIndex]["arsaIlanTarihi"].ToString();
                        cbKonutSahibi.Text = dt1.Rows[e.RowIndex]["arsaIlanSahibi"].ToString();
                        tbAidatTutari.Text = dt1.Rows[e.RowIndex]["arsaAidat"].ToString();
                        cbkonutSatisTipi.Text = dt1.Rows[e.RowIndex]["arsaSatisTipi"].ToString();
                        tbAdres.Text = dt1.Rows[e.RowIndex]["arsaAdres"].ToString();
                        tbAciklama.Text = dt1.Rows[e.RowIndex]["arsaAciklama"].ToString();
                    }
                
            }
        }
        private void kontrolpasifleştir()
        {
            cbEsyalimi.Enabled = false;
            cbEmlakYapiTuru.Enabled = false;
            cbOdaSayisi.Enabled = false;
            cbKonutYasi.Enabled = false;
            cbBulunduguKat.Enabled = false;
            cbIsitma.Enabled = false;
            label3.Enabled = false;
            label19.Enabled = false;
            label22.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label15.Enabled = false;
        }
        private void kontrolaktifleştir()
        {
            cbEsyalimi.Enabled = true;
            cbEmlakYapiTuru.Enabled = true;
            cbOdaSayisi.Enabled = true;
            cbKonutYasi.Enabled = true;
            cbBulunduguKat.Enabled = true;
            cbIsitma.Enabled = true;
            label3.Enabled = true;
            label19.Enabled = true;
            label22.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label15.Enabled = true;
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
                    if (cbIlanTuru.Text == "Konut İlanları")
                    {
                        SqlCommand cmd = new SqlCommand("Delete from konutBilgi where konutId=@konutId;Delete from konutResimler where ilanId=@ilanId", con.con);
                        cmd.Parameters.AddWithValue("@konutId", emlakIdFotograf);
                        cmd.Parameters.AddWithValue("@ilanId", emlakIdFotograf);
                        cmd.ExecuteNonQuery();
                        konutIlanlariniGetir();
                    }
                    if (cbIlanTuru.Text == "İşyeri İlanları")
                    {
                        SqlCommand cmd = new SqlCommand("Delete from isYeriBilgi where t_isyeriId=@t_isyeriId;Delete from isResimler where ilanId = @ilanId", con.con);
                        cmd.Parameters.AddWithValue("@t_isyeriId", emlakIdFotograf);
                        cmd.Parameters.AddWithValue("@ilanId", emlakIdFotograf);
                        cmd.ExecuteNonQuery();
                        isyeriIlanlariniGetir();
                    }
                    if (cbIlanTuru.Text == "Arsa İlanları")
                    {
                        SqlCommand cmd = new SqlCommand("Delete from arsaBilgi where arsaId=@arsaId;Delete from arsaResimler where ilanId=@ilanId ", con.con);
                        cmd.Parameters.AddWithValue("@arsaId", emlakIdFotograf);
                        cmd.Parameters.AddWithValue("@ilanId", emlakIdFotograf);
                        cmd.ExecuteNonQuery();
                        arsaIlanlariniGetir();
                    }
                    con.con.Close();

                    kontrolTemizle();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnFotografDuzenle_Click(object sender, EventArgs e)
        {
            if (emlakIdFotograf != 0)
            {
                fotografDuzenle fotograflariDuzenle = new fotografDuzenle();
                fotograflariDuzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen listeden kayıt seçiniz");
            }
        }


    }
}

