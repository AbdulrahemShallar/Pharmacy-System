using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Form_ReferenceCalculattion : Form
    {
        string messageEmpty, textMessageOk, textMessageNo, textMessageFound;
        public Form_ReferenceCalculattion()
        {
            InitializeComponent();
        }
        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > ((int)Keys.D0) - 1) && (e.KeyChar < ((int)Keys.D9) + 1) || (e.KeyChar == (int)Keys.Back))
            {
                return;
            }
            e.Handled = true;
            if (e.KeyChar == 13)
                SendKeys.Send("{tab}");
        }
        public Form_ReferenceCalculattion(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag()) ;

        }
        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { ID_label,Name_label,LimitOFDebt_label,Note_label
            };
            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    this.RightToLeftLayout = false;
                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].RightToLeft = RightToLeft.Yes;
                    }
                   
                    
                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = LimitOFDebtValue_Textbox.RightToLeft =
                          NoteValue_Textbox.RightToLeft = RightToLeft.Yes;
                    ID_label.Text = "رقم المعرف :";
                    Name_label.Text = "الاسم : ";
                    LimitOFDebt_label.Text = "الحد الاعلى للدين :";
                    Note_label.Text = "ملاحظة :";
                    messageEmpty = "يجب ملئ جميع الصناديق لحفظ العملية بنجاح .";
                    textMessageOk = "تم الحفظ  بنجاح .";
                    textMessageNo = "لم يتم الحفظ .\nالرجاء التأكد من البيانات المدخلة .";
                    textMessageFound = "اسم الحساب موجود مسبقا ادخل اسم اخر.";
                    Save_button.Text = "حفظ";
                    Cansel_button.Text = "إلغاء";
                    break;
                case "إنكليزي":
                case "English":
                    this.RightToLeftLayout = true;
                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].RightToLeft = RightToLeft.No;
                    }
                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = LimitOFDebtValue_Textbox.RightToLeft =
                           NoteValue_Textbox.RightToLeft = RightToLeft.No;
                    ID_label.Text = "ID :";
                    Name_label.Text = "Name :";
                    LimitOFDebt_label.Text = "Limit Of Debt :";
                    Note_label.Text = "Note :";
                    messageEmpty = "All boxes must be filled to save the process successfully .";
                    textMessageOk = "successfully saved.";
                    textMessageNo = "not been saved.\nPlease check the data entered.";
                    textMessageFound = "Account Name is Founded Enter Deferent Name.";
                   Save_button.Text = "Save";
                    Cansel_button.Text = "Cansel";
                    break;
            }
        }
        private bool isAccountNameInList()
        {
                Class_Connection class_Connection = new Class_Connection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "isAccountNameInList";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
              return class_Connection.isAccountNameInList(sqlCommand: sqlCommand,textMessageFound: textMessageFound);  
        }

        private void Form_ReferenceCalculattion_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || NameValue_Textbox.Text == "" )
            {
                MessageBox.Show(messageEmpty, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Class_Connection class_Connection = new Class_Connection();
            if (isNotEmpty() && isAccountNameInList())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Add_Refernce_Calculation";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar,50).Value = NameValue_Textbox.Text;
                if (LimitOFDebtValue_Textbox.Text != "")
                    sqlCommand.Parameters.Add("@Limit_Of_Debt", SqlDbType.Float).Value = float.Parse(LimitOFDebtValue_Textbox.Text);
                else
                    sqlCommand.Parameters.Add("@Limit_Of_Debt", SqlDbType.Int).Value = 0;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = NoteValue_Textbox.Text;
                class_Connection.executeNonQuery(sqlCommand: sqlCommand, textMessageOk, textMessageNo);
                Clear();
            }
        }
        private void Clear()
        {
            NameValue_Textbox.Text = LimitOFDebtValue_Textbox.Text = NoteValue_Textbox.Text = "";  
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Refernce_Calculation");
        }
        private void Exit_Button_Click(object sender, EventArgs e) => this.Close();

        private void Minimaized_button_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
    }
}
