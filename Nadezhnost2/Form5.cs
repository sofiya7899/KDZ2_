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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //закидываем все элементы в один текст
            int i;
            for (i = 0; i <= 3; i++)
            {
                string z = File.ReadLines(Convert.ToString(textBox2.Text)).Skip(i).First();
                textBox1.Text += z;
            }
            string text = (textBox1.Text);

            // разделяем все на слова по пробелам
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in words)
            {
                listBox1.Items.Add(s);
            }

            string[] alloperators = { "int", "double", "float", "var", "string", "+", "-", "=", "*", "/", ";", "," };                    
            //ищем операторы из всех слов, сравнивая с массивом данных операторов
          
            for (int k = 0; k < words.Length; k++)
                for (int j = 0; j < alloperators.Length; j++)
                {
                    if (words[k] == alloperators[j])
                        listBox2.Items.Add(words[k]);
                                          
          }       
            //кидаем операторов в массив и считаем
            string[] operators = new string[0];
            operators = new string[listBox2.Items.Count];
            int countallopers = 0;
            for (int u = 0; u < listBox2.Items.Count; u++)
            {
                operators[u] = listBox2.Items[u].ToString();
                countallopers++;
            }
            //считаем операнды
            
            int g = 0, h = 0;

            for (int k = 0; k < words.Length; k++)
            {
                for (int j = 0; j < alloperators.Length; j++)
                {
                    if (words[k] == alloperators[j])
                    g++;

                }
                if (g == h) listBox3.Items.Add(words[k]);
                else h++;
            }

            string[] operands = new string[0];
            operands = new string[listBox3.Items.Count];
            int countalloperands = 0;
            for (int u = 0; u < listBox3.Items.Count; u++)
            {
                operands[u] = listBox3.Items[u].ToString();
                countalloperands++;
            }


              textBox3.Text = Convert.ToString(countallopers);
              textBox4.Text = Convert.ToString(countalloperands);

              //ищем уникальные
             string[] uniqopers = operators.Distinct().ToArray();
              int countuniq1 = 0, countuniq2 = 0;
              foreach (string y in uniqopers)
              {
                  listBox4.Items.Add(y);
                  countuniq1++;
              }
              string[] uniqoperands = operands.Distinct().ToArray();
              foreach (string r in uniqoperands)
              {
                  listBox5.Items.Add(r);
                  countuniq2++;
              }

              textBox5.Text = Convert.ToString(countuniq1);
              textBox6.Text = Convert.ToString(countuniq2);
              //сам расчёт
              double n,N,V,d,D,p,E,B;
              n = countuniq1 + countuniq2;
              N = countallopers + countalloperands;
              V = N * Math.Log(n, 2);
               d = 2*countuniq2;
              p = countuniq1 * countalloperands;
              D = d / p;
              E = D / V;
              B = (E * 0.667) / 3000;
              label10.Text += Convert.ToString(N);
              label11.Text += Convert.ToString(V);
              label12.Text += Convert.ToString(D);
              label13.Text += Convert.ToString(E);
              label14.Text += Convert.ToString(B);
            

   








        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
