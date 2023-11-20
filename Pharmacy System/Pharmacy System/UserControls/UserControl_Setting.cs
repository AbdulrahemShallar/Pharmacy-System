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
    public partial class UserControl_Setting : UserControl
    {
        private Button[] buttons()
        {
            Button[] button = new Button[]
            {
                User_button, ShortCut_button,Reference_button
            };
            return button;
        }
        public UserControl_Setting()
        {
            InitializeComponent();
        }
        public void setSize()
        {
            Button[] button = buttons();
            for (int i = 0; i < button.Length; i++)
            {
                button[i].Size = new Size((this.Size.Width / 6), (this.Size.Height / 6));
                button[i].Font = new Font("Tajawal", button[i].Font.Size + 1.5f); ;
            }
        }
        private void AccountCard_button_Click(object sender, EventArgs e)
        {
            Form_User form_User = new Form_User("UserControl");
            form_User.ShowDialog();
        }

        private void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            setSize();
        }

        private void Reference_button_Click(object sender, EventArgs e)
        {
            
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "تم تفيعل تبيه الصلاحية سوف تظهر رسائل في حال اقتراب المواد من انتهاء صلاحيتها.";
            notifyIcon1.BalloonTipTitle = "تفيعل اختبار الصلاحية";
            notifyIcon1.ShowBalloonTip(12);
        }
    }
}
