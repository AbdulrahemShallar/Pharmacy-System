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
    public partial class Form_User : Form
    {
        public Form_User(string FaceName)
        {
            InitializeComponent();
            switch (FaceName)
            {
                case "UserControl": get_UserControl();break;
                case "BackUPData": get_BackUPData();break;
            }
           
        }
        private void get_UserControl()
        {
            pnl_Fill.Controls.Clear();
            if (!pnl_Fill.Controls.Contains(UserControls.UserControls.Instance))
            {
                pnl_Fill.Controls.Add(UserControls.UserControls.Instance);
                UserControls.UserControls.Instance.Dock = DockStyle.Right;
                UserControls.UserControls.Instance.BringToFront();
            }
        }
        private void get_BackUPData()
        {
            pnl_Fill.Controls.Clear();
            if (!pnl_Fill.Controls.Contains(UserControls.BackUpDate.Instance))
            {
                pnl_Fill.Controls.Add(UserControls.BackUpDate.Instance);
                UserControls.BackUpDate.Instance.Dock = DockStyle.Right;
                UserControls.BackUpDate.Instance.BringToFront();
            }
        }
    }
}
