using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotrudniki frm = new Sotrudniki();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fond frm = new Fond();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Neiyavki frm = new Neiyavki();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ved_N frm = new Ved_N();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ved_F frm = new Ved_F();
            frm.ShowDialog();
        }
    }
}
