using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
namespace emlakTakipProgramim
{    
    class veritabaniBaglanti
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\emlakVeritabani.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30");
        //public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["emlakTakipProgramim.Properties.Settings.emlakVeritabaniConnectionString"].ConnectionString);
        //public SqlConnection con = new SqlConnection(@"Server=.\SQLExpress;AttachDbFilename='"+Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"'\\emlakVeritabani.mdf;Integrated Security = True;User Instance=True;Trusted_Connection=Yes;MultipleActiveResultSets=True");
        //public SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-5417CA7\SQLEXPRESS;Initial Catalog = emlakVeritabani; Integrated Security = True");

    }
}
