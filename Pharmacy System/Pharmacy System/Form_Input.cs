using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS0105 // The using directive for 'System.Data' appeared previously in this namespace
using System.Data;
#pragma warning restore CS0105 // The using directive for 'System.Data' appeared previously in this namespace
using System.Data.SqlClient;
namespace Pharmacy_System
{
    public partial class Form_Input : Form
    {
        private string function = "";
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;
        public Form_Input()
        {
            InitializeComponent();
        }
        public Form_Input(String function)
        {

            InitializeComponent();
            this.function = function;
        }
        public void fullCompo()
        {
            DataTable dataTable = new DataTable();
            switch (function)
            {
                case "Add":
                    sqlConnection.Open();
                    sqlDataAdapter = new SqlDataAdapter("select Item_Name from Item where ID NOT IN (select Cash_Button from Setting)", sqlConnection);
                    sqlDataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                    ItemNameValue_comboBox.Text = "";
                    ItemNameValue_comboBox.ValueMember = "Item_Name";
                    ItemNameValue_comboBox.DataSource = dataTable;
                    ; break;
                case "Delete":
                    sqlConnection.Open();
                    sqlDataAdapter = new SqlDataAdapter("select Item_Name from Item where ID IN (select Cash_Button from Setting)", sqlConnection);
                    sqlDataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                    ItemNameValue_comboBox.Text = "";
                    ItemNameValue_comboBox.ValueMember = "Item_Name";
                    ItemNameValue_comboBox.DataSource = dataTable;
                    ; break;
            }
        }
  
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Input_Load(object sender, EventArgs e)
        {
            fullCompo();
            if (ItemNameValue_comboBox.Text == "")
            {
                MessageBox.Show("جميع الادوية المسجلة موجودة على الواجهة.");
                this.Close();
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (ItemNameValue_comboBox.Text != "")
                switch (function)
                {
                    case "Add":

                        sqlCommand = new SqlCommand("insert into Setting (ID)", sqlConnection);
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "Add_CashButton";
                        sqlCommand.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = ItemNameValue_comboBox.Text;
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("تم إضافة اسم المادة للواجهة الرئيسية بنجاح.");
                        fullCompo(); break;
                    case "Delete":
                        sqlCommand = new SqlCommand("insert into Setting (ID)", sqlConnection);
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = "Delete_CashButton";
                        sqlCommand.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = ItemNameValue_comboBox.Text;
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("تم حذف اسم المادة للواجهة الرئيسية بنجاح.");
                        fullCompo(); break;
                }

        }
    }
}
