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
    public partial class UpdateDeleteSupplier_Form : Form
    {
        private static UpdateDeleteSupplier_Form _instance;
        public static UpdateDeleteSupplier_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateDeleteSupplier_Form();
                return _instance;
            }
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
        public UpdateDeleteSupplier_Form()
        {
            InitializeComponent();
        }
        public UpdateDeleteSupplier_Form(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
        }
        private void Clear()
        {
            NameValue_Textbox.Text = CompanyValue_Textbox.Text = Maximum_Debt_LimitValue_Textbox.Text =
                AddressValue_Textbox.Text = PhoneValue_Textbox.Text = MobileValue_Textbox.Text = EmailValue_Textbox.Text
                = NoteValue_Textbox.Text = "";
            WarningValue_Switch.Value = false;
        }
        public static int ID;

        private void UpdateDeleteSupplier_Form_Load(object sender, EventArgs e)
        {
            if (Title_Label.Text == "تعديل حساب زبون" || Title_Label.Text == "تعديل حساب المورد")
            {  if (Title_Label.Text == "تعديل حساب زبون")
                {
                    MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم الزبون");
                    myMessgeBox.ShowDialog();
                }
            else
                {
                    MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم المورد");
                    myMessgeBox.ShowDialog();
                }
            }
             if(Title_Label.Text == "حذف حساب زبون"  || Title_Label.Text == "حذف حساب المورد")
            {
                if (Title_Label.Text == "حذف حساب زبون")
                   {
                    MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم الزبون");
                    myMessgeBox.ShowDialog();
                }
            else
                {
                    MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم المورد");
                    myMessgeBox.ShowDialog();
                }
            }
            if (!UserControls.Get_ID.close)
                this.Close();
            Clear();
            Load_Data(ID);
            if (Title_Label.Text == "تعديل حساب زبون" || Title_Label.Text == "تعديل حساب المورد")
                setEnabel(true);
            else if (Title_Label.Text == "حذف حساب زبون" || Title_Label.Text == "حذف حساب المورد")
                setEnabel(false);
            this.Visible = true;
        }
        private void Load_Data(int ID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Supplier_Customer where ID =" + ID, sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                IDValue_Textbox.Text = dataTable.Rows[0][0].ToString();
                NameValue_Textbox.Text = dataTable.Rows[0][1].ToString();
                CompanyValue_Textbox.Text = dataTable.Rows[0][2].ToString();
                Maximum_Debt_LimitValue_Textbox.Text = dataTable.Rows[0][3].ToString();
                try
                {
                    if (dataTable.Rows[0][4].ToString() == "0")
                        WarningValue_Switch.Value = (bool)false;
                    else
                        WarningValue_Switch.Value = true;
                }
                catch { }
                AddressValue_Textbox.Text = dataTable.Rows[0][5].ToString();
                PhoneValue_Textbox.Text = dataTable.Rows[0][6].ToString();
                MobileValue_Textbox.Text = dataTable.Rows[0][7].ToString();
                EmailValue_Textbox.Text = dataTable.Rows[0][8].ToString();
                NoteValue_Textbox.Text = dataTable.Rows[0][9].ToString();

            }
            catch
            {
                this.Close();
            }

        }
        void setEnabel(bool State)
        {
            NameValue_Textbox.Enabled = CompanyValue_Textbox.Enabled = Maximum_Debt_LimitValue_Textbox.Enabled =
                AddressValue_Textbox.Enabled = PhoneValue_Textbox.Enabled = MobileValue_Textbox.Enabled = EmailValue_Textbox.Enabled
                = NoteValue_Textbox.Enabled = State;
            WarningValue_Switch.Enabled = State;
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private bool isAccountNameInList()
        {
            Class_Connection class_Connection = new Class_Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "isAccountNameInList";
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
            return class_Connection.isAccountNameInList(sqlCommand: sqlCommand, textMessageFound: "اسم الحساب موجود مسبقا ادخل اسم اخر.");
        }

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
           if (Title_Label.Text == "تعديل حساب زبون" || Title_Label.Text == "تعديل حساب المورد")
            {
                Update();
                this.Visible = false;
                UpdateDeleteSupplier_Form_Load(sender, e);
            }
            else if (Title_Label.Text == "حذف حساب زبون" || Title_Label.Text == "حذف حساب المورد")
            {  if(MessageBox.Show("هل تريد حذف جميع السجلات المرتبطة ؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete("DeleteAlL_Supplier_Customer");
                }
            else 
                Delete("Delete_Supplier_Customer");
                this.Visible = false;
                UpdateDeleteSupplier_Form_Load(sender, e);
            }
        }
        private void Update()
        {
            Class_Connection class_Connection = new Class_Connection();
            if (isNotEmpty() && isAccountNameInList())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Update_Supplier_Customer";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Company", SqlDbType.NVarChar, 50).Value = CompanyValue_Textbox.Text;
                if (Maximum_Debt_LimitValue_Textbox.Text != "")
                    sqlCommand.Parameters.Add("@Maximum_Debt_Limit", SqlDbType.Float).Value = float.Parse(Maximum_Debt_LimitValue_Textbox.Text);
                else
                    sqlCommand.Parameters.Add("@Maximum_Debt_Limit", SqlDbType.Float).Value = 0;
                sqlCommand.Parameters.Add("@Check_Max_Debt_Limt", SqlDbType.Real).Value = WarningValue_Switch.Value;
                sqlCommand.Parameters.Add("@Addres", SqlDbType.NVarChar, 100).Value = AddressValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = PhoneValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Mobile", SqlDbType.NVarChar, 50).Value = MobileValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 250).Value = EmailValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = NoteValue_Textbox.Text;
                if (Title_Label.Text == "تعديل حساب زبون")
                    sqlCommand.Parameters.Add("@Account_Type", SqlDbType.NVarChar, 50).Value = "Customer";
                else
                    sqlCommand.Parameters.Add("@Account_Type", SqlDbType.NVarChar, 50).Value = "Supplier";

                class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم الحفظ  بنجاح ."," لم يتم الحفظ.\nالرجاء التأكد من البيانات المدخلة.");
                Clear();
            }
        }
        private void Delete(string ProcName)
        {
            try
            {
                if (isNotEmpty())
                {
                    SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = ProcName;
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    Clear();
                }
            }
            catch { }
        }
    }
}
