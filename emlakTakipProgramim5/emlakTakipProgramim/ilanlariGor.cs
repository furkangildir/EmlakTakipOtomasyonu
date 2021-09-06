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
    public partial class ilanlariGor : Form
    {
        public ilanlariGor()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        private DataGridTableStyle tsl = new DataGridTableStyle();
        private DataGridTextBoxColumn myDataCol1 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol2 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol3 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol4 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol5 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol6 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol7 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol8 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol9 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol10 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol11 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol12 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol13 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol14 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol15 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol16 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol17 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol18 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol19 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol20 = new DataGridTextBoxColumn();
        private SqlDataAdapter da;
        int saticiId = saticilariGor.saticiId;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        private void ilanlariGor_Load(object sender, EventArgs e)
        {
            dgIlanlar.Controls.Add(btnFotograflariGor);
        }
        int sutunSayisi;
        private void cbIlanTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbIlanTuru.Text == "Konut İlanları")
            {
                da = new SqlDataAdapter("Select *from konutBilgi where saticiId='" + saticiId + "'", con.con);
                dgIlanlar.TableStyles.Clear();
                tsl.GridColumnStyles.Clear();
                dgIlanlar_FormatKonutBilgi();
                dt1.Columns.Clear();
                dt1.Clear();
                dt2.Columns.Clear();
                dt2.Clear();
                dt3.Columns.Clear();
                dt3.Clear();
                da.Fill(dt3);
                dgIlanlar.DataSource = dt3;


            }
            if (cbIlanTuru.Text == "İşyeri İlanları")
            {
                da = new SqlDataAdapter("Select *from isYeriBilgi where saticiId='" + saticiId + "'", con.con);
                dgIlanlar.TableStyles.Clear();
                tsl.GridColumnStyles.Clear();
                dgIlanlar_FormatIsyeriBilgi();
                dt3.Columns.Clear();
                dt3.Clear();
                dt1.Columns.Clear();
                dt1.Clear();
                dt2.Columns.Clear();
                dt2.Clear();
                da.Fill(dt2);
                dgIlanlar.DataSource = dt2;


            }
            if (cbIlanTuru.Text == "Arsa İlanları")
            {

                da = new SqlDataAdapter("Select *from arsaBilgi where saticiId='" + saticiId + "'", con.con);
                dgIlanlar.TableStyles.Clear();
                tsl.GridColumnStyles.Clear();
                dgIlanlar_FormatArsaBilgi();
                dt2.Columns.Clear();
                dt2.Clear();
                dt3.Columns.Clear();
                dt3.Clear();
                dt1.Columns.Clear();
                dt1.Clear();
                dgIlanlar.DataSource = null;
                da.Fill(dt1);
                dgIlanlar.DataSource = dt1;



            }
            sutunSayisi = ((DataTable)(this.dgIlanlar.DataSource)).Columns.Count;
        }
        public static int emlakId = 0;
        private void dgIlanlar_CurrentCellChanged(object sender, EventArgs e)
        {
          
            try
            {
                if (dgIlanlar[dgIlanlar.CurrentRowIndex, 0].ToString() != "" && dgIlanlar[dgIlanlar.CurrentRowIndex, 0].ToString() != "0")
                {
                    emlakId = Convert.ToInt32(dgIlanlar[dgIlanlar.CurrentRowIndex, 0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dgIlanlar.CurrentCell.ColumnNumber == (sutunSayisi - 1) && emlakId.ToString() != "" && dgIlanlar[dgIlanlar.CurrentRowIndex, 0].ToString() != "" && dgIlanlar[dgIlanlar.CurrentRowIndex, 0].ToString() != "0")
                {

                btnFotograflariGor.Left = dgIlanlar.GetCurrentCellBounds().Left;
                btnFotograflariGor.Top = dgIlanlar.GetCurrentCellBounds().Top;
                btnFotograflariGor.Width = dgIlanlar.GetCurrentCellBounds().Width;



            }
        }   
        public static string ilanturu;
        private void btnFotograflariGor_Click(object sender, EventArgs e)
        {
            
            if (emlakId.ToString() != "0")
            {
                ilanturu = cbIlanTuru.Text.ToString();
                fotograflariGor fotograflariGor = new fotograflariGor();
                fotograflariGor.Show();
            }
            else
            {
                MessageBox.Show("İlana ait resim bulunmamaktadır");
            }
        }
        private void dgIlanlar_DataSourceChanged(object sender, EventArgs e)
        {
            dgIlanlar.Controls.Remove(btnFotograflariGor);
            dgIlanlar.Controls.Add(btnFotograflariGor);
        }
        public void dgIlanlar_FormatKonutBilgi()
        {
            tsl.AlternatingBackColor = Color.Coral;
            tsl.BackColor = Color.GhostWhite;
            tsl.ForeColor = Color.Black;
            tsl.GridLineColor = Color.Aquamarine;
            tsl.HeaderBackColor = Color.RoyalBlue;
            tsl.HeaderFont = new Font("Tahoma", 8.0F, FontStyle.Bold);
            tsl.HeaderForeColor = Color.White;
            tsl.SelectionBackColor = Color.Teal;
            tsl.SelectionForeColor = Color.PaleGreen;

            tsl.MappingName = dt3.TableName;
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "konutId";
            myDataCol1.HeaderText = "Konut Id";
            myDataCol1.Width = 70;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;

            myDataCol2.MappingName = "ilanBasligi";
            myDataCol2.HeaderText = "İlan Başlığı";
            myDataCol2.Width = 90;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;

            myDataCol3.MappingName = "fiyat";
            myDataCol3.HeaderText = "Fiyat";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";

            myDataCol4.MappingName = "esyalimi";
            myDataCol4.HeaderText = "Eşyalı mı?";
            myDataCol4.Width = 60;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";

            myDataCol5.MappingName = "konutTipi";
            myDataCol5.HeaderText = "Konut Tipi";
            myDataCol5.Width = 100;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";

            myDataCol6.MappingName = "metreKare";
            myDataCol6.HeaderText = "Metrekare";
            myDataCol6.Width = 150;
            myDataCol6.Alignment = HorizontalAlignment.Left;
            myDataCol6.NullText = "";

            myDataCol7.MappingName = "odaSayisi";
            myDataCol7.HeaderText = "Oda Sayısı";
            myDataCol7.Width = 100;
            myDataCol7.Alignment = HorizontalAlignment.Left;
            myDataCol7.NullText = "";

            myDataCol8.MappingName = "il";
            myDataCol8.HeaderText = "İl";
            myDataCol8.Width = 100;
            myDataCol8.Alignment = HorizontalAlignment.Left;
            myDataCol8.NullText = "";

            myDataCol9.MappingName = "ilce";
            myDataCol9.HeaderText = "İlçe";
            myDataCol9.Width = 100;
            myDataCol9.Alignment = HorizontalAlignment.Left;
            myDataCol9.NullText = "";

            myDataCol10.MappingName = "eklenmeTarihi";
            myDataCol10.HeaderText = "Eklenme Tarihi";
            myDataCol10.Width = 100;
            myDataCol10.Alignment = HorizontalAlignment.Left;
            myDataCol10.NullText = "";

            myDataCol11.MappingName = "konutSahibi";
            myDataCol11.HeaderText = "Konut Sahibi";
            myDataCol11.Width = 100;
            myDataCol11.Alignment = HorizontalAlignment.Left;
            myDataCol11.NullText = "";

            myDataCol12.MappingName = "aidatTutari";
            myDataCol12.HeaderText = "Aidat Tutari";
            myDataCol12.Width = 100;
            myDataCol12.Alignment = HorizontalAlignment.Left;
            myDataCol12.NullText = "";

            myDataCol13.MappingName = "konutYasi";
            myDataCol13.HeaderText = "Konut Yaşı";
            myDataCol13.Width = 100;
            myDataCol13.Alignment = HorizontalAlignment.Left;
            myDataCol13.NullText = "";

            myDataCol14.MappingName = "bulunduguKat";
            myDataCol14.HeaderText = "Bulunduğu Kat";
            myDataCol14.Width = 100;
            myDataCol14.Alignment = HorizontalAlignment.Left;
            myDataCol14.NullText = "";

            myDataCol15.MappingName = "konutSatisTipi";
            myDataCol15.HeaderText = "Konut Satış Tipi";
            myDataCol15.Width = 100;
            myDataCol15.Alignment = HorizontalAlignment.Left;
            myDataCol15.NullText = "";

            myDataCol16.MappingName = "isitma";
            myDataCol16.HeaderText = "Isıtma";
            myDataCol16.Width = 100;
            myDataCol16.Alignment = HorizontalAlignment.Left;
            myDataCol16.NullText = "";

            myDataCol17.MappingName = "adres";
            myDataCol17.HeaderText = "Adres";
            myDataCol17.Width = 100;
            myDataCol17.Alignment = HorizontalAlignment.Left;
            myDataCol17.NullText = "";

            myDataCol18.MappingName = "aciklama";
            myDataCol18.HeaderText = "Açıklama";
            myDataCol18.Width = 100;
            myDataCol18.Alignment = HorizontalAlignment.Left;
            myDataCol18.NullText = "";

            myDataCol19.MappingName = "saticiId";
            myDataCol19.HeaderText = "Satıcı Id";
            myDataCol19.Width = 100;
            myDataCol19.Alignment = HorizontalAlignment.Left;
            myDataCol19.NullText = "";

            myDataCol20.MappingName = "fotografButon";
            myDataCol20.HeaderText = "İlan Fotoğrafları";
            myDataCol20.Width = 110;
            myDataCol20.Alignment = HorizontalAlignment.Left;
            myDataCol20.NullText = "";


            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5, myDataCol6, myDataCol7, myDataCol8, myDataCol9, myDataCol10, myDataCol11, myDataCol12, myDataCol13, myDataCol14, myDataCol15, myDataCol16, myDataCol17, myDataCol18, myDataCol19, myDataCol20 });
            dgIlanlar.TableStyles.Add(tsl);
        }
        public void dgIlanlar_FormatIsyeriBilgi()
        {
            tsl.AlternatingBackColor = Color.Coral;
            tsl.BackColor = Color.GhostWhite;
            tsl.ForeColor = Color.Black;
            tsl.GridLineColor = Color.Aquamarine;
            tsl.HeaderBackColor = Color.RoyalBlue;
            tsl.HeaderFont = new Font("Tahoma", 8.0F, FontStyle.Bold);
            tsl.HeaderForeColor = Color.White;
            tsl.SelectionBackColor = Color.Teal;
            tsl.SelectionForeColor = Color.PaleGreen;

            tsl.MappingName = dt2.TableName;
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "t_isyeriId";
            myDataCol1.HeaderText = "İşyeri Id";
            myDataCol1.Width = 70;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;

            myDataCol2.MappingName = "isIlanBasligi";
            myDataCol2.HeaderText = "İlan Başlığı";
            myDataCol2.Width = 90;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;

            myDataCol3.MappingName = "isFiyat";
            myDataCol3.HeaderText = "Fiyat";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";

            myDataCol4.MappingName = "isEsya";
            myDataCol4.HeaderText = "isEsya";
            myDataCol4.Width = 60;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";

            myDataCol5.MappingName = "isTur";
            myDataCol5.HeaderText = "İşyeri Tür";
            myDataCol5.Width = 100;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";

            myDataCol6.MappingName = "isMetreKare";
            myDataCol6.HeaderText = "Metrekare";
            myDataCol6.Width = 150;
            myDataCol6.Alignment = HorizontalAlignment.Left;
            myDataCol6.NullText = "";

            myDataCol7.MappingName = "isOda";
            myDataCol7.HeaderText = "Oda Sayısı";
            myDataCol7.Width = 100;
            myDataCol7.Alignment = HorizontalAlignment.Left;
            myDataCol7.NullText = "";

            myDataCol8.MappingName = "isIl";
            myDataCol8.HeaderText = "İl";
            myDataCol8.Width = 100;
            myDataCol8.Alignment = HorizontalAlignment.Left;
            myDataCol8.NullText = "";

            myDataCol9.MappingName = "isIlce";
            myDataCol9.HeaderText = "İlçe";
            myDataCol9.Width = 100;
            myDataCol9.Alignment = HorizontalAlignment.Left;
            myDataCol9.NullText = "";

            myDataCol10.MappingName = "isIlanTarihi";
            myDataCol10.HeaderText = "İlan Tarihi";
            myDataCol10.Width = 100;
            myDataCol10.Alignment = HorizontalAlignment.Left;
            myDataCol10.NullText = "";

            myDataCol11.MappingName = "isSahibi";
            myDataCol11.HeaderText = "Sahibi";
            myDataCol11.Width = 100;
            myDataCol11.Alignment = HorizontalAlignment.Left;
            myDataCol11.NullText = "";

            myDataCol12.MappingName = "isAidat";
            myDataCol12.HeaderText = "Aidat";
            myDataCol12.Width = 100;
            myDataCol12.Alignment = HorizontalAlignment.Left;
            myDataCol12.NullText = "";

            myDataCol13.MappingName = "isYas";
            myDataCol13.HeaderText = "İşyeri Yaşı";
            myDataCol13.Width = 100;
            myDataCol13.Alignment = HorizontalAlignment.Left;
            myDataCol13.NullText = "";

            myDataCol14.MappingName = "isKat";
            myDataCol14.HeaderText = "Bulunduğu Kat";
            myDataCol14.Width = 100;
            myDataCol14.Alignment = HorizontalAlignment.Left;
            myDataCol14.NullText = "";

            myDataCol15.MappingName = "isSatisTipi";
            myDataCol15.HeaderText = "Satış Tipi";
            myDataCol15.Width = 100;
            myDataCol15.Alignment = HorizontalAlignment.Left;
            myDataCol15.NullText = "";

            myDataCol16.MappingName = "isIsinma";
            myDataCol16.HeaderText = "Isınma";
            myDataCol16.Width = 100;
            myDataCol16.Alignment = HorizontalAlignment.Left;
            myDataCol16.NullText = "";

            myDataCol17.MappingName = "isAdres";
            myDataCol17.HeaderText = "Adres";
            myDataCol17.Width = 100;
            myDataCol17.Alignment = HorizontalAlignment.Left;
            myDataCol17.NullText = "";

            myDataCol18.MappingName = "isAciklama";
            myDataCol18.HeaderText = "Açıklama";
            myDataCol18.Width = 100;
            myDataCol18.Alignment = HorizontalAlignment.Left;
            myDataCol18.NullText = "";

            myDataCol19.MappingName = "saticiId";
            myDataCol19.HeaderText = "Satıcı Id";
            myDataCol19.Width = 100;
            myDataCol19.Alignment = HorizontalAlignment.Left;
            myDataCol19.NullText = "";

            myDataCol20.MappingName = "fotografButon";
            myDataCol20.HeaderText = "İlan Fotoğrafları";
            myDataCol20.Width = 110;
            myDataCol20.Alignment = HorizontalAlignment.Left;
            myDataCol20.NullText = "";


            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5, myDataCol6, myDataCol7, myDataCol8, myDataCol9, myDataCol10, myDataCol11, myDataCol12, myDataCol13, myDataCol14, myDataCol15, myDataCol16, myDataCol17, myDataCol18, myDataCol19, myDataCol20 });
            dgIlanlar.TableStyles.Add(tsl);
        }
        public void dgIlanlar_FormatArsaBilgi()
        {
            tsl.AlternatingBackColor = Color.Coral;
            tsl.BackColor = Color.GhostWhite;
            tsl.ForeColor = Color.Black;
            tsl.GridLineColor = Color.Aquamarine;
            tsl.HeaderBackColor = Color.RoyalBlue;
            tsl.HeaderFont = new Font("Tahoma", 8.0F, FontStyle.Bold);
            tsl.HeaderForeColor = Color.White;
            tsl.SelectionBackColor = Color.Teal;
            tsl.SelectionForeColor = Color.PaleGreen;

            tsl.MappingName = dt1.TableName;
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "arsaId";
            myDataCol1.HeaderText = "Arsa Id";
            myDataCol1.Width = 70;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;

            myDataCol2.MappingName = "arsaIlanBasligi";
            myDataCol2.HeaderText = "İlan Başlığı";
            myDataCol2.Width = 90;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;

            myDataCol3.MappingName = "arsaFiyat";
            myDataCol3.HeaderText = "Fiyat";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";

            myDataCol4.MappingName = "arsaMetrekare";
            myDataCol4.HeaderText = "Metrekare";
            myDataCol4.Width = 60;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";

            myDataCol5.MappingName = "arsaIl";
            myDataCol5.HeaderText = "İl";
            myDataCol5.Width = 100;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";

            myDataCol6.MappingName = "arsaIlce";
            myDataCol6.HeaderText = "İlçe";
            myDataCol6.Width = 150;
            myDataCol6.Alignment = HorizontalAlignment.Left;
            myDataCol6.NullText = "";

            myDataCol7.MappingName = "arsaIlanTarihi";
            myDataCol7.HeaderText = "İlan Tarihi";
            myDataCol7.Width = 100;
            myDataCol7.Alignment = HorizontalAlignment.Left;
            myDataCol7.NullText = "";

            myDataCol8.MappingName = "arsaIlanSahibi";
            myDataCol8.HeaderText = "İlan Sahibi";
            myDataCol8.Width = 100;
            myDataCol8.Alignment = HorizontalAlignment.Left;
            myDataCol8.NullText = "";

            myDataCol9.MappingName = "arsaAdres";
            myDataCol9.HeaderText = "Adres";
            myDataCol9.Width = 100;
            myDataCol9.Alignment = HorizontalAlignment.Left;
            myDataCol9.NullText = "";

            myDataCol10.MappingName = "arsaAidat";
            myDataCol10.HeaderText = "Aidat";
            myDataCol10.Width = 100;
            myDataCol10.Alignment = HorizontalAlignment.Left;
            myDataCol10.NullText = "";

            myDataCol11.MappingName = "arsaSatisTipi";
            myDataCol11.HeaderText = "Satış Tipi";
            myDataCol11.Width = 100;
            myDataCol11.Alignment = HorizontalAlignment.Left;
            myDataCol11.NullText = "";

            myDataCol12.MappingName = "arsaAciklama";
            myDataCol12.HeaderText = "Açıklama";
            myDataCol12.Width = 100;
            myDataCol12.Alignment = HorizontalAlignment.Left;
            myDataCol12.NullText = "";

            myDataCol13.MappingName = "saticiId";
            myDataCol13.HeaderText = "Satıcı Id";
            myDataCol13.Width = 100;
            myDataCol13.Alignment = HorizontalAlignment.Left;
            myDataCol13.NullText = "";

            myDataCol14.MappingName = "fotografButon";
            myDataCol14.HeaderText = "İlan Fotoğrafları";
            myDataCol14.Width = 110;
            myDataCol14.Alignment = HorizontalAlignment.Left;
            myDataCol14.NullText = "";



            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5, myDataCol6, myDataCol7, myDataCol8, myDataCol9, myDataCol10, myDataCol11, myDataCol12, myDataCol13, myDataCol14 });
            dgIlanlar.TableStyles.Add(tsl);
        }

      
    }
}
