using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGItTest
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlexForm f1 = new AlexForm();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RyanForm f2 = new RyanForm();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JoshForm f3 = new JoshForm();
            f3.ShowDialog();
        }
    }
}
