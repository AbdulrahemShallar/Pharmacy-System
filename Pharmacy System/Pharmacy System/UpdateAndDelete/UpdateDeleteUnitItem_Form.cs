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
    public partial class UpdateDeleteUnitItem_Form : Form
    {
        private static UpdateDeleteUnitItem_Form _instance;
        public static UpdateDeleteUnitItem_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateDeleteUnitItem_Form();
                return _instance;
            }
        }
        public UpdateDeleteUnitItem_Form()
        {
            InitializeComponent();
        }
        public UpdateDeleteUnitItem_Form(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
        }
        private void Clear()
        {
            NameValue_Textbox.Text = "";
        }
        public static int ID;
        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == 13)
                SendKeys.Send("{tab}");
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Title_Label.Text == "تعديل واحدة")
            {
                Update();
                this.Visible = false;
                UpdateDeleteUnitItem_Form_Load(sender, e);
            }
            else
            {
                Delete();
                this.Visible = false;
                UpdateDeleteUnitItem_Form_Load(sender, e);
            }
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_label_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDeleteUnitItem_Form_Load(object sender, EventArgs e)
        {
            MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم الواحدة");
            myMessgeBox.ShowDialog();
            if (!UserControls.Get_ID.close)
                this.Close();
            Clear();
            Load_Data(ID);
            if (Title_Label.Text == "تعديل واحدة")
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Unit_Material where ID =" + ID, sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                IDValue_Textbox.Text = dataTable.Rows[0][0].ToString();
                NameValue_Textbox.Text = dataTable.Rows[0][1].ToString();
            }
            catch
            {
                this.Close();
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
        void setEnabel(bool State)
        {
             NameValue_Textbox.Enabled = State;
          
        }
        private void Update()
        {
            try
            {
                if (isNotEmpty())
                {
                    SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "Update_Unit_Material";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    sqlCommand.Parameters.Add("@Unit_Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
               MessageBox.Show("تم تعديل الفاتورة بنجاح .");
                    Clear();
                }
            }
            catch {
                MessageBox.Show("لم يتم تعديل الفاتورة.\nالرجاء التأكد من البيانات المدخلة .", "", MessageBoxButtons.OK,MessageBoxIcon.Error);}
        }
        private void Delete()
        {
            try
            {
                if (isNotEmpty())
                {
                    Class_Connection class_Connection = new Class_Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Delete_Unit_Material";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم حذف الواحدة بنجاح .", "لم يتم حذف المادة.\nالرجاء التأكد من البيانات المدخلة .");
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
