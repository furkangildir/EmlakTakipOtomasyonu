using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace emlakTakipProgramim
{
    public partial class RaporIsyeri : Form
    {
        public RaporIsyeri()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        isyeriRapor rapor;
        private void RaporIsyeri_Load(object sender, EventArgs e)
        {
            dt.Clear();
            da = new SqlDataAdapter("Select *from isYeriBilgi", con.con);
            da.Fill(dt);
            rapor = new isyeriRapor();
            rapor.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
