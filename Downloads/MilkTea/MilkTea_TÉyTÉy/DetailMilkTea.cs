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
    public partial class DetailMilkTea : Form
    {
        public DetailMilkTea()
        {
            InitializeComponent();
            if (CheckConfirm(pnPercentSugar) == true && CheckConfirm(pnPercentIce) == true)
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DetailMilkTea_Load(object sender, EventArgs e)
        {
            if (CheckConfirm(pnPercentSugar) == true && CheckConfirm(pnPercentIce) == true)
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

    Boolean CheckConfirm(Panel pnl)
        {
            RadioButton ckb = null;
            foreach(RadioButton item in pnl.Controls )
            {
              if(item !=null)
                if(item.Checked)
                {
                        ckb = item;
                        break;
                }
            }
            if (ckb != null)
                return true;
          return false;
        }
    }
}
