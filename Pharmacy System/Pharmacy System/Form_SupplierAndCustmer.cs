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
    public partial class Form_SupplierAndCustmer : Form
    {
        string messageEmpty, textMessageOk, textMessageNo, textMessageFound;
        public Form_SupplierAndCustmer()
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
        public Form_SupplierAndCustmer(Image image,string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag());
        }
        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { ID_label,Name_label,Company_label,Address_label,Phone_label,Mobile_label,Minmum_label,
                Warning_label,Emile_label,Note_label
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

                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = CompanyValue_Textbox.RightToLeft =
                        AddressValue_Textbox.RightToLeft = PhoneValue_Textbox.RightToLeft = MobileValue_Textbox.RightToLeft =
                        Maximum_Debt_LimitValue_Textbox.RightToLeft = WarningValue_Switch.RightToLeft =
                        EmailValue_Textbox.RightToLeft = NoteValue_Textbox.RightToLeft = RightToLeft.Yes;
                    ID_label.Text = "رقم المعرف :";
                    Name_label.Text = "الإسم :";
                    Company_label.Text = "الشركة :";
                    Address_label.Text = "العنوان : ";
                    Phone_label.Text = "هاتف : ";
                    Mobile_label.Text = "رقم موبايل : ";
                    Minmum_label.Text = "الحد الاعلى للدين: ";
                    Warning_label.Text = "تنبيه عند الوصول للحد الاعلى :";
                    Emile_label.Text = "بريد الكتروني :";
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
                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = CompanyValue_Textbox.RightToLeft =
                         AddressValue_Textbox.RightToLeft = PhoneValue_Textbox.RightToLeft = MobileValue_Textbox.RightToLeft =
                         Maximum_Debt_LimitValue_Textbox.RightToLeft = WarningValue_Switch.RightToLeft =                          EmailValue_Textbox.RightToLeft = NoteValue_Textbox.RightToLeft = RightToLeft.No;
                    ID_label.Text = "ID :";
                    Name_label.Text = "Name :";
                    Company_label.Text = "Company :";
                    Address_label.Text = "Address :";
                    Phone_label.Text = "Phone :";
                    Mobile_label.Text = "Mobile :";
                    Minmum_label.Text = "Minmum :";
                    Warning_label.Text = "Warning :";
                    Emile_label.Text = "Emile :";
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

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private bool isAccountNameInList()
        {
            Class_Connection class_Connection = new Class_Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "isAccountNameInList";
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
            return class_Connection.isAccountNameInList(sqlCommand: sqlCommand, textMessageFound: textMessageFound);
        }

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || NameValue_Textbox.Text == "")
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
                sqlCommand.CommandText = "Add_Supplier_Customer";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Company", SqlDbType.NVarChar , 50).Value = CompanyValue_Textbox.Text;
                if(Maximum_Debt_LimitValue_Textbox.Text != "")
                sqlCommand.Parameters.Add("@Maximum_Debt_Limit", SqlDbType.Float).Value = float.Parse(Maximum_Debt_LimitValue_Textbox.Text);
                else
                sqlCommand.Parameters.Add("@Maximum_Debt_Limit", SqlDbType.Float).Value = 0;
                sqlCommand.Parameters.Add("@Check_Max_Debt_Limt", SqlDbType.Real).Value = WarningValue_Switch.Value ; 
                sqlCommand.Parameters.Add("@Addres", SqlDbType.NVarChar, 100).Value = AddressValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = PhoneValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Mobile", SqlDbType.NVarChar, 50).Value = MobileValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 250).Value = EmailValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = NoteValue_Textbox.Text;
                if(Title_Label.Text == "Customer Card" || Title_Label.Text == "بطاقة زبون")
                sqlCommand.Parameters.Add("@Account_Type", SqlDbType.NVarChar, 50).Value = "Customer";
                else
                    sqlCommand.Parameters.Add("@Account_Type", SqlDbType.NVarChar, 50).Value = "Supplier";

                class_Connection.executeNonQuery(sqlCommand: sqlCommand, textMessageOk, textMessageNo);
                Clear();
            }
        }
        private void Clear()
        {
            NameValue_Textbox.Text = CompanyValue_Textbox.Text = Maximum_Debt_LimitValue_Textbox.Text =
                AddressValue_Textbox.Text = PhoneValue_Textbox.Text =MobileValue_Textbox.Text = EmailValue_Textbox.Text
                = NoteValue_Textbox.Text ="";
            WarningValue_Switch.Value = false;
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Supplier_Customer");
        }
        private void BunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_SupplierAndCustmer_Load(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
