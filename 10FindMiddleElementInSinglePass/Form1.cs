using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10FindMiddleElementInSinglePass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindMiddle x = new FindMiddle(textBox1.Text.Split(','));
            label2.Text = x.getMiddle();
        }
    }
}
