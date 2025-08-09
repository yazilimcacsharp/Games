namespace Games
{
    public partial class SayiTahmin : Form
    {
        int pc, kullanici;
        int tahminAdet=0;
        public SayiTahmin()
        {
            InitializeComponent();
            Random random = new Random();
            pc = random.Next(1, 101);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            kullanici = int.Parse(textBox1.Text);
            tahminAdet++;
            if (kullanici == pc)
            {
                label2.Text = "Tebrikler"+tahminAdet+". hakkınızda bildiniz";
            }

            if (kullanici < pc)
            {
                label2.Text = "Lütfen daha büyük sayı giriniz";
            }

            if (pc < kullanici)
            {
                label2.Text = "Lütfen daha küçük sayı giriniz";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            label3.Text = "Süre: " + kalanSure;


            if (kalanSure == 0)
            {
                timer1.Stop();
                label3.Text = "Süre doldu! Oyun bitti:(";
                Application.Exit();
            }
        }
        int kalanSure = 30;
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Süre: " + kalanSure;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sağ alt tarafa bir textbox, bir label, bir button ekleyelim.
            //labelde Code yazsın
            //girilmiş olan labeldaki code bilgisi eğer RVTY ise bu durumda süreyi 10 saniye uzatsın.
            if (textBox2.Text == "RVTY")
            {
                kalanSure+=10;
                timer1_Tick(sender,e);
            }


        }
    }
}
