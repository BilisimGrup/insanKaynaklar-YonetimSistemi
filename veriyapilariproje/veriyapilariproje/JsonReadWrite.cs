using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace veriyapilariproje
{
    class JsonReadWrite
    {

        public static List<Kullanici> Kullaniciler = new List<Kullanici>();

        // var olan Json doyasından okuma
        public void JsonOkuma()
        {
            string JsonOkunanData = File.ReadAllText(@"C:\JsonIslemlerim\Kullaniciler.json");
            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);

            foreach (var item in okunanJson)
            {
                Console.WriteLine("ID : " + item.ID);

                Console.WriteLine();
            }


        }
        // json dosyasına veri girişi 
        public void JsonYazma()
        {
            Console.WriteLine(@"Bilgileriniz Json Formatında D:\JsonIslemlerim\Kullaniciler.json olarak kayıt edilecektir.");

            if (Directory.Exists(@"C:\JsonIslemlerim\"))
            {
                // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
            }
            else
            {
                Directory.CreateDirectory(@"C:\JsonIslemlerim\");
            }

            string JsonKullaniciler = Newtonsoft.Json.JsonConvert.SerializeObject(Kullaniciler);
            File.WriteAllText(@"C:\JsonIslemlerim\Kullaniciler.json", JsonKullaniciler);

            Console.WriteLine("Json Export işlemi tamamlandı");

        }
        public static void JsonYazmaSorgulanan(List<Kisi> gelenSorgu,string dosyaAdi )
        {
            List<Kisi> tempKisi = new List<Kisi>();
            tempKisi = gelenSorgu;

            if (Directory.Exists(@"C:\JsonIslemlerim\"))
            {
                // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
            }
            else
            {
                Directory.CreateDirectory(@"C:\JsonIslemlerim\");
            }

            string JsonKullaniciler = Newtonsoft.Json.JsonConvert.SerializeObject(tempKisi);
            File.WriteAllText(@"C:\JsonIslemlerim\"+dosyaAdi, JsonKullaniciler);

           

        }

        // json dosyasından agac içerisine yazma fonksiyonu
        public static void JsonToTree()
        {

            if (Directory.Exists(@"C:\JsonIslemlerim\"))
            {
                // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
            }
            else
            {
                Directory.CreateDirectory(@"C:\JsonIslemlerim\");
               
            }
            string JsonOkunanData = File.ReadAllText(@"C:\JsonIslemlerim\Kullaniciler.json");
            List<Kullanici> okunanJson = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonOkunanData);
           
            
            
                foreach (var item in okunanJson)
                { 
                    Kisi kisi = new Kisi();
                    kisi.Ad = item.Ad;
                    kisi.Soyad = item.Soyad;
                    kisi.TelNo = item.TelNo;
                    kisi.Eposta = item.Eposta;
                    kisi.YabanciDil = item.YabanciDil;
                    kisi.Ehliyet = item.Ehliyet;
                    kisi.DogumTarihi = item.DogumTarihi;
                    kisi.Adres = item.Adres;
                    kisi.egitimDurumu = item.egitimDurum;
                    kisi.isDeneyimi = item.isdurum;

                    Form1.ikiliagac.Ekle(kisi);

                }

            
           

            

         


        }
        // agaç içindeki verileri Json dosyasına yazma metodu
        public static void TreeToJson(Kisi gelenKisi)
        {
            Kullanici k1 = new Kullanici();
            k1.ID = Guid.NewGuid();
            k1.Ad = gelenKisi.Ad;
            k1.Soyad = gelenKisi.Soyad;
            k1.Eposta = gelenKisi.Eposta;
            k1.TelNo = gelenKisi.TelNo;
            k1.Adres = gelenKisi.Adres;
            k1.DogumTarihi = gelenKisi.DogumTarihi;
            k1.YabanciDil = gelenKisi.YabanciDil;
            k1.Ehliyet = gelenKisi.Ehliyet;
            k1.egitimDurum = gelenKisi.egitimDurumu;
            k1.isdurum = gelenKisi.isDeneyimi;

           

            // Kullaniciler.InsertLast(k1);
            Kullaniciler.Add(k1);
            //Console.WriteLine(@"Bilgileriniz Json Formatında D:\JsonIslemlerim\Kullaniciler.json olarak kayıt edilecektir.");

            if (Directory.Exists(@"C:\JsonIslemlerim\"))
            {
                // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
            }
            else
            {
                Directory.CreateDirectory(@"C:\JsonIslemlerim\");
            }

            string JsonKullaniciler = Newtonsoft.Json.JsonConvert.SerializeObject(Kullaniciler);
            File.WriteAllText(@"C:\JsonIslemlerim\Kullaniciler.json", JsonKullaniciler);

            

            //Agac içerisindeki dugum dönür çalıştıgında her dügüm de TreeToJson metodu çalışacak böylece tüm veriler agaçtan json dosyasına aktarılacak 
            /* 
              //dosyaya yazmak için kullanılacak agaç yapısı içinde olacak metot
            public int DugumDondur(İkiliAramaAgacDugumu dugum)
            {
                int count = 0;
                Kisi kisiyaz = new Kisi();
          

                if (dugum != null)
                {  
                    kisiyaz = dugum.veri;
                   Program.TreeToJson(kisiyaz);
                    count = 1;
                    count += DugumDondur(dugum.sol);
                    count += DugumDondur(dugum.sag);
                }
                return count;
            }                       
             
             */
        }



    }
}
