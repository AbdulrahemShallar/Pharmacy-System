using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.UserControls
{
    public partial class UserControl_CasherItem : UserControl 
    {
        private string textLabel1 = "";
        private Image picterBox;
        public string button_name = "btn";
        public UserControl_CasherItem()
        {
            InitializeComponent();
        }
        [Category("TextLabel1"), DisplayName("Text Label1")]
        public string TextLabel1
        {
            get
            {
                return textLabel1;
            }
            set
            {
                if (textLabel1 == value) return;
                textLabel1 = value;

                Invalidate();
                bunifuFlatButton1.Text = textLabel1;
            }
        }
        [Category("PicterBox"), DisplayName("Picter Box")]
        public Image PicterBox
        {
            get
            {
                return picterBox;
            }
            set
            {
                if (picterBox == value) return;
                picterBox = value;

                Invalidate();
                bunifuFlatButton1.Iconimage = picterBox;
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            button_name = this.Name;
        }
        
    }
}
