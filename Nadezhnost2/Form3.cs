using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nadezhnost2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N, i, C, t,P,lambd;
            N = Convert.ToDouble(textBox1.Text);
            i = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);
            t = Convert.ToDouble(textBox4.Text);
            lambd = C * (N - i + 1);
            P = lambd * Math.Exp(lambd * (-1) * t);
            textBox5.Text = Convert.ToString(P);
          

            double a=0, b=25, h=0.01, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while(x<=b)
            {
                lambd = C * (N - i + 1);
                y = (lambd * Math.Exp(lambd * (-1) * x));
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
                
            }
            pictureBox1.Image = Properties.Resources.jpg;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N, i, C, t, P, lambd;
            string q = File.ReadLines(Convert.ToString(textBox6.Text)).Skip(0).First();
            string w = File.ReadLines(Convert.ToString(textBox6.Text)).Skip(1).First();
            string p = File.ReadLines(Convert.ToString(textBox6.Text)).Skip(2).First();
            string r = File.ReadLines(Convert.ToString(textBox6.Text)).Skip(3).First();
             N= Convert.ToDouble(q);
            i = Convert.ToDouble(w);
            C = Convert.ToDouble(p);
           t = Convert.ToDouble(r);
            textBox1.Text = q;
            textBox2.Text = w;
            textBox3.Text = p;
            textBox4.Text = r;

            lambd = C * (N - i + 1);
            P = lambd * Math.Exp(lambd * (-1) * t);
            textBox5.Text = Convert.ToString(P);


            double a = 0, b = 25, h = 0.01, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                lambd = C * (N - i + 1);
                y = (lambd * Math.Exp(lambd * (-1) * x));
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;

            }
            pictureBox1.Image = Properties.Resources.jpg;

        }
    }
}
