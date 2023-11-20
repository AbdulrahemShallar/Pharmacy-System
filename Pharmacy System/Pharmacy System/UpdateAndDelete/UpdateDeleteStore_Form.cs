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

namespace Pharmacy_System.UpdateAndDelete
{
    public partial class UpdateDeleteStore_Form : Form
    {
        private static UpdateDeleteStore_Form _instance;
        public static UpdateDeleteStore_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateDeleteStore_Form();
                return _instance;
            }
        }
        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == 13)
                SendKeys.Send("{tab}");
        }
        public UpdateDeleteStore_Form()
        {
            InitializeComponent();
        }
        public UpdateDeleteStore_Form(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
        }
        private void Clear()
        {
            IDValue_Textbox.Text = StoreNameValue_Textbox.Text = NoteValue_Textbox.Text = "";
        }
        public static int ID;

        private void UpdateDeleteStore_Form_Load(object sender, EventArgs e)
        {
            MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم المستودع :");
            myMessgeBox.ShowDialog();
            if (!UserControls.Get_ID.close)
                this.Close();
            Clear();
            Load_Data(ID);
            if (Title_Label.Text == "تعديل مستودع")
                setEnabel(true);
            else
                setEnabel(false);
            this.Visible = true;
        }
        private void Load_Data(int ID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Store where ID =" + ID, sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                IDValue_Textbox.Text = dataTable.Rows[0][0].ToString();
                StoreNameValue_Textbox.Text = dataTable.Rows[0][1].ToString();
                NoteValue_Textbox.Text = dataTable.Rows[0][2].ToString();
            }
            catch
            {
                this.Close();
            }
        }
        void setEnabel(bool State)
        {
            IDValue_Textbox.Enabled = StoreNameValue_Textbox.Enabled = NoteValue_Textbox.Enabled = State;
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || StoreNameValue_Textbox.Text == "")
            {
                MessageBox.Show("يجب ملئ جميع الصناديق لحفظ العملية بنجاح .", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Title_Label.Text == "تعديل مستودع")
            {
                Update();
                this.Visible = false;
                UpdateDeleteStore_Form_Load(sender, e);
            }
            else
            {
                Delete();
                this.Visible = false;
                UpdateDeleteStore_Form_Load(sender, e);
            }
        }
        private void Update()
        {
            try
            {
                if (isNotEmpty())
                {
                    Class_Connection class_Connection = new Class_Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Update_Store";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    sqlCommand.Parameters.Add("@Store_Name", SqlDbType.NVarChar, 50).Value = StoreNameValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = NoteValue_Textbox.Text;
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم تعديل اسم المستودع بنجاح .", "لم يتم تعديل اسم المستودع.\nالرجاء التأكد من البيانات المدخلة .");
                    Clear();
                }
            }
            catch { }
        }
        private void Delete()
        {
            try
            {
                if (isNotEmpty())
                {
                    Class_Connection class_Connection = new Class_Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Delete_Store";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم تعديل الفاتورة بنجاح .", "لم يتم تعديل الفاتورة.\nالرجاء التأكد من البيانات المدخلة .");
                    Clear();
                }
            }
            catch { }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
