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
    public partial class MyMessgeBox : Form
    {
        public MyMessgeBox()
        {
            InitializeComponent();
        }
        public MyMessgeBox(string state)//باني يم من خلاله تمير إسم الواجهة لتحميل اليوزر الخاصة به
        {
            InitializeComponent();
            switch (state)
            {
                //case "uc_exit": uc_exit(); break;
                //case "uc_chooes_emp": uc_chooes(); UC_Chooes.Instance.lbl_Title1.Text = "الموظفين"; break;
                //case "uc_chooes_cahnge": uc_chooes(); UC_Chooes.Instance.lbl_Title1.Text = "التعيين"; break;
                //case "uc_Social_Life": uc_chooes(); UC_Chooes.Instance.lbl_Title1.Text = "الحياة الإجتماعية"; break;
                case "get_user": get_user(); break;
                //case "touct": touct_state(); break;
                //case "Barcode": Barcode(); break;
                //case "boll": boll(); break;
            }
        }
        public MyMessgeBox(string state, string name)
        {
            InitializeComponent();
            switch (state)
            {
                case "get_id": get_id(name); break;

            }
        }
        private void get_id(string name)//مسج تحميل ال اي دي لتمريره للفورم
        {
            pnl_Fill.Controls.Clear();
            if (!pnl_Fill.Controls.Contains(UserControls.Get_ID.Instance))
            {
                pnl_Fill.Controls.Add(UserControls.Get_ID.Instance);
                UserControls.Get_ID.Instance.Dock = DockStyle.Right;
                UserControls.Get_ID.Instance.BringToFront();
                UserControls.Get_ID.Instance.lbl_Title1.Text = name;
            }
        }
        private void get_user()//تحميل فورم جديد او تعديل او تفعيل او إلغاء تفعيل مستخدم
        {
            pnl_Fill.Controls.Clear();
            if (!pnl_Fill.Controls.Contains(UserControls.Get_User.Instance))
            {
                pnl_Fill.Controls.Add(UserControls.Get_User.Instance);
                UserControls.Get_User.Instance.Dock = DockStyle.Right;
                UserControls.Get_User.Instance.BringToFront();
            }
        }
    }
}
