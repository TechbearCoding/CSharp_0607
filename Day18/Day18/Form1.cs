using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day18
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random random = new Random();
        List<int> Numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCounter_Click(object sender, EventArgs e)
        {
            //count++; 
            //lblRes.Text = count.ToString();
            //lblRes.Text = Convert.ToString(Convert.ToInt32(lblRes.Text) +1 );
            String result = "";

            /*(for (int i = 0; i < Numbers.Count; i++)
            {
                Numbers.Add(random.Next(1, 10));
                result += Convert.ToString(Numbers[i]);
            }
            lblA.Text = result;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homework();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt32(textBox2.Text);
            lblA.Text = choice.ToString();
            lblB.Text = Convert.ToString(Numbers[choice]);
        }

        private void Task1()
        {

            int a = Convert.ToInt32(textBox1.Text);
            String result = "";
            for (int i = 0; i < a; i++)
            {
                Numbers.Add(random.Next(1, 10));
                result = result + Convert.ToString(Numbers[i] + " ");
            }
            lblA.Text = result;
        }

        private void Homework()
        {
            int number = Convert.ToInt32(textBox1.Text);
            Numbers.Add(number);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < Numbers.Count; i++)
            {
                sum += Numbers[i];
            }
            lblA.Text = (sum / Numbers.Count).ToString();
        }
    }
}
