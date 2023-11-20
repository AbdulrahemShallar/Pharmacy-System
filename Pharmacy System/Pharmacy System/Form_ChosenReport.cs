using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Form_ChosenReport : Form
    {
        public Form_ChosenReport()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Billing_Movement");
            form_Report.ShowDialog();
        }

        private void Item_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_Movement_Synthesis");
            form_Report.ShowDialog();
        }

        private void ItemGain_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_Profits_Collective");
            form_Report.ShowDialog();
        }

        private void ItemStrip_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_inventory");
            form_Report.ShowDialog();
        }

        private void ItemWarrant_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_validity");
            form_Report.ShowDialog();
        }

        private void ItemShot_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Damaged_items");
            form_Report.ShowDialog();
        }

        private void Journal_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Journal");
            form_Report.ShowDialog();
        }

        private void Account_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Account_balances");
            form_Report.ShowDialog();
        }

        private void AccountExpose_button_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Account_statement");
            form_Report.ShowDialog();
        }
    }
}
