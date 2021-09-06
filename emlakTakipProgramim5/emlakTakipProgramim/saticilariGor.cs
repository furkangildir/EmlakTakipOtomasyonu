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
    public partial class saticilariGor : Form
    {
        public saticilariGor()
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
        SqlDataAdapter da;
        DataSet dset = new DataSet();
        private void saticilariGor_Load(object sender, EventArgs e)
        {
            try
            {

                dset.Tables.Clear();
                con.con.Open();
               
                da = new SqlDataAdapter("select * from saticilar", con.con);
                da.Fill(dset, "saticilar");
                dgSaticilar.DataSource = dset.Tables["saticilar"];

                dgSaticilar_format();
                btnIlanlarınıGor.Visible = false;
                dgSaticilar.Controls.Add(btnIlanlarınıGor);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
          
        }
        public void dgSaticilar_format()
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

            tsl.MappingName = "saticilar";
            tsl.PreferredRowHeight = 24;

            myDataCol1.MappingName = "id";
            myDataCol1.HeaderText = "Id";
            myDataCol1.Width = 70;
            myDataCol1.NullText = "";
            myDataCol1.ReadOnly = true;

            myDataCol2.MappingName = "saticiAdiSoyadi";
            myDataCol2.HeaderText = "Adı Soyadı";
            myDataCol2.Width = 90;
            myDataCol2.NullText = "";
            myDataCol2.ReadOnly = true;

            myDataCol3.MappingName = "saticiTelefon";
            myDataCol3.HeaderText = "Telefon";
            myDataCol3.Width = 60;
            myDataCol3.NullText = "";
            myDataCol3.ReadOnly = true;

            myDataCol4.MappingName = "saticiMail";
            myDataCol4.HeaderText = "Mail Adresi";
            myDataCol4.Width = 60;
            myDataCol4.Alignment = HorizontalAlignment.Left;
            myDataCol4.NullText = "";
            myDataCol4.ReadOnly = true;

            myDataCol5.MappingName = "ilanlarButon";
            myDataCol5.HeaderText = "Satıcı İlanları";
            myDataCol5.Width = 90;
            myDataCol5.Alignment = HorizontalAlignment.Left;
            myDataCol5.NullText = "";
            myDataCol5.ReadOnly = true;

            tsl.GridColumnStyles.AddRange(new DataGridColumnStyle[] { myDataCol1, myDataCol2, myDataCol3, myDataCol4, myDataCol5});
            dgSaticilar.TableStyles.Add(tsl);
        }

        private void btnIlanlarınıGor_Click(object sender, EventArgs e)
        {
            ilanlariGor ilanlariGor = new ilanlariGor();
            ilanlariGor.Show();
        }
        public static int saticiId;
        private void dgSaticilar_CurrentCellChanged(object sender, EventArgs e)
        {
            btnIlanlarınıGor.Visible = true;
            if ((dgSaticilar[dgSaticilar.CurrentRowIndex, 0]).ToString() != "") { 

            saticiId = Convert.ToInt32(dgSaticilar[dgSaticilar.CurrentRowIndex, 0]);

            if (dgSaticilar.CurrentCell.ColumnNumber == 4)
            {
                btnIlanlarınıGor.Left = dgSaticilar.GetCurrentCellBounds().Left;
                btnIlanlarınıGor.Top = dgSaticilar.GetCurrentCellBounds().Top;
                btnIlanlarınıGor.Width = dgSaticilar.GetCurrentCellBounds().Width;

            }
            }
        }
    }
}
