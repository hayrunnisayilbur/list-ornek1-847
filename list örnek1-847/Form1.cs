using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_örnek1_847
{
    public partial class Form1 : Form
    {
        List<int> sayilar = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            sayilar.Add(sayi);

            lbSayilar.DataSource = sayilar.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayilar = new List<int>(); // yeni bir liste oluşturduk

            

            lbSayilar.DataSource = sayilar;
        }
    }
}
