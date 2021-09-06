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
using System.Diagnostics;

namespace emlakTakipProgramim
{
    public partial class fotograflariGor : Form
    {
        public fotograflariGor()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        List<PictureBox> pb = new List<PictureBox>();
        SqlCommand cmd;
        private void fotograflariGor_Load(object sender, EventArgs e)
        {
           
            con.con.Open();

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                    pb.Add(item as PictureBox);
            }

            if (ilanlariGor.ilanturu == "Konut İlanları")
            {
                cmd = new SqlCommand("Select *from konutResimler where ilanId='" + ilanlariGor.emlakId + "'", con.con);
            }
            if (ilanlariGor.ilanturu == "İşyeri İlanları")
            {
                cmd = new SqlCommand("Select *from isResimler where ilanId='" + ilanlariGor.emlakId + "'", con.con);
            }
            if (ilanlariGor.ilanturu == "Arsa İlanları")
            {
                cmd = new SqlCommand("Select *from arsaResimler where ilanId='" + ilanlariGor.emlakId + "'", con.con);
            }
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    pb[1].Tag = dr["resim1"];
                    pb[2].Tag = dr["resim2"];
                    pb[3].Tag = dr["resim3"];
                    pb[4].Tag = dr["resim4"];
                    pb[5].Tag = dr["resim5"];
                    pb[6].Tag = dr["resim6"];
                }
                pictureBox1.ImageLocation = pb[1].Tag.ToString();
                pictureBox2.ImageLocation = pb[2].Tag.ToString();
                pictureBox3.ImageLocation = pb[3].Tag.ToString();
                pictureBox4.ImageLocation = pb[4].Tag.ToString();
                pictureBox5.ImageLocation = pb[5].Tag.ToString();
                pictureBox6.ImageLocation = pb[6].Tag.ToString();
            }
            else
            {
                MessageBox.Show("İlana ait resim bulunmamaktadır");
                this.Close();
            }
            con.con.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            pictureBox11.Image = ((PictureBox)sender).Image;
            pictureBox11.Tag = ((PictureBox)sender).Tag;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = pictureBox11.Tag.ToString();
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
   

