using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriyapilariproje
{
    class Kullanici
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string YabanciDil { get; set; }
        public string Ehliyet { get; set; }

       
        public LinkedList<List<string>> egitimDurum = new LinkedList<List<string>>();
        public LinkedList<List<string>> isdurum = new LinkedList<List<string>>();
        
       
       
        

        public Kullanici()
        {           
        }
        public void egitimDurumuEkle(List<string>  egtm)
        {
            egitimDurum.AddLast(egtm);
        }
        public void isDurumuEkle(List<string> isd)
        {
            isdurum.AddLast(isd);
        }

    }
}
