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
        public HafizaOyunu()
        {
            InitializeComponent();
        }

        private void HafizaOyunu_Load(object sender, EventArgs e)
        {
            //form üzerindeki son ayarlamaların yapıldığı yer.
            ButtonOzellikleriniAyarla();
            //mola dönüşü 18.57
        }

        private void ButtonOzellikleriniAyarla()
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is Button btn)
                {
                    btn.Text = "";
                    //btn.BackColor=Color.Pink;
                    btn.BackgroundImage = Image.FromFile("images//logo.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Width = 122;
                    btn.Height = 99;
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Helper helper=new Helper();
            //var liste=helper.RandomDegerUret(); //buttonların sırasını verdi.


            Helper helper=new Helper();
            var fotoListesi=helper.UcCiftFotografUret();
        }
    }
}
