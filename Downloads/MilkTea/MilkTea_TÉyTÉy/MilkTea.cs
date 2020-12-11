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
    public partial class MilkTea : Form
    {
        public MilkTea()
        {
            InitializeComponent();
        }

        private void pnMilkTea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMon1_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void btnMon2_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void btnMon3_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void btnMon4_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void btnMon5_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }

        private void btnMon6_Click(object sender, EventArgs e)
        {
            DetailMilkTea dmt = new DetailMilkTea();
            Menu mt = new Menu();
            mt.Hide();
            dmt.ShowDialog();
        }
    }
}
