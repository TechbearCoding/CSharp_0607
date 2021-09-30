using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day17_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(EditNumber1.Text);
                int b = Convert.ToInt32(EditNumber2.Text);

                int c = a + b;
                LblResult.Text = Convert.ToString(c);
            }
            catch
            {
                LblResult.Text = "Error!";
            }

        }
    }
}
