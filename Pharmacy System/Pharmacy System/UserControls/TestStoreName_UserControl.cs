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
    public partial class TestStoreName_UserControl : UserControl
    {
      public static string store_name;

        private static TestStoreName_UserControl _instance;
        public static TestStoreName_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TestStoreName_UserControl();
                return _instance;
            }
        }
        public void Clear()
        {
            StoreName_comboBox.Text = "";
        }

        public TestStoreName_UserControl()
        {
            InitializeComponent();
            
        }
        public void getStoreName(string Item_name)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Store_Name from Store where ID = (select store_id from Store_Details where Item_ID = (select  ID from Item where Item_Name = '" + Item_name + "'))", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                StoreName_comboBox.ValueMember = "Store_Name";
                StoreName_comboBox.DataSource = dataTable;

            }
            catch { }
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (StoreName_comboBox.Text != "")
            {
                store_name = StoreName_comboBox.Text;
                ((Form)this.TopLevelControl).Close();
            }
            else
                MessageBox.Show(".يجب اختيار مستودع", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
