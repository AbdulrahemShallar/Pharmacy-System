using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_System.UserControls
{
    public partial class Get_User : UserControl
    {

        private static Get_User _instance;
        public static Get_User Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Get_User();
                return _instance;
            }
        }
        public Get_User()
        {
            InitializeComponent();
        }

        private void Get_User_Load(object sender, EventArgs e)
        {
            cb_UserType.Text = txt_UserName.Text = txt_Password.Text = "";
            cb_UserType.Focus();
        }

        private void Btn_Cansole_Click(object sender, EventArgs e)
        {
            UserControls.Instance.id = -1;
            ((Form)this.TopLevelControl).Close();
        }

        private void Btn_Serch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Class_Connection.con))
                { 
                    SqlDataAdapter da = new SqlDataAdapter("select ID from [User] where Name='" + txt_UserName.Text + "' and User_Type='" + cb_UserType.Text + "' and Password='" + txt_Password.Text + "' and [Enable] = '" + UserControls.Instance.EnabelState+"'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0]["Id"].ToString() != "")
                    {
                        UserControls.Instance.id = int.Parse(dt.Rows[0]["Id"].ToString());//تمرير قيمة ال اي دي للفورم الخاص بلمستخمين للتعديل او الإضافة
                        Btn_Close_Click(sender, e);
                    }
                }
            }
            catch
            {
                MessageBox.Show("الرجاء التئكد من نوع المستخدم وإسمه وكلمة المرور الخاصة به ؟؟", "بيانات غير صحيحية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)// اذا ضغط المستخدم على زر enterسوف ينتقل للحقل التالي 
                SendKeys.Send("{tab}");// نفذ تعليمة الindix
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
