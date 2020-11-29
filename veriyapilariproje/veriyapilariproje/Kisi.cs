using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriyapilariproje
{
    [Serializable()]
    public class Kisi
    {
       
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string TelNo { get; set; }                   
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }     
        public string YabanciDil { get; set; }
        public string Ehliyet { get; set; }

          public LinkedList<List<string>> egitimDurumu = new LinkedList<List<string>>();
        public LinkedList<List<string>> isDeneyimi = new LinkedList<List<string>>();
      
      
       
        public Kisi()
        {



        }
        public void egitimDurumuEkle(List<string> egtm)
        {
            egitimDurumu.AddLast(egtm);
        }
        public void isDeneyimiEkle(List<string> isDnym)
        {
            isDeneyimi.AddLast(isDnym);
        }
        
    }
}
