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
    public partial class KullaniciYetkiler : Form
    {
        public KullaniciYetkiler()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        DataSet dset = new DataSet();
        private DataGridTableStyle tsl = new DataGridTableStyle();
        private DataGridBoolColumn myDataCol1 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol2 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol3 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol4 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol5 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol6 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol7 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol8 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol9 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol10 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol11 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol12 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol13 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol14 = new DataGridBoolColumn();
        private DataGridBoolColumn myDataCol15 = new DataGridBoolColumn();
        private SqlDataAdapter da;
        private SqlCommandBuilder scb;
        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            try
            {

                dset.Tables.Clear();
                con.con.Open();
                da = new SqlDataAdapter("select * from yetkiler where id='"+kullaniciBilgiler.kullaniciNo+"' ", con.con);
                da.Fill(dset, "yetkiler");
                dgKullanicilar.DataSource = dset.Tables["yetkiler"];
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

            tsl.MappingName = "yetkiler";
            tsl.PreferredColumnWidth = 1000;
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "id";
            myDataCol1.HeaderText = "Id";
            myDataCol1.Width = 20;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;
            myDataCol1.TrueValue = true;
            myDataCol1.FalseValue = false;
            myDataCol1.AllowNull = false;
     

            myDataCol2.MappingName = "kullaniciId";
            myDataCol2.HeaderText = "Kullanıcı Id";
            myDataCol2.Width = 70;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;
            myDataCol2.TrueValue = true;
            myDataCol2.FalseValue = false;
            myDataCol2.AllowNull = false;


            myDataCol3.MappingName = "Satılık";
            myDataCol3.HeaderText = "Satılık";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";
            myDataCol3.TrueValue = true;
            myDataCol3.FalseValue = false;
            myDataCol3.AllowNull = false;


            myDataCol4.HeaderText = "Müşteriler";
            myDataCol4.MappingName = "Müşteriler";
            myDataCol4.Width = 70;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";
            myDataCol4.TrueValue = true;
            myDataCol4.FalseValue = false;
            myDataCol4.AllowNull = false;
       

            myDataCol5.HeaderText = "Raporlar";
            myDataCol5.MappingName = "Raporlar";
            myDataCol5.Width = 100;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";
            myDataCol5.TrueValue = true;
            myDataCol5.FalseValue = false;
            myDataCol5.AllowNull = false;
          

            myDataCol6.HeaderText = "İlanları Düzenle";
            myDataCol6.MappingName = "İlanları Düzenle";
            myDataCol6.Width = 100;
            myDataCol6.Alignment = HorizontalAlignment.Left;
            myDataCol6.NullText = "";
            myDataCol6.TrueValue = true;
            myDataCol6.FalseValue = false;
            myDataCol6.AllowNull = false;
          
             
            myDataCol7.HeaderText = "Konut Ekle";
            myDataCol7.MappingName = "Konut Ekle";
            myDataCol7.Width = 80;
            myDataCol7.Alignment = HorizontalAlignment.Left;
            myDataCol7.NullText = "";
            myDataCol7.TrueValue = true;
            myDataCol7.FalseValue = false;
            myDataCol7.AllowNull = false;
        

            myDataCol8.HeaderText = "İşyeri Ekle";
            myDataCol8.MappingName = "İşyeri Ekle";
            myDataCol8.Width = 80;
            myDataCol8.Alignment = HorizontalAlignment.Center;
            myDataCol8.NullText = "";
            myDataCol8.TrueValue = true;
            myDataCol8.FalseValue = false;
            myDataCol8.AllowNull = false;
         

            myDataCol9.HeaderText = "Arsa Ekle";
            myDataCol9.MappingName = "Arsa Ekle";
            myDataCol9.Width = 70;
            myDataCol9.Alignment = HorizontalAlignment.Center;
            myDataCol9.NullText = "";
            myDataCol9.TrueValue = true;
            myDataCol9.FalseValue = false;
            myDataCol9.AllowNull = false;
          

            myDataCol10.HeaderText = "Satıcı";
            myDataCol10.MappingName = "Satıcılar";
            myDataCol10.Width = 70;
            myDataCol10.Alignment = HorizontalAlignment.Center;
            myDataCol10.NullText = "";
            myDataCol10.TrueValue = true;
            myDataCol10.FalseValue = false;
            myDataCol10.AllowNull = false;
        

            myDataCol11.HeaderText = "Alıcı";
            myDataCol11.MappingName = "Alıcılar";
            myDataCol11.Width = 70;
            myDataCol11.Alignment = HorizontalAlignment.Center;
            myDataCol11.NullText = "";
            myDataCol11.TrueValue = true;
            myDataCol11.FalseValue = false;
            myDataCol11.AllowNull = false;

            myDataCol12.HeaderText = "Konut İlan Raporu";
            myDataCol12.MappingName = "Konut İlan Raporu";
            myDataCol12.Width = 70;
            myDataCol12.Alignment = HorizontalAlignment.Center;
            myDataCol12.NullText = "";
            myDataCol12.TrueValue = true;
            myDataCol12.FalseValue = false;
            myDataCol12.AllowNull = false;

            myDataCol13.HeaderText = "Arsa İlan Raporu";
            myDataCol13.MappingName = "Arsa İlan Raporu";
            myDataCol13.Width = 70;
            myDataCol13.Alignment = HorizontalAlignment.Center;
            myDataCol13.NullText = "";
            myDataCol13.TrueValue = true;
            myDataCol13.FalseValue = false;
            myDataCol13.AllowNull = false;

            myDataCol14.HeaderText = "İşyeri İlan Raporu";
            myDataCol14.MappingName ="İşyeri İlan Raporu";
            myDataCol14.Width = 70;
            myDataCol14.Alignment = HorizontalAlignment.Center;
            myDataCol14.NullText = "";
            myDataCol14.TrueValue = true;
            myDataCol14.FalseValue = false;
            myDataCol14.AllowNull = false;

            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5, myDataCol6, myDataCol7, myDataCol8, myDataCol9, myDataCol10, myDataCol11});
            dgKullanicilar.TableStyles.Add(tsl);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(da);
            da.Update(dset, "yetkiler");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void brnKullaniciEkle_Click(object sender, EventArgs e)
        {
            kullaniciBilgiler kulEkle = new kullaniciBilgiler();
            kulEkle.Show();
        }
    }
}