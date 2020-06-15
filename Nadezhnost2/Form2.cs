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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static double Fact(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }

      


        private void button1_Click(object sender, EventArgs e)
        {
            double N, S, K, v, n, a,b,C;
            S = Convert.ToDouble(textBox2.Text);
            n = Convert.ToDouble(textBox3.Text);
            v = Convert.ToDouble(textBox4.Text);
            K = Convert.ToDouble(textBox5.Text);
            N = (S * n) / v;
            textBox1.Text = Convert.ToString(N);
            a = (Fact(S)) / ((Fact(v - 1)) * Fact(S - v + 1));
            b = (Fact(S + K + 1)) / (Fact(v + K) * Fact(S + 1 - v));
            if (v<S)
            {
                C = a / b;
            }
            else
            {
                if (n>K)
                {
                    C = 1;
                }
                else
                {
                     C = v / (v + K + 1);
                }
            }
            string s = String.Format("{0:0.00}", C);
            textBox6.Text = Convert.ToString(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double S, v, K, n, N, C, r, t;
            string a = File.ReadLines(Convert.ToString(textBox7.Text)).Skip(0).First();
            string b = File.ReadLines(Convert.ToString(textBox7.Text)).Skip(1).First();
            string c = File.ReadLines(Convert.ToString(textBox7.Text)).Skip(2).First();
            string d = File.ReadLines(Convert.ToString(textBox7.Text)).Skip(3).First();
            S = Convert.ToDouble(a);
            n = Convert.ToDouble(b);
            v = Convert.ToDouble(c);
            K = Convert.ToDouble(d);
            textBox2.Text = a;
            textBox3.Text = b;
            textBox4.Text = c;
            textBox5.Text = d;

            N = (S * n) / v;
            textBox1.Text = Convert.ToString(N);
           r = (Fact(S)) / ((Fact(v - 1)) * Fact(S - v + 1));
            t = (Fact(S + K + 1)) / (Fact(v + K) * Fact(S + 1 - v));
            if (v < S)
            {
                C = r / t;
            }
            else
            {
                if (n > K)
                {
                    C = 1;
                }
                else
                {
                    C = v / (v + K + 1);
                }
            }
            string s = String.Format("{0:0.00}", C);
            textBox6.Text = Convert.ToString(s);


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
