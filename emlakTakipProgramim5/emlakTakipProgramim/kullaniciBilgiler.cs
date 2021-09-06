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
    public partial class kullaniciBilgiler : Form
    {
        public kullaniciBilgiler()
        {
            InitializeComponent();
        }



        veritabaniBaglanti con = new veritabaniBaglanti();
        DataSet dset= new DataSet();
        private DataGridTableStyle tsl = new DataGridTableStyle();
        private DataGridTextBoxColumn myDataCol1 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol2 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol3 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol4 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol5 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol6 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol7 = new DataGridTextBoxColumn();
        private DataGridTextBoxColumn myDataCol8 = new DataGridTextBoxColumn();
        private SqlDataAdapter da;
        private SqlCommandBuilder scb;
        private void KullaniciBilgiler_Load(object sender, EventArgs e)
        {
            try
            {

                dset.Tables.Clear();
                con.con.Open();
                dgKullanicilar.Controls.Add(btnDgKullaniciYetkisi);
                da = new SqlDataAdapter("select * from kullaniciBilgi", con.con);
               
                da.Fill(dset, "kullaniciBilgi");
                dgKullanicilar.DataSource = dset.Tables["kullaniciBilgi"];
                
                dgogrenci_format();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
        public void dgogrenci_format()
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

            tsl.MappingName = "kullaniciBilgi";
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "t_kulId";
            myDataCol1.HeaderText = "Kullanıcı Id";
            myDataCol1.Width = 70;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;

            myDataCol2.MappingName = "kullaniciTakmaAd";
            myDataCol2.HeaderText = "Kullanıcı Adı";
            myDataCol2.Width = 90;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;

            myDataCol3.MappingName = "kullaniciAdi";
            myDataCol3.HeaderText = "Ad";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";

            myDataCol4.HeaderText = "Soyad";
            myDataCol4.MappingName = "kullaniciSoyadi";
            myDataCol4.Width = 60;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";

            myDataCol5.HeaderText = "Kullanıcı Şifresi";
            myDataCol5.MappingName = "kullaniciSifre";
            myDataCol5.Width = 100;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";

            myDataCol6.HeaderText = "Kullanıcı Mail";
            myDataCol6.MappingName = "kullaniciMail";
            myDataCol6.Width = 150;
            myDataCol6.Alignment = HorizontalAlignment.Left;
            myDataCol6.NullText = "";

            myDataCol7.HeaderText = "Kullanıcı Telefon";
            myDataCol7.MappingName = "kullaniciTelefon";
            myDataCol7.Width = 100;
            myDataCol7.Alignment = HorizontalAlignment.Left;
            myDataCol7.NullText = "";

            myDataCol8.HeaderText = "Kullanıcı Yetkileri";
            myDataCol8.MappingName = "yetkiButon";
            myDataCol8.Width = 100;
            myDataCol8.Alignment = HorizontalAlignment.Left;
            myDataCol8.NullText = "";


            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5, myDataCol6, myDataCol7, myDataCol8});
            dgKullanicilar.TableStyles.Add(tsl);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(da);
            da.Update(dset, "kullaniciBilgi");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void brnKullaniciYetkiler_Click(object sender, EventArgs e)
        {
            KullaniciYetkiler kulYetki = new KullaniciYetkiler();
            kulYetki.Show();
        }
        public static int kullaniciNo;
        private void dgKullanicilar_CurrentCellChanged(object sender, EventArgs e)
        {

            kullaniciNo = Convert.ToInt32(dgKullanicilar[dgKullanicilar.CurrentRowIndex,0]);

            if (dgKullanicilar.CurrentCell.ColumnNumber == 7)
            {
                btnDgKullaniciYetkisi.Left = dgKullanicilar.GetCurrentCellBounds().Left;
                btnDgKullaniciYetkisi.Top = dgKullanicilar.GetCurrentCellBounds().Top;
                btnDgKullaniciYetkisi.Width = dgKullanicilar.GetCurrentCellBounds().Width;

            }
        }
    }
}
