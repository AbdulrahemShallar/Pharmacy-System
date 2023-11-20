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
    public partial class BackUpDate : UserControl
    {
        private static BackUpDate _instance;
        public static BackUpDate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BackUpDate();
                return _instance;
            }
        }
        public BackUpDate()
        {
            InitializeComponent();
        }

        private void Btn__Create_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Class_Connection.con);
                SqlCommand com;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup Files (*.Bak ) |*.bak";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    con.Open();
                    com = new SqlCommand("Backup Database pharmacy To Disk='" + sf.FileName + "' ", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم انشاء نسخة احتياطية بنجاح \n في المسار" + sf.FileName, "نجت المهمة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException xx)
            {
                MessageBox.Show(" لا يمكن انشاء نسخة احتياطية يجب كتابة اسم النسخة والإمتداد " + xx.Message, "فشل المهمة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Class_Connection.con);
                SqlCommand com;
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Backup Files (*.Bak ) |*.bak";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    con.Open();
                    SqlCommand com1 = new SqlCommand("drop Database pharmacy", con);
                    com1.ExecuteNonQuery();
                    com = new SqlCommand("Restore Database pharmacy From Disk='" + of.FileName + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح \n في المسار" + of.FileName, "نجت المهمة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException xx)
            {
                MessageBox.Show("لا يمكن استرجاع البيانات بسبب " + xx.Message, "فشل المهمة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BackUpDate_Load(object sender, EventArgs e)
        {
            Console.Beep();
            btn__Create.Focus();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
