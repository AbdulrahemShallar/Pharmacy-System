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
    public partial class Form_Store : Form
    {
        string messageEmpty, textMessageOk, textMessageNo , textMessageFounded;
        public Form_Store()
        {
            InitializeComponent();
        }
        public Form_Store(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag()) ;

        }
        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { ID_label,StoreName_label,Note_label
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


                    IDValue_Textbox.RightToLeft = StoreNameValue_Textbox.RightToLeft =NoteValue_Textbox.RightToLeft = RightToLeft.Yes;
                    ID_label.Text = "رقم المعرف :";
                    StoreName_label.Text = "اسم المستودع :";
                    Note_label.Text = "ملاحظة :";
                    messageEmpty = "يجب ملئ جميع الصناديق لحفظ العملية بنجاح .";
                    textMessageOk = "تم حفظ اسم المستودع بنجاح .";
                    textMessageNo = "لم يتم حفظ اسم المستودع.\nالرجاء التأكد من البيانات المدخلة .";
                    textMessageFounded = "اسم المستودع المدخل موجود مسبقا.";
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
                    IDValue_Textbox.RightToLeft = StoreNameValue_Textbox.RightToLeft = NoteValue_Textbox.RightToLeft = RightToLeft.No;
                    ID_label.Text = "ID :";
                    StoreName_label.Text = "Store Name :";
                    Note_label.Text = "Note :";
                    messageEmpty = "All boxes must be filled to save the process successfully .";
                    textMessageOk = "The Store Name has been successfully saved.";
                    textMessageNo = "The Store Name has not been saved.\nPlease check the data entered.";
                    textMessageFounded = "Store Name is already exists.";
                    Save_button.Text = "Save";
                    Cansel_button.Text = "Cansel";
                    break;
            }
        }
        private void Clear()
        {
            IDValue_Textbox.Text =StoreNameValue_Textbox.Text = NoteValue_Textbox.Text = "";
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Store");
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || StoreNameValue_Textbox.Text == "")
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
            if (isNotEmpty() && class_Connection.IsNotFound("Store", "Store_Name = '" + StoreNameValue_Textbox.Text+"'",textMessageFounded))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Add_Store";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Store_Name", SqlDbType.NVarChar, 50).Value = StoreNameValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 50).Value = NoteValue_Textbox.Text;
                class_Connection.executeNonQuery(sqlCommand: sqlCommand, textMessageOk, textMessageNo);
                Clear();
            }
        }

        private void Form_Store_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Exit_Button_Click(object sender, EventArgs e) => this.Close();

        private void Minimaized_button_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
      
    }
}
