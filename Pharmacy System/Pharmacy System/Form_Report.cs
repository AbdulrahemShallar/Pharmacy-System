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
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();

        }
        public Form_Report(String FaceName)
        {
            InitializeComponent();
            switch (FaceName)
            {
                case "UserControl_Billing_Movement": Billing(); break;
                case "UserControl_Material_Movement_Synthesis": Material(); break;
                case "UserControl_Material_Profits_Collective": Material_Profits(); break;
                case "UserControl_Material_inventory": Material_inventory(); break;
                case "UserControl_Material_validity": Material_validity(); break;
                case "UserControl_Damaged_items": Damaged_items(); break;
                case "UserControl_Journal": Journal(); break;
                case "UserControl_Account_balances":Account_balances();break;
                case "UserControl_Account_statement":Account_statement();break;
                case "UserControl_Profit_and_loss":Profit_and_loss();break;

            }
        }
        public Form_Report (string FaceName,String Value)
        {
            InitializeComponent();
            switch (FaceName)
            {
                case "UserControl_FromSerchAccount": From_SerchAccount(Value); break;
                case "UserControl_FormSerchItem": From_SerchItem(Value); break;
            }
        }

        private void Billing()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Billing_Movement.Instance))
            {
                Report.UserControl_Billing_Movement.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Billing_Movement.Instance);
                Report.UserControl_Billing_Movement.Instance.Dock = DockStyle.Right;
                Report.UserControl_Billing_Movement.Instance.BringToFront();
            }
        }
        private void Material()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Material_Movement_Synthesis.Instance))
            {
                Report.UserControl_Material_Movement_Synthesis.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Material_Movement_Synthesis.Instance);
                Report.UserControl_Material_Movement_Synthesis.Instance.Dock = DockStyle.Right;
                Report.UserControl_Material_Movement_Synthesis.Instance.BringToFront();
            }
        }
        private void Material_Profits()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Material_Profits_Collective.Instance))
            {
                Report.UserControl_Material_Profits_Collective.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Material_Profits_Collective.Instance);
                Report.UserControl_Material_Profits_Collective.Instance.Dock = DockStyle.Right;
                Report.UserControl_Material_Profits_Collective.Instance.BringToFront();
            }
        }
        private void Material_inventory()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Material_inventory.Instance))
            {
                Report.UserControl_Material_inventory.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Material_inventory.Instance);
                Report.UserControl_Material_inventory.Instance.Dock = DockStyle.Right;
                Report.UserControl_Material_inventory.Instance.BringToFront();
            }
        }
        private void Material_validity()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Material_validity.Instance))
            {
                Report.UserControl_Material_validity.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Material_validity.Instance);
                Report.UserControl_Material_validity.Instance.Dock = DockStyle.Right;
                Report.UserControl_Material_validity.Instance.BringToFront();
            }
        }
        private void Damaged_items()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Damaged_items.Instance))
            {
                Report.UserControl_Damaged_items.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Damaged_items.Instance);
                Report.UserControl_Damaged_items.Instance.Dock = DockStyle.Right;
                Report.UserControl_Damaged_items.Instance.BringToFront();
            }
        }
        private void Journal()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Damaged_items.Instance))
            {
                Report.UserControl_Journal.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Journal.Instance);
                Report.UserControl_Journal.Instance.Dock = DockStyle.Right;
                Report.UserControl_Journal.Instance.BringToFront();
            }
        }
        private void Account_balances()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Account_balances.Instance))
            {
                Report.UserControl_Account_balances.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Account_balances.Instance);
                Report.UserControl_Account_balances.Instance.Dock = DockStyle.Right;
                Report.UserControl_Account_balances.Instance.BringToFront();
            }
        }
        private void Account_statement()
        {
                 Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Account_statement.Instance))
            {
                Report.UserControl_Account_statement.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Account_statement.Instance);
                Report.UserControl_Account_statement.Instance.Dock = DockStyle.Right;
                Report.UserControl_Account_statement.Instance.BringToFront();
            }
        }
        private void Profit_and_loss()
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Profit_and_loss.Instance))
            {
                Report.UserControl_Profit_and_loss.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Profit_and_loss.Instance);
                Report.UserControl_Profit_and_loss.Instance.Dock = DockStyle.Right;
                Report.UserControl_Profit_and_loss.Instance.BringToFront();
            }
        }
        private void From_SerchAccount(string value)
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Account_statement.Instance))
            {
                Report.UserControl_Account_statement.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Account_statement.Instance);
                Report.UserControl_Account_statement.Instance.Dock = DockStyle.Right;
                Report.UserControl_Account_statement.Instance.BringToFront();
                Report.UserControl_Account_statement.Instance.GetAccountFromSerch(value);
            }
        }
        private void From_SerchItem(string value)
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(Report.UserControl_Material_inventory.Instance))
            {
                Report.UserControl_Material_inventory.Instance.Clear();
                Fill_panel.Controls.Add(Report.UserControl_Material_inventory.Instance);
                Report.UserControl_Material_inventory.Instance.Dock = DockStyle.Right;
                Report.UserControl_Material_inventory.Instance.BringToFront();
                Report.UserControl_Material_inventory.Instance.GetItemFromSerch(value);
            }
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
