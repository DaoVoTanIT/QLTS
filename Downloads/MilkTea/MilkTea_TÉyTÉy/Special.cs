using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_TâyTây
{
    public partial class Special : Form
    {
        public Special()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void btnMon1_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }
    }
}
