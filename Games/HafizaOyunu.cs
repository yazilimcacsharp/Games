using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class HafizaOyunu : Form
    {
        private string timerSure;
        private string ilkTimerSure;
        public HafizaOyunu(string sure)
        {
            InitializeComponent();
            timerSure = sure;
            ilkTimerSure = sure;

        }

        private void HafizaOyunu_Load(object sender, EventArgs e)
        {
            //form üzerindeki son ayarlamaların yapıldığı yer.
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            label1.Text = "";
            ButtonOzellikleriniAyarla();

        }


        /// <summary>
        /// metodun yaptıgı iş buraya kodlanır.
        /// proje ilk çalıştıgında sayfada gözükecek buttonların görselleri, arka plan ayarlaması, genişlik-yükseklik bilgileri ve text kısmının temizlenmesi ayarlandı.
        /// </summary>
        private void ButtonOzellikleriniAyarla()
        {
            int sayac = 0; //kaçıncı button ekleniyorsa o bilgiyi tutacak değişkenin adı
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is Button btn) //item kontrolü eğer button ise
                {
                    btn.Text = "";
                    if (sayac % 2 == 0) //dönüşümlü olarak gelecek fotograf 2 tane oldugu için 2 sayısına göre mod aldık
                        btn.BackgroundImage = Image.FromFile("images//sarilogo.png");
                    else
                        btn.BackgroundImage = Image.FromFile("images//pinklogo.png");
                    //btn.BackColor=Color.Pink;

                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Width = 122;
                    btn.Height = 99;
                    sayac++;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Helper helper=new Helper();
            //var liste=helper.RandomDegerUret(); //buttonların sırasını verdi.


            Helper helper = new Helper();
            var fotoListesi = helper.UcCiftFotografUret();

            List<Button> buttonlar = new List<Button>();

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is Button b)
                {
                    buttonlar.Add(b);
                }
            }


            helper.ButtonlaraRandomFotografAta(buttonlar, fotoListesi);
        }

        int sure;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = int.Parse(timerSure) / 1000;
            sure--;

            label1.Text = "Süre: " + sure;
            timerSure = (sure * 1000).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int deger;
            deger = int.Parse(ilkTimerSure) / 1000;
            label1.Text = "Süre: " + deger;
        }
    }
}
