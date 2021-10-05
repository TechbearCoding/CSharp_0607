using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day19_homework
{
    public partial class Form1 : Form
    {
        List<String> Notes = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            AddElement(richTextBox1.Text);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            AddElement(richTextBox2.Text);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            AddElement(richTextBox3.Text);
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            DeleteElement(richTextBox1.Text);
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            DeleteElement(richTextBox2.Text);
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            DeleteElement(richTextBox3.Text);
        }

        private void AddElement(String txt)
        {
            if (txt != "" && Notes.Count != 3 && !IsPresent(txt))
            {
                Notes.Add(txt);
            }
            DisplayList();
        }


        private void DeleteElement(String txt)
        {
            Notes.RemoveAt(Notes.IndexOf(txt));
            DisplayList();
        }

        private void DisplayList()
        {
            listView1.Items.Clear();
            for (int i = 0; i < Notes.Count; i++)
            {
                listView1.Items.Add(Notes[i]);
            }
        }

        private bool IsPresent(String txt)
        {
            for(int i = 0; i < Notes.Count; i++)
            {
                if(Notes[i] == txt)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
