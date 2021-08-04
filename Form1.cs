using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaimeMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database dbObject = new Database();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellerForm seller = new sellerForm();
            seller.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addItemForm itemForm = new addItemForm();
            itemForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ma5znForm m5zn = new ma5znForm();
            m5zn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mabe3atForm mabe3at = new mabe3atForm();
            mabe3at.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "youssef")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
                textBox1.Enabled = false;
            }
            textBox1.Clear();
        }
    }
}
