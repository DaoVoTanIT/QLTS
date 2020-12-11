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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MenuMilktea();
        }
        void MenuMilktea()
        {
            MilkTea mt = new MilkTea();
            mt.TopLevel = false;
            pnCategory.Controls.Clear();
            pnCategory.Controls.Add(mt);
            mt.FormBorderStyle = FormBorderStyle.None;
            mt.Dock = DockStyle.Fill;
            mt.Show();
        }
        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            MilkTea mt = new MilkTea();
            mt.TopLevel = false;
            pnCategory.Controls.Clear();
            pnCategory.Controls.Add(mt);
            mt.FormBorderStyle = FormBorderStyle.None;
            mt.Dock = DockStyle.Fill;
            mt.Show();
        }

        private void btnGreentea_Click(object sender, EventArgs e)
        {
            Special gt = new Special();
            gt.TopLevel = false;
            pnCategory.Controls.Clear();
            pnCategory.Controls.Add(gt);
            gt.FormBorderStyle = FormBorderStyle.None;
            gt.Dock = DockStyle.Fill;
            gt.Show();
        }

        private void btnFreshMilk_Click(object sender, EventArgs e)
        {
            FreshMilk fm = new FreshMilk();
            fm.TopLevel = false;
            pnCategory.Controls.Clear();
            pnCategory.Controls.Add(fm);
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }
    }
}
