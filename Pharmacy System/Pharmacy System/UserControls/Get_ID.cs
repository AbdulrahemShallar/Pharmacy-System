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
    public partial class Get_ID : UserControl
    {
        private static Get_ID _instance;
        public static Get_ID Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Get_ID();
                return _instance;
            }
        }
        public Get_ID()
        {
            InitializeComponent();
        }
        public Get_ID(string lbl_Text)
        {
            InitializeComponent();
            lbl_Title1.Text = lbl_Text;
        }
        int Id = 0;
        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == 13)// اذا ضغط المستخدم على زر enterسوف ينتقل للحقل التالي 
            {
                Btn_Serch_Click(sender, e);
                ((Form)this.TopLevelControl).Close();

            }
        }

        private void Btn_Serch_Click(object sender, EventArgs e)
        {

            switch (lbl_Title1.Text)
            {
                case ": ادخل اسم المادة":GetItemName();break;
                case "ادخل اسم الواحدة": GetUnitName(); break;
                case "ادخل اسم الزبون": GetCustomerORSupplierName();break;
                case "ادخل اسم المورد": GetCustomerORSupplierName();break;
                case "ادخل الاسم :":GetReferanceAccountName();break;
                case "ادخل اسم المستودع :": GetStoreName();break;
            }
            if (Id < 0)
            {
                txt_Id.Text = "";
                close = true;
                ((Form)this.TopLevelControl).Close();
            }
  
        }
        public void GetItemName()
        {   
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID from Item where Item_Name ='"+txt_Id.Text+"'" ,sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            try
            {
                if (dataTable.Rows[0][0].ToString() != "")
                {
                    UpdateAndDelete.UpdateDeleteItem_Form.ID = int.Parse(dataTable.Rows[0][0].ToString());
                    txt_Id.Text = "";
                    close = true;
                    ((Form)this.TopLevelControl).Close();
                }
                else
                { MessageBox.Show("لا يوجد مادة بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("لا يوجد مادة بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void GetUnitName()
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID from Unit_Material where Unit_Name = '" + txt_Id.Text + "'", sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            try
            {
                if (dataTable.Rows[0][0].ToString() != "")
                {
                    UpdateAndDelete.UpdateDeleteUnitItem_Form.ID = int.Parse(dataTable.Rows[0][0].ToString());
                    txt_Id.Text = "";
                    close = true;
                    ((Form)this.TopLevelControl).Close();
                }
                else
                { MessageBox.Show("لا يوجد مادة بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("لا يوجد مادة بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void GetCustomerORSupplierName()
        {
            string Account_Type = "";
           switch (lbl_Title1.Text)
            {
                case "ادخل اسم الزبون": Account_Type = "Customer"; break;
                case "ادخل اسم المورد": Account_Type = "Supplier"; break;
            }
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID from Supplier_Customer where Name = '" + txt_Id.Text + "' and Account_Type = '"+Account_Type+"'", sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            try
            {
                if (dataTable.Rows[0][0].ToString() != "")
                {
                    UpdateAndDelete.UpdateDeleteSupplier_Form.ID = int.Parse(dataTable.Rows[0][0].ToString());
                    txt_Id.Text = "";
                    close = true;
                    ((Form)this.TopLevelControl).Close();
                }
                else
                { MessageBox.Show("الاسم المدخل غير موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("الاسم المدخل غير موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void GetReferanceAccountName()
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID from Refernce_Calculation where Name = '" + txt_Id.Text + "'", sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            try
            {
                if (dataTable.Rows[0][0].ToString() != "")
                {
                    UpdateAndDelete.UpdateDeleteReferenceCalculattion_Form.ID = int.Parse(dataTable.Rows[0][0].ToString());
                    txt_Id.Text = "";
                    close = true;
                    ((Form)this.TopLevelControl).Close();
                }
                else
                { MessageBox.Show("لا يوجد حساب  بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("لا يوجد حساب بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void GetStoreName()
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID from Store where Store_Name = '" + txt_Id.Text + "'", sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            try
            {
                if (dataTable.Rows[0][0].ToString() != "")
                {
                    UpdateAndDelete.UpdateDeleteStore_Form.ID = int.Parse(dataTable.Rows[0][0].ToString());
                    txt_Id.Text = "";
                    close = true;
                    ((Form)this.TopLevelControl).Close();
                }
                else
                { MessageBox.Show("لا يوجد مستودع  بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("لا يوجد مستودع بالاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public static bool close = true;

        private void Btn_Cansole_Click(object sender, EventArgs e)
        {
            txt_Id.Text = "";
            close = false;
            ((Form)this.TopLevelControl).Close();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            txt_Id.Text = "";
            close = false;
            ((Form)this.TopLevelControl).Close();
        }

        private void Get_ID_Load(object sender, EventArgs e)
        {
         
                txt_Id.Focus();
        }
    }
}
