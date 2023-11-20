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
    public partial class UpdateDeleteReferenceCalculattion_Form : Form
    {
        private static UpdateDeleteReferenceCalculattion_Form _instance;
        public static UpdateDeleteReferenceCalculattion_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateDeleteReferenceCalculattion_Form();
                return _instance;
            }
        }
        public UpdateDeleteReferenceCalculattion_Form()
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
        public UpdateDeleteReferenceCalculattion_Form(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
        }
        private void Clear()
        {
            NameValue_Textbox.Text = LimitOFDebtValue_Textbox.Text = NoteValue_Textbox.Text = "";
        }
        public static int ID;

        private void UpdateDeleteReferenceCalculattion_Form_Load(object sender, EventArgs e)
        {
            MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل الاسم :");
            myMessgeBox.ShowDialog();
            if (!UserControls.Get_ID.close)
                this.Close();
            Clear();
            Load_Data(ID);
            if (Title_Label.Text == "تعديل بيانات حساب")
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Refernce_Calculation where ID =" + ID, sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                IDValue_Textbox.Text = dataTable.Rows[0][0].ToString();
                NameValue_Textbox.Text = dataTable.Rows[0][1].ToString();
                LimitOFDebtValue_Textbox.Text = dataTable.Rows[0][2].ToString();
                NoteValue_Textbox.Text = dataTable.Rows[0][3].ToString();
            }
            catch
            {
                this.Close();
            }

        }
        void setEnabel(bool State)
        {
            NameValue_Textbox.Enabled = LimitOFDebtValue_Textbox.Enabled = NoteValue_Textbox.Enabled = State;
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Title_Label.Text == "تعديل بيانات حساب")
            {
                Update();
                this.Visible = false;
                UpdateDeleteReferenceCalculattion_Form_Load(sender, e);
            }
            else
            {
                Delete();
                this.Visible = false;
                UpdateDeleteReferenceCalculattion_Form_Load(sender, e);
            }
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || NameValue_Textbox.Text == "")
            {
                MessageBox.Show("يجب ملئ جميع الصناديق لحفظ العملية بنجاح .", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void Update()
        {
            try
            {
                if (isNotEmpty())
                {
                    Class_Connection class_Connection = new Class_Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Update_Refernce_Calculation";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Limit_Of_Debt", SqlDbType.Float).Value = float.Parse(LimitOFDebtValue_Textbox.Text);
                    sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = NoteValue_Textbox.Text;
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم تعديل الاسم بنجاح .", "لم يتم تعديل الاسم.\nالرجاء التأكد من البيانات المدخلة .");
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
                    sqlCommand.CommandText = "Delete_Refernce_Calculation";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم تعديل الاسم بنجاح .", "لم يتم تعديل الاسم.\nالرجاء التأكد من البيانات المدخلة .");
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
