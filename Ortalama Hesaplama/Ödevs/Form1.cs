using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödevs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yazili1, yazili2, sozlu,ort;
            yazili1 = Convert.ToDouble(textBox1.Text);
            yazili2 = Convert.ToDouble(textBox2.Text);
            sozlu = Convert.ToDouble(textBox3.Text);
            ort = Convert.ToDouble(yazili1 + yazili2 + sozlu) / 3;
            label6.Text =Convert.ToString (ort);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
