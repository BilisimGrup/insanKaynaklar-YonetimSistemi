using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriyapilariproje
{
    public partial class Form2 : Form
    {
        public string güncellenenKisiAd;
        EgitimDurum egitimDurum = new EgitimDurum();
        IsDeneyimi isDeneyimi = new IsDeneyimi();
        public Form2()
        {
            InitializeComponent();
            JsonReadWrite.JsonToTree();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdayKaydet_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            List<string> egitimDurumu = new List<string>();
            List<string> isDeneyimi = new List<string>();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.TelNo = txtTelefon.Text;
            kisi.Eposta = txtPosta.Text;
            kisi.YabanciDil = txtYabancidil.Text;
            kisi.Ehliyet = txtEhliyet.Text;
            kisi.DogumTarihi = Convert.ToDateTime(dgmTrh.Value);
            kisi.Adres = txtAdres.Text;
            egitimDurumu.Add(okuladitxt.Text);
            egitimDurumu.Add(bolumaditxt.Text);
            egitimDurumu.Add(bastarihtxt.Text);
            egitimDurumu.Add(bitistrhtxt.Text);
            egitimDurumu.Add(okulNotOrttxt.Text);
            isDeneyimi.Add(isadtext.Text);
            isDeneyimi.Add(isadres.Text);
            isDeneyimi.Add(ispoztxt.Text);
            isDeneyimi.Add(süretxt.Text);
            kisi.egitimDurumuEkle(egitimDurumu);
            kisi.isDeneyimiEkle(isDeneyimi);
            Form1.ikiliagac.Ekle(kisi);
            Form1.ikiliagac.DugumYaz(Form1.ikiliagac.ReturnKok());
            MessageBox.Show("Json Export işlemi tamamlandı");

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtPosta.Text = "";
            txtYabancidil.Text = "";
            txtEhliyet.Text = "";

            txtAdres.Text = "";
            okuladitxt.Text = "";
            bolumaditxt.Text = "";
            bastarihtxt.Text = "";
            bitistrhtxt.Text = "";
            okulNotOrttxt.Text = "";
            isadtext.Text = "";
            isadres.Text = "";
            ispoztxt.Text = "";
            süretxt.Text = "";
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void bolumaditxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKisiGetir_Click(object sender, EventArgs e)
        {
            Kisi arananKisi = new Kisi();
            LinkedList<List<string>> egitimDurumu = new LinkedList<List<string>>();
            LinkedList<List<string>> isDeneyimLinked = new LinkedList<List<string>>();
            List<string> egtm = new List<string>();
            List<string> isdnym = new List<string>();

            İkiliAramaAgacDugumu agacDugum = new İkiliAramaAgacDugumu();
            agacDugum = Form1.ikiliagac.Ara(txtArananKisi.Text);
            if( agacDugum != null)
            {
                arananKisi = Form1.ikiliagac.Ara(txtArananKisi.Text).veri;
            }else
            {
                arananKisi = null;
            }

                        
            if (arananKisi == null)
            {
                MessageBox.Show("Kişi Bulunamadı");
            }
            else
            {
                egitimDurumu = arananKisi.egitimDurumu;
                egtm = egitimDurumu.ElementAt(0);
                isDeneyimLinked = arananKisi.isDeneyimi;
                isdnym = isDeneyimLinked.ElementAt(0);


                goradtxt.Text = arananKisi.Ad;
                gorsoyadtxt.Text = arananKisi.Soyad;
                gorteltxt.Text = arananKisi.TelNo;
                gorpostatxt.Text = arananKisi.Eposta;
                goryabancidiltxt.Text = arananKisi.YabanciDil;
                gorehliyettxt.Text = arananKisi.Ehliyet;
                dateTimePicker1.Value = arananKisi.DogumTarihi;
                goradrestxt.Text = arananKisi.Adres;
                gorokuladtxt.Text = egtm[0];
                gorbolumtxt.Text = egtm[1];
                gorbastxt.Text = egtm[2];
                gorbitistxt.Text = egtm[3];
                gornotorttxt.Text = egtm[4];
                gorisyeritxt.Text = isdnym[0];
                gorisadrestxt.Text = isdnym[1];
                gorispoztxt.Text = isdnym[2];
                gorsuretxt.Text = isdnym[3];
               
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Form1.ikiliagac.Sil(txtSKisi.Text) == true)
            {
                Form1.ikiliagac.DugumYaz(Form1.ikiliagac.ReturnKok());
                MessageBox.Show("Kişi Silindi");
            }
               
            else
                MessageBox.Show("Kişi Bulunamadı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi arananKisi = new Kisi();
            LinkedList<List<string>> egitimDurumu = new LinkedList<List<string>>();
            LinkedList<List<string>> isDeneyimLinked = new LinkedList<List<string>>();
            List<string> egtm = new List<string>();
            List<string> isdnym = new List<string>();


            İkiliAramaAgacDugumu agacDugum = new İkiliAramaAgacDugumu();
            agacDugum = Form1.ikiliagac.Ara(gncgetirtxt.Text);
            if (agacDugum != null)
            {
                arananKisi = Form1.ikiliagac.Ara(gncgetirtxt.Text).veri;
            }
            else
            {
                arananKisi = null;
            }
                       
            if (arananKisi == null)
            {
                MessageBox.Show("Kişi Bulunamadı");
            }
            else
            {
                güncellenenKisiAd =arananKisi.Ad;
                egitimDurumu = arananKisi.egitimDurumu;
                egtm = egitimDurumu.ElementAt(0);
                isDeneyimLinked = arananKisi.isDeneyimi;
                isdnym = isDeneyimLinked.ElementAt(0);

                gncladtxt.Text = arananKisi.Ad;
                gnclsoyadtxt.Text = arananKisi.Soyad;
                gnclteltxt.Text = arananKisi.TelNo;
                gnclpostatxt.Text = arananKisi.Eposta;
                gnclyabdiltxt.Text = arananKisi.YabanciDil;
                gnclehliyettxt.Text = arananKisi.Ehliyet;
                dateTimePicker6.Value = arananKisi.DogumTarihi;
                gncladrestxt.Text = arananKisi.Adres;
                gnclokuladtxt.Text = egtm[0];
                gnclbolumtxt.Text = egtm[1];
                gnclbastarihtxt.Text = egtm[2];
                gnclbitistxt.Text = egtm[3];
                gnclnotorttx.Text = egtm[4];
                gnclisadtxt.Text = isdnym[0];
                gnclisadrestxt.Text = isdnym[1];
                gnclispoztxt.Text = isdnym[2];
                gnclissuretxt.Text = isdnym[3];
               
            }
        }

        private void btnGncl_Click(object sender, EventArgs e)
        {
            Form1.ikiliagac.Sil(güncellenenKisiAd);
            Kisi kisi = new Kisi();
            List<string> egitimDurumu = new List<string>();
            List<string> isDeneyimi = new List<string>();
            kisi.Ad = gncladtxt.Text;
            kisi.Soyad = gnclsoyadtxt.Text;
            kisi.TelNo = gnclteltxt.Text;
            kisi.Eposta = gnclpostatxt.Text;
            kisi.YabanciDil = gnclyabdiltxt.Text;
            kisi.Ehliyet = gnclehliyettxt.Text;
            kisi.DogumTarihi = Convert.ToDateTime(dateTimePicker6.Value);
            kisi.Adres = gncladrestxt.Text;
            egitimDurumu.Add(gnclokuladtxt.Text);
            egitimDurumu.Add(gnclbolumtxt.Text);
            egitimDurumu.Add(gnclbastarihtxt.Text);
            egitimDurumu.Add(gnclbitistxt.Text);
            egitimDurumu.Add(gnclnotorttx.Text);
            isDeneyimi.Add(gnclisadtxt.Text);
            isDeneyimi.Add(gnclisadrestxt.Text);
            isDeneyimi.Add(gnclispoztxt.Text);
            isDeneyimi.Add(gnclissuretxt.Text);
            kisi.egitimDurumuEkle(egitimDurumu);
            kisi.isDeneyimiEkle(isDeneyimi);
            Form1.ikiliagac.Ekle(kisi);
            Form1.ikiliagac.DugumYaz(Form1.ikiliagac.ReturnKok());




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void txtArananKisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void gorispoztxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
