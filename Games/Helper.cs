using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public class Helper
    {
        /// <summary>
        /// 0 ile 6 arasında üretilmiş olan değerler unique olacak sekilde randomd eğer üreten metot
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Görsellerin farklı sırada üretilmesini sağlayan metot
        /// </summary>
        /// <returns></returns>
        public List<string> UcCiftFotografUret()
        {
            List<string> yeniListe = new List<string>();
            List<string> fotolar = new List<string>() { "bear.png", "bear.png", "bunny.png", "bunny.png", "cat.png", "cat.png" };
            var liste = RandomDegerUret();
            for (int i = 0; i < 6; i++)
            {
                yeniListe.Add(fotolar[liste[i]]);
            }
            return yeniListe;
        }


        //üretilmiş random fotograf listesi var, bu fotografların her birisinin sırayla ekrandaki buttonlara atayalım.

        //parametre olarak UcCiftFotografUret metodundan üretilmiş olan listeyi alan, buttonlarda tek tek dönen ve listenin sırayla elemanlarını buttonlara atayan metodu yazınız.

        public void ButtonlaraRandomFotografAta(List<Button> buttonlar, List<string> liste)
        {
            for (int i = 0; i < buttonlar.Count; i++)
            {
                buttonlar[i].Tag = liste[i];
                //buttonlar[i].BackgroundImage = Image.FromFile("images//" + liste[i]);
                buttonlar[i].BackgroundImage=null;
                buttonlar[i].BackgroundImageLayout = ImageLayout.Stretch;
                buttonlar[i].Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                string deger = btn.Tag.ToString();
                btn.Text = deger;
            }
        }

    }
}
