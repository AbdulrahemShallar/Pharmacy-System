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
    public partial class Form_UnitItem : Form
    {
        string messageEmpty, textMessageOk, textMessageNo, textMessageFounded;
        public Form_UnitItem()
        {
            InitializeComponent();
        }
        public string InterFace_Name;
        private static Form_UnitItem _instance;
        public static Form_UnitItem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form_UnitItem();
                return _instance;
            }
        }
        public Form_UnitItem(Image image, string TitleText)
        {
            InitializeComponent();
            Title_Label.Text = TitleText;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag());
        }

        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { ID_label,Name_label
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

                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = RightToLeft.Yes;
                    ID_label.Text = "رقم المعرف :";
                    Name_label.Text = "الإسم :";
                    messageEmpty = "يجب ملئ جميع الصناديق لحفظ العملية بنجاح .";
                    textMessageOk = "تم حفظ الواحدة بنجاح .";
                    textMessageNo = "لم يتم حفظ الواحدة.\nالرجاء التأكد من البيانات المدخلة .";
                    textMessageFounded = "اسم الواحدة موجود مسبقا .";
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
                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = RightToLeft.No;
                    ID_label.Text = "ID :";
                    Name_label.Text = "Unit Name :";
                    messageEmpty = "All boxes must be filled to save the process successfully .";
                    textMessageOk = "The Unit has been successfully saved.";
                    textMessageNo = "The Unit has not been saved.\nPlease check the data entered.";
                    textMessageFounded = "Unit Name is already exists.";
                    Save_button.Text = "Save";
                    Cansel_button.Text = "Cansel";
                    break;
            }
        }
        private void Clear()
        {
            NameValue_Textbox.Text = "";
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Unit_Material");
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_UnitItem_Load(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void Title_Label_TextChanged(object sender, EventArgs e)
        {
             
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
            if (isNotEmpty() && class_Connection.IsNotFound("Unit_Material", "Unit_Name = '" + NameValue_Textbox.Text + "'", textMessageFounded))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Add_Unit_Material";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Unit_Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                class_Connection.executeNonQuery(sqlCommand: sqlCommand, textMessageOk, textMessageNo);
                Clear();
            }
        }
    }
}
