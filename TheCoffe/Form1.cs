using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.RP;

namespace TheCoffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Product mProduct = new Manage_Product();
            mProduct.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employye em = new Employye();
            em.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableOrder t = new TableOrder();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RPForm r = new RPForm();
            r.ShowDialog();
        }
    }
}
