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
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        veritabaniBaglanti con = new veritabaniBaglanti();
        SqlDataAdapter da;
        DataSet ds;


        private void yoneticiForm_Load(object sender, EventArgs e)
        {

            ToolStripItemCollection menuOgeler = msYoneticiForm.Items;
            int kullaniciId = Giris.id;
            con.con.Open();
            da = new SqlDataAdapter("Select *from yetkiler where kulId='" + kullaniciId + "'", con.con);
            ds = new DataSet();
            da.Fill(ds, "yetkiler");
            con.con.Close();
          
                if (ds.Tables[0].Rows.Count >= 0)
                {

                    DataTable tablo = ds.Tables["yetkiler"];
                    foreach (ToolStripMenuItem menuitem in msYoneticiForm.Items)
                    {
                        if (bool.Parse(tablo.Rows[0]["Satılık"].ToString()) == false)
                        {
                            if (menuitem.Text == "Satılık")
                                menuitem.Visible = false;
                        }
                        if (bool.Parse(tablo.Rows[0]["Müşteriler"].ToString()) == false)
                        {
                            if (menuitem.Text == "Müşteriler")
                                menuitem.Visible = false;
                        }
                        if (bool.Parse(tablo.Rows[0]["Raporlar"].ToString()) == false)
                        {
                            if (menuitem.Text == "Raporlar")
                                menuitem.Visible = false;
                        }
                        if (bool.Parse(tablo.Rows[0]["İlanları Düzenle"].ToString()) == false)
                        {
                            if (menuitem.Text == "İlanları Düzenle")
                                menuitem.Visible = false;
                        }
                        if (bool.Parse(tablo.Rows[0]["Kapat"].ToString()) == false)
                        {
                            if (menuitem.Text == "Kapat")
                                menuitem.Visible = false;
                        }
                        if (bool.Parse(tablo.Rows[0]["Kullanıcıları Düzenle"].ToString()) == false)
                        {
                            if (menuitem.Text == "Kullanıcıları Düzenle")
                                menuitem.Visible = false;
                        }

                        if (bool.Parse(tablo.Rows[0]["Kullanıcılar"].ToString()) == false)
                        {
                            if (menuitem.Text == "Kullanıcılar")
                                menuitem.Visible = false;
                        }



                        foreach (ToolStripDropDownItem subitem in menuitem.DropDownItems)
                        {
                            if (bool.Parse(tablo.Rows[0]["Konut Ekle"].ToString()) == false)
                            {
                                if (subitem.Text == "Konut Ekle")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["İşyeri Ekle"].ToString()) == false)
                            {
                                if (subitem.Text == "İşyeri Ekle")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["Arsa Ekle"].ToString()) == false)
                            {
                                if (subitem.Text == "Arsa Ekle")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["Satıcılar"].ToString()) == false)
                            {
                                if (subitem.Text == "Satıcılar")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["Alıcılar"].ToString()) == false)
                            {
                                if (subitem.Text == "Alıcılar")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["Konut İlan Raporu"].ToString()) == false)
                            {
                                if (subitem.Text == "Konut İlan Raporu")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["Arsa İlan Raporu"].ToString()) == false)
                            {
                                if (subitem.Text == "Arsa İlan Raporu")
                                    subitem.Visible = false;
                            }
                            if (bool.Parse(tablo.Rows[0]["İşyeri İlan Raporu"].ToString()) == false)
                            {
                                if (subitem.Text == "İşyeri İlan Raporu")
                                    subitem.Visible = false;
                            }

                        }

                    }
                }

                else
                {
                    MessageBox.Show("Yetkiler tablosunda kayıt bulunmamaktadır...!");
                }

            }
   
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            kullaniciBilgiler kullaniciDuzenleForm = new kullaniciBilgiler();
            kullaniciDuzenleForm.Show();

        }

        private void satıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saticilariGor saticiGor = new saticilariGor();
            saticiGor.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            satilikKonut satilikKonut = new satilikKonut();
            satilikKonut.Show();
        }

        private void işYeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isyeriForm isyeriForm = new isyeriForm();
            isyeriForm.Show();
        }

        private void arsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arsaForm arsaForm = new arsaForm();
            arsaForm.Show();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
        }

        private void alıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alicilar alicilar = new Alicilar();
            alicilar.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kapatmak istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void konutİlanRaporuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            konutIlanRaporForm konutIlanRaporForm = new konutIlanRaporForm();
            konutIlanRaporForm.Show();
        }

        private void işyeriİlanRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporIsyeri raporIsyeri = new RaporIsyeri();
            raporIsyeri.Show();
        }

        private void konutİlanRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporArsa raporArsa = new RaporArsa();
            raporArsa.Show();
        }

        private void İlanlarıDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlanlariDuzenle ilanlariDuzenle = new frmIlanlariDuzenle();
            ilanlariDuzenle.Show();
        }
    }
}
