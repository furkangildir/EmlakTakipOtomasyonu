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
    public partial class fotografDuzenle : Form
    {
        public fotografDuzenle()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        frmIlanlariDuzenle IlanlariDuzenle = new frmIlanlariDuzenle();
        List<PictureBox> pb = new List<PictureBox>();
        SqlCommand cmd;
        SqlDataReader dr;
        private void fotografDuzenle_Load(object sender, EventArgs e)
        {
            if (frmIlanlariDuzenle.emlakIdFotograf != 0)
            {
                try
                {
                    con.con.Open();
                    foreach (Control item in this.Controls)
                    {
                        if (item is PictureBox)
                            pb.Add(item as PictureBox);
                    }
                    if (frmIlanlariDuzenle.ilanTuru.ToString() == "Konut İlanları")
                    {
                        cmd = new SqlCommand("Select *from konutResimler where ilanId='" + frmIlanlariDuzenle.emlakIdFotograf.ToString() + "'", con.con);
                    }

                    if (frmIlanlariDuzenle.ilanTuru.ToString() == "İşyeri İlanları")
                    {
                        cmd = new SqlCommand("Select *from isResimler where ilanId='" + frmIlanlariDuzenle.emlakIdFotograf.ToString() + "'", con.con);
                    }

                    if (frmIlanlariDuzenle.ilanTuru.ToString() == "Arsa İlanları")
                    {
                        cmd = new SqlCommand("Select *from arsaResimler where ilanId='" + frmIlanlariDuzenle.emlakIdFotograf.ToString() + "'", con.con);
                    }
                    dr = cmd.ExecuteReader();
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
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden kayıt seçiniz");
            }

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
        List<PictureBox> pb1 = new List<PictureBox>();
        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                    pb1.Add(item as PictureBox);
            }
            ofd.ShowDialog();
        }
        List<string> dosyaAdi = new List<string>();
        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            try
            {

                if (ofd.FileNames.Length == 6)
                {

                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb1[i + 1].Image = Image.FromFile(ofd.FileNames[i]);
                        pb1[i + 1].Tag = ofd.SafeFileNames[i];
                        dosyaAdi.Add(ofd.SafeFileNames[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Resimleri eklemek için 6 resim seçmelisiniz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void kontrolTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox resimKutu = (PictureBox)item;
                    resimKutu.Image = null;
                }

            }
        }
        List<string> resimYol = new List<string>();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (frmIlanlariDuzenle.ilanTuru=="Konut İlanları")
            {
                if (pictureBox1.Image != null)
                {

                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb[i + 1].Image.Save(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i], System.Drawing.Imaging.ImageFormat.Jpeg);
                        resimYol.Add(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i]);

                    }
                }


                con.con.Open();
                SqlCommand cmd2 = new SqlCommand("Update konutResimler set resim1=@1,resim2=@2,resim3=@3,resim4=@4,resim5=@5,resim6=@6 where ilanId='" + frmIlanlariDuzenle.emlakIdFotograf.ToString() + "'", con.con);
                cmd2.Parameters.AddWithValue("@1", resimYol[0].ToString());
                cmd2.Parameters.AddWithValue("@2", resimYol[1].ToString());
                cmd2.Parameters.AddWithValue("@3", resimYol[2].ToString());
                cmd2.Parameters.AddWithValue("@4", resimYol[3].ToString());
                cmd2.Parameters.AddWithValue("@5", resimYol[4].ToString());
                cmd2.Parameters.AddWithValue("@6", resimYol[5].ToString());
                cmd2.ExecuteNonQuery();
                con.con.Close();
                MessageBox.Show("Resimler başarıyla güncellendi");
                kontrolTemizle();
                pictureBox11.Image = null;
            }
            if (frmIlanlariDuzenle.ilanTuru == "İşyeri İlanları")
            {
                if (pictureBox1.Image != null)
                {

                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb[i + 1].Image.Save(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i], System.Drawing.Imaging.ImageFormat.Jpeg);
                        resimYol.Add(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i]);

                    }
                }


                con.con.Open();
                SqlCommand cmd2 = new SqlCommand("Update isResimler set resim1=@1,resim2=@2,resim3=@3,resim4=@4,resim5=@5,resim6=@6 where ilanId='" + frmIlanlariDuzenle.emlakIdFotograf.ToString() + "'", con.con);
                cmd2.Parameters.AddWithValue("@1", resimYol[0].ToString());
                cmd2.Parameters.AddWithValue("@2", resimYol[1].ToString());
                cmd2.Parameters.AddWithValue("@3", resimYol[2].ToString());
                cmd2.Parameters.AddWithValue("@4", resimYol[3].ToString());
                cmd2.Parameters.AddWithValue("@5", resimYol[4].ToString());
                cmd2.Parameters.AddWithValue("@6", resimYol[5].ToString());
                cmd2.ExecuteNonQuery();
                con.con.Close();
                MessageBox.Show("Resimler başarıyla güncellendi");
                kontrolTemizle();
                pictureBox11.Image = null;
            }
            if (frmIlanlariDuzenle.ilanTuru == "Arsa İlanları")
            {
                if (pictureBox1.Image != null)
                {

                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        pb[i + 1].Image.Save(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i], System.Drawing.Imaging.ImageFormat.Jpeg);
                        resimYol.Add(Application.StartupPath + "\\Resimler\\" + dosyaAdi[i]);

                    }
                }


                con.con.Open();
                SqlCommand cmd2 = new SqlCommand("Update arsaResimler set resim1=@1,resim2=@2,resim3=@3,resim4=@4,resim5=@5,resim6=@6 where ilanId='" + frmIlanlariDuzenle.emlakIdFotograf.ToString() + "'", con.con);
                cmd2.Parameters.AddWithValue("@1", resimYol[0].ToString());
                cmd2.Parameters.AddWithValue("@2", resimYol[1].ToString());
                cmd2.Parameters.AddWithValue("@3", resimYol[2].ToString());
                cmd2.Parameters.AddWithValue("@4", resimYol[3].ToString());
                cmd2.Parameters.AddWithValue("@5", resimYol[4].ToString());
                cmd2.Parameters.AddWithValue("@6", resimYol[5].ToString());
                cmd2.ExecuteNonQuery();
                con.con.Close();
                MessageBox.Show("Resimler başarıyla güncellendi");
                kontrolTemizle();
                pictureBox11.Image = null;
            }
        }
            
    }

}
