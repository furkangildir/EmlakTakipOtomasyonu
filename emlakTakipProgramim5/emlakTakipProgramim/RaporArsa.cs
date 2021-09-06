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
    public partial class RaporArsa : Form
    {
        public RaporArsa()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        arsaRapor rapor;
        private void RaporArsa_Load(object sender, EventArgs e)
        {
            dt.Clear();
            da = new SqlDataAdapter("Select *from arsaBilgi", con.con);
            da.Fill(dt);
            rapor = new arsaRapor();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;

        }
    }
}
