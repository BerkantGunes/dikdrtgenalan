using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdrtgenalan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa = Convert.ToInt32(txtKisa.Text);
            int uzun = Convert.ToInt32(txtUzun.Text);
            int alan = kisa * uzun;
            int cevre = 2 * (kisa + uzun);
            label3.Text = "Cevre: " + cevre;
            label4.Text = "Alan: " + alan;
        }
    }
}
