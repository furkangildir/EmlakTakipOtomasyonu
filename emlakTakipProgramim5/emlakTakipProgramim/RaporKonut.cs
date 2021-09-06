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
    public partial class konutIlanRaporForm : Form
    {
        public konutIlanRaporForm()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        konutRapor rapor;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            dt.Clear();
                da = new SqlDataAdapter("Select *from konutBilgi", con.con);
            da.Fill(dt);
            rapor = new konutRapor();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
