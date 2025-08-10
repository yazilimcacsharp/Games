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
    public partial class SureSec : Form
    {
        public SureSec()
        {
            InitializeComponent();
        }

        string sure;
        private void button1_Click(object sender, EventArgs e)
        {
            sure=(Convert.ToInt32(textBox1.Text)*1000).ToString();;

            HafizaOyunu hafizaOyunu=new HafizaOyunu(sure);
            hafizaOyunu.ShowDialog();
        }
    }
}
