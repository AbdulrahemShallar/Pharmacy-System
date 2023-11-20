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
    public partial class Form_Replay : Form
    {
        public Form_Replay()
        {
            InitializeComponent();
        }
        public Form_Replay(string UserControlName,string[] args)
        {
            InitializeComponent();
            switch (UserControlName)
            {
                case "StoreName": StoreName(args[0]);break;
            }
        }
        private void StoreName(string store_name)
        {
            Fill_panel.Controls.Clear();
            if (!Fill_panel.Controls.Contains(UserControls.TestStoreName_UserControl.Instance))
            {
                UserControls.TestStoreName_UserControl.Instance.Clear();
                Fill_panel.Controls.Add(UserControls.TestStoreName_UserControl.Instance);
                UserControls.TestStoreName_UserControl.Instance.Dock = DockStyle.Right;
                UserControls.TestStoreName_UserControl.Instance.BringToFront();
                UserControls.TestStoreName_UserControl.Instance.getStoreName(store_name);
            }
        }
    }
}
