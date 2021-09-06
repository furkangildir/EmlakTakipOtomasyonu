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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
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
        DataTable dt = new DataTable();
        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from kullaniciBilgi",con.con);
            da.Fill(dt);
            dgKullanicilar.DataSource = dt;
            dgKullanicilar_FormatKullaniciBilgi();
        }
        public void dgKullanicilar_FormatKullaniciBilgi()
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

            tsl.MappingName = dt.TableName;
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "t_kulId";
            myDataCol1.HeaderText = "Id";
            myDataCol1.Width = 70;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;

            myDataCol2.MappingName = "kullaniciTakmaAd";
            myDataCol2.HeaderText = "Kullanıcı Adı";
            myDataCol2.Width = 90;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;

            myDataCol3.MappingName = "kullaniciAdi";
            myDataCol3.HeaderText = "Adı";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";
            myDataCol3.ReadOnly = true;

            myDataCol4.MappingName = "kullaniciSoyadi";
            myDataCol4.HeaderText = "Soyadı";
            myDataCol4.Width = 60;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";
            myDataCol4.ReadOnly = true;

            myDataCol5.MappingName = "kullaniciSifre";
            myDataCol5.HeaderText = "Kullanıcı Şifre";
            myDataCol5.Width = 0;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";
            myDataCol5.ReadOnly = true;

            myDataCol6.MappingName = "kullaniciMail";
            myDataCol6.HeaderText = "Mail Adresi";
            myDataCol6.Width = 100;
            myDataCol6.Alignment = HorizontalAlignment.Left;
            myDataCol6.NullText = "";
            myDataCol6.ReadOnly = true;

            myDataCol7.MappingName = "kullaniciTelefon";
            myDataCol7.HeaderText = "Telefon";
            myDataCol7.Width = 100;
            myDataCol7.Alignment = HorizontalAlignment.Left;
            myDataCol7.NullText = "";
            myDataCol7.ReadOnly = true;

            myDataCol8.MappingName = "aciklama";
            myDataCol8.HeaderText = "Açıklama";
            myDataCol8.Width = 100;
            myDataCol8.Alignment = HorizontalAlignment.Left;
            myDataCol8.NullText = "";
            myDataCol8.ReadOnly = true;

            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5, myDataCol6 , myDataCol7 , myDataCol8});
            dgKullanicilar.TableStyles.Add(tsl);
        }
    }
}
