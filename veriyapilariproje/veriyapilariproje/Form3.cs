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
    public partial class Form3 : Form
    {
        public  List<Kisi> tempListe = new List<Kisi>();
        public string tempDosyaAdi;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            listBoxInOrder.Items.Clear();
            Form1.ikiliagac.InOrder();
            foreach (Kisi ListIn in Form1.ikiliagac.InOrderList)
            {
                listBoxInOrder.Items.Add(ListIn.Ad + " " + ListIn.Soyad);
            }

        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            listBoxPreOrder.Items.Clear();
            Form1.ikiliagac.PreOrder();
            foreach (Kisi ListIn in Form1.ikiliagac.PreOrderList)
            {
                listBoxPreOrder.Items.Add(ListIn.Ad + " " + ListIn.Soyad);
            }
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            listBoxPostOrder.Items.Clear();
            Form1.ikiliagac.PostOrder();
            foreach (Kisi ListPost in Form1.ikiliagac.PostOrderList)
            {
                listBoxPostOrder.Items.Add(ListPost.Ad + " " + ListPost.Soyad);
            }
        }

        private void btnAgacDerinlikBul_Click(object sender, EventArgs e)
        {
            derinlikLabel.Text = "Derinlik sayisi:" + Form1.ikiliagac.AgacDerinlikSayisi().ToString();
        }

        private void btnAgacElemanSayisiBul_Click(object sender, EventArgs e)
        {
            elemanSayiLabel.Text = "Eleman Sayisi:" + Form1.ikiliagac.DugumSayisi().ToString();
        }

        private void btnYabanciDilBilenler_Click(object sender, EventArgs e)
        {
            ListBoxSorgu.Items.Clear();
            tempListe.Clear();
            tempDosyaAdi = "YabanciDilBilenler " + DilTexbox.Text + ".json";

            Form1.ikiliagac.DilBul(Form1.ikiliagac.ReturnKok(), DilTexbox.Text);
            foreach (Kisi ListPost in Form1.ikiliagac.dilBilen)
            {
                ListBoxSorgu.Items.Add(ListPost.Ad + " " + ListPost.Soyad + " " + ListPost.YabanciDil + ListPost.DogumTarihi.Year);
                tempListe.Add(ListPost);
            }
            Form1.ikiliagac.dilBilen.Clear();
        }

        private void btnEnAzIkıYılTecrube_Click(object sender, EventArgs e)
        {

            ListBoxSorgu.Items.Clear();
            tempListe.Clear();
            tempDosyaAdi = "Deneyimiaz " + deneyimTexBox.Text + "yıl.json";
            Form1.ikiliagac.İsdeneyimiSorgu(Form1.ikiliagac.ReturnKok(), deneyimTexBox.Text);
            foreach (Kisi ListPost in Form1.ikiliagac.İsdeneyimiSorguList)
            {
                ListBoxSorgu.Items.Add(ListPost.Ad + " " + ListPost.Soyad + " " + ListPost.isDeneyimi.ElementAt(0)[3]);
                tempListe.Add(ListPost);
            }
            Form1.ikiliagac.İsdeneyimiSorguList.Clear();
        }

        private void btnTumkisi_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 16;
            string[] colon = { "Ad", "Soyad", "Telefon Numarasi", "Eposta", "Ehliyet", "Dogum Tarihi", "Yabanci Dil","Okul Adı","Bölüm Adı","Baslngıç Tarihi","Bitiş Tarihi","Not Ortalaması","İş Yeri adı","İş Yeri Adres","İş Pozisyonu","İş Deneyim Süresi" };
            for (int i = 0; i < 16; i++)
            {
                dataGridView1.Columns[i].Name = colon[i];
            }

            Form1.ikiliagac.TumKisi(Form1.ikiliagac.ReturnKok());
            foreach (Kisi ListPost in Form1.ikiliagac.TumKisiListe)
            {
                dataGridView1.Rows.Add(ListPost.Ad, ListPost.Soyad, ListPost.TelNo, ListPost.Eposta, ListPost.Ehliyet, ListPost.DogumTarihi, ListPost.YabanciDil,ListPost.egitimDurumu.ElementAt(0)[0], ListPost.egitimDurumu.ElementAt(0)[1], ListPost.egitimDurumu.ElementAt(0)[2], ListPost.egitimDurumu.ElementAt(0)[3], ListPost.egitimDurumu.ElementAt(0)[4], ListPost.isDeneyimi.ElementAt(0)[0], ListPost.isDeneyimi.ElementAt(0)[1], ListPost.isDeneyimi.ElementAt(0)[2], ListPost.isDeneyimi.ElementAt(0)[3]);
                
            }
            Form1.ikiliagac.TumKisiListe.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi ListPost = new Kisi();
            dataGridView1.ColumnCount = 16;
            string[] colon = { "Ad", "Soyad", "Telefon Numarasi", "Eposta", "Ehliyet", "Dogum Tarihi", "Yabanci Dil", "Okul Adı", "Bölüm Adı", "Baslngıç Tarihi", "Bitiş Tarihi", "Not Ortalaması", "İş Yeri adı", "İş Yeri Adres", "İş Pozisyonu", "İş Deneyim Süresi" };
            for (int i = 0; i < 16; i++)
            {
                dataGridView1.Columns[i].Name = colon[i];
            }
            İkiliAramaAgacDugumu agacDugum = new İkiliAramaAgacDugumu();
            agacDugum = Form1.ikiliagac.Ara(textBox1.Text);
            if (agacDugum != null)
            {
                dataGridView1.Rows.Clear();

                ListPost = Form1.ikiliagac.Ara(textBox1.Text).veri;
                dataGridView1.Rows.Add(ListPost.Ad, ListPost.Soyad, ListPost.TelNo, ListPost.Eposta, ListPost.Ehliyet, ListPost.DogumTarihi, ListPost.YabanciDil, ListPost.egitimDurumu.ElementAt(0)[0], ListPost.egitimDurumu.ElementAt(0)[1], ListPost.egitimDurumu.ElementAt(0)[2], ListPost.egitimDurumu.ElementAt(0)[3], ListPost.egitimDurumu.ElementAt(0)[4], ListPost.isDeneyimi.ElementAt(0)[0], ListPost.isDeneyimi.ElementAt(0)[1], ListPost.isDeneyimi.ElementAt(0)[2], ListPost.isDeneyimi.ElementAt(0)[3]);

            }
            else
            {
                MessageBox.Show("aranan kisi mevcut degil");
            }
        }

        private void btnDeneyimsiz_Click(object sender, EventArgs e)
        {
            ListBoxSorgu.Items.Clear();
            tempListe.Clear();

            tempDosyaAdi = "Deneyimsizler.json";
            Form1.ikiliagac.İsdeneyimsizSorgu(Form1.ikiliagac.ReturnKok());
            foreach (Kisi ListPost in Form1.ikiliagac.İsdeneyimsiz)
            {
                ListBoxSorgu.Items.Add(ListPost.Ad + " " + ListPost.Soyad + " " + ListPost.isDeneyimi.ElementAt(0)[3]);
                tempListe.Add(ListPost);
            }
            Form1.ikiliagac.İsdeneyimsiz.Clear();
        }

        private void btnYas_Click(object sender, EventArgs e)
        {
            ListBoxSorgu.Items.Clear();
            tempListe.Clear();
            tempDosyaAdi = "Yas" + yastxt.Text + "ve alti.json";
            Form1.ikiliagac.YasSorgu(Form1.ikiliagac.ReturnKok(), yastxt.Text);
            foreach (Kisi ListPost in Form1.ikiliagac.yasSorguList)
            {
                ListBoxSorgu.Items.Add(ListPost.Ad + " " + ListPost.Soyad + " " + ListPost.DogumTarihi);
                tempListe.Add(ListPost);
            }
            Form1.ikiliagac.yasSorguList.Clear();

        }

        private void btnEhliyet_Click(object sender, EventArgs e)
        {
            ListBoxSorgu.Items.Clear();
            tempListe.Clear();
            tempDosyaAdi = "Ehliyet  " + ehliyettxt.Text + "olanlar.json";
            Form1.ikiliagac.ehliyetbul(Form1.ikiliagac.ReturnKok(), ehliyettxt.Text);
           
            foreach (Kisi ListPost in Form1.ikiliagac.ehliyetshb)
            {
                ListBoxSorgu.Items.Add(ListPost.Ad + " " + ListPost.Soyad + " " + ListPost.Ehliyet);
                tempListe.Add(ListPost);
            }
            Form1.ikiliagac.ehliyetshb.Clear();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDosyaYaz_Click(object sender, EventArgs e)
        {
            JsonReadWrite.JsonYazmaSorgulanan(tempListe,tempDosyaAdi);
            MessageBox.Show("dosyayazılı");
        }
    }
}
