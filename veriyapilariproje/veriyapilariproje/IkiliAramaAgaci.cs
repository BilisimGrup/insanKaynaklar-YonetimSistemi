using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  veriyapilariproje

{
    [Serializable()]
    public class IkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        private string dugumler;
        public IkiliAramaAgaci()
        {
        }
        public İkiliAramaAgacDugumu ReturnKok()
        {

            return kok;
        }
        public IkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DerinlikHesapla(İkiliAramaAgacDugumu dugum)
        {
            int yukseklik_sag = 0, yukselik_sol = 0;
            if (dugum != null)
            {
                yukseklik_sag = DerinlikHesapla(dugum.sag);
                yukselik_sol = DerinlikHesapla(dugum.sol);
                if (yukseklik_sag > yukselik_sol)
                {
                    return yukseklik_sag + 1;
                }
                else
                {
                    return yukselik_sol + 1;
                }
            }
            else
            {
                return 0;
            }
        }
        public int AgacDerinlikSayisi()
        {
            return DerinlikHesapla(kok);
        }

       

        public List<Kisi> dilBilen = new List<Kisi>();
        public void DilBul(İkiliAramaAgacDugumu dugum,string anahtar)
        {
           
            Kisi kisiyaz = new Kisi();


            if (dugum != null)
            {
                if (string.Compare((string)dugum.veri.YabanciDil, anahtar) == 0)
                {
                    dilBilen.Add(dugum.veri);
                }


                DilBul(dugum.sol, anahtar);
                DilBul(dugum.sag, anahtar);
            }
           
        }
        
        public List<Kisi> İsdeneyimiSorguList = new List<Kisi>();
        public void İsdeneyimiSorgu(İkiliAramaAgacDugumu dugum, string anahtar)
        {
           
            if (dugum != null)
            {
                int deneyim;
               string isyil= dugum.veri.isDeneyimi.ElementAt(0)[3].ToString();
                if(isyil=="")
                {
                    isyil = "0";
                }                   
                 deneyim = Convert.ToInt16(isyil);
                
                if(deneyim< Convert.ToInt16(anahtar)&& deneyim!=0)
                {
                İsdeneyimiSorguList.Add(dugum.veri);
                }


                İsdeneyimiSorgu(dugum.sol, anahtar);
                İsdeneyimiSorgu(dugum.sag, anahtar);
                
            }

        }
        public List<Kisi> İsdeneyimsiz= new List<Kisi>();
        public  void İsdeneyimsizSorgu(İkiliAramaAgacDugumu dugum)
        {

            if (dugum != null)
            {
               
                string isyil = dugum.veri.isDeneyimi.ElementAt(0)[3];
                

                if (isyil=="")
                {
                    İsdeneyimsiz.Add(dugum.veri);
                }


                İsdeneyimsizSorgu(dugum.sol);
                İsdeneyimsizSorgu(dugum.sag);
            }

        }

        public List<Kisi> TumKisiListe = new List<Kisi>();
        public void TumKisi(İkiliAramaAgacDugumu dugum )
        {

           
            if (dugum != null)
            {
                TumKisiListe.Add(dugum.veri);
                TumKisi(dugum.sol);
                TumKisi(dugum.sag);
            }

        }
        public List<Kisi> yasSorguList = new List<Kisi>();
        public void YasSorgu(İkiliAramaAgacDugumu dugum, string anahtar)
        {
            if (dugum != null)
            {

                int yas;
                

                int dogumyil = dugum.veri.DogumTarihi.Year;

                yas = DateTime.Now.Year - dogumyil;

                if (yas < Convert.ToInt16(anahtar))
                {

                    yasSorguList.Add(dugum.veri);
                }


                YasSorgu(dugum.sol, anahtar);
                YasSorgu(dugum.sag, anahtar);
            }
        }

        public List<Kisi> ehliyetshb = new List<Kisi>();
        public void ehliyetbul(İkiliAramaAgacDugumu dugum, string anahtar)
        {
            Kisi kisiyaz = new Kisi();
            if (dugum != null)
            {
                if (string.Compare((string)dugum.veri.Ehliyet, anahtar) == 0)
                {
                    ehliyetshb.Add(dugum.veri);
                }


                ehliyetbul(dugum.sol, anahtar);
                ehliyetbul(dugum.sag, anahtar);
            }
        }



        public List<Kisi> InOrderList = new List<Kisi>();
        public List<Kisi> PreOrderList = new List<Kisi>();
        public List<Kisi> PostOrderList = new List<Kisi>();
        
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            PreOrderList.Clear();
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            ZiyaretPreOrder(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            InOrderList.Clear();
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            ZiyaretInOrder(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {

            dugumler += dugum.veri + " ";
        }
        private void ZiyaretInOrder(İkiliAramaAgacDugumu dugum)
        {
            InOrderList.Add(dugum.veri);
            
        }
        private void ZiyaretPreOrder(İkiliAramaAgacDugumu dugum)
        {
            PreOrderList.Add(dugum.veri);

        }
        private void ZiyaretPostOrder(İkiliAramaAgacDugumu dugum)
        {
            PostOrderList.Add(dugum.veri);

        }
        public void PostOrder()
        {
            PostOrderList.Clear();
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            ZiyaretPostOrder(dugum);
        }
        public void BuyukKucuk()
        {
            dugumler = "";
            BuyukKucukInt(kok);

        }
        private void BuyukKucukInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            BuyukKucukInt(dugum.sag);
            Ziyaret(dugum);
            BuyukKucukInt(dugum.sol);
        }
        public void Ekle(Kisi deger)
        {
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;
            
            

            

            while (tempSearch != null)
            {
                tempParent = tempSearch;//bir önceki dugum yani aile
                if (string.Compare(deger.Ad,tempSearch.veri.Ad)==0)
                    return;
                else if (string.Compare(deger.Ad, tempSearch.veri.Ad) == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);

            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(deger.Ad, tempParent.veri.Ad) == -1)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;


        }
        public int DugumYaz(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            Kisi kisiyaz = new Kisi();


            if (dugum != null)
            {
                kisiyaz = dugum.veri;
                JsonReadWrite.TreeToJson(kisiyaz);
                count = 1;
                count += DugumYaz(dugum.sol);
                count += DugumYaz(dugum.sag);
            }
            return count;
        }

        
        public İkiliAramaAgacDugumu Ara(string anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum, string anahtar)

        {
            if (dugum == null)
                return null;
            else if (dugum.veri.Ad == anahtar)
                return dugum;
            else if (string.Compare(dugum.veri.Ad, anahtar) == -1)
                return (AraInt(dugum.sag, anahtar));
            else
                return (AraInt(dugum.sol, anahtar));
        }
        public İkiliAramaAgacDugumu MinDeger()
        {
            İkiliAramaAgacDugumu tempSol = kok;
            while (tempSol.sol != null)
                tempSol = tempSol.sol;
            return tempSol;
        }

        public İkiliAramaAgacDugumu MaksDeger()
        {
            İkiliAramaAgacDugumu tempSag = kok;
            while (tempSag.sag != null)
                tempSag = tempSag.sag;
            return tempSag;
        }

        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu successorParent = silDugum;
            İkiliAramaAgacDugumu successor = silDugum;
            İkiliAramaAgacDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;//currentin bir önceki değeri
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(string deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL current.veri != null
            while (current.veri.Ad.CompareTo(deger)!=0)
            {
                parent = current;
                if (string.Compare(deger, current.veri.Ad) == -1)
                {
                    issol = true;
                    current = current.sol;
                }
                else if (string.Compare(deger, current.veri.Ad)==1)
                {
                    issol = false;
                    current = current.sag;
                }

                if (current == null)
                    return false;


            }


            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }

    }
}
