using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class Helper
    {
        public List<int> RandomDegerUret()
        {
            //0 ile 6 arasında random değerler üretilecek ve bu değerler bir list<int> içerisine doldurulmalı, liste return ile geri döndürülmeli.

            //1.üretilen değer tekrar üretilmemeli.
            List<int> randomDegerler = new List<int>();
            Random rastgele = new Random();
            int uretilenDeger;
            for (int i = 0; i < 6; i++)
            {
                uretilenDeger = rastgele.Next(0, 6);
                if (!randomDegerler.Contains(uretilenDeger))
                {
                    randomDegerler.Add(uretilenDeger);
                }
                else
                {
                    i--;
                }
             
            }
            return randomDegerler;
        }

        //3 çift fotograf adlarını üreteecek metodu yazınız.. bear,cat,bunny,cat,bear,bunny(örnek)
        //List<string> fotograf isimlerini dönsün.
        public List<string> UcCiftFotografUret()
        {
            List<string> yeniListe=new List<string>();
            List<string> fotolar=new List<string>() { "bear.png","bear.png","bunny.png","bunny.png","cat.png","cat.png"};
            var liste=RandomDegerUret();
            for (int i = 0; i < 6; i++)
            {
                yeniListe.Add(fotolar[liste[i]]);
            }
            return yeniListe;
        }

    }
}
