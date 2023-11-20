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

namespace Pharmacy_System.Report
{
 
    public partial class UserControl_Account_balances : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        

        private static UserControl_Account_balances _instance;
        public static UserControl_Account_balances Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Account_balances();
                return _instance;
            }
        }
        public void Clear()
        {
            Show_dataGridView.Controls.Clear();
            Show_dataGridView.DataSource = "";
            AccuntName_comboBox.Text = "";
            AccuntType_comboBox.Text = "";
            TotalMastPay_label.Text = TotalNeed_label.Text  = "0";
        }
        public UserControl_Account_balances()
        {
            InitializeComponent();
        }

        private void UserControl_Account_balances_Load(object sender, EventArgs e)
        {
            Show_dataGridView.Font = new Font("Tajawal", 10);
            Get_AccuntName();
            Load_Data();
        }
        private void Get_AccuntName()
        {

            try
            {
                sqlDataAdapter = new SqlDataAdapter("select Name from Supplier_Customer UNION All select Name From Refernce_Calculation", sqlConnection);
                sqlConnection.Open();
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                AccuntName_comboBox.ValueMember = "Name";
                AccuntName_comboBox.DataSource = dataTable;
                AccuntName_comboBox.Text = "";
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Load_Data()
        {
            Clear();
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select e.Account_Name,case when s.Account_Type = 'Supplier' then 'مورد' when s.Account_Type = 'Customer' then 'زبون' else 'حساب مرجعي' end as AccountType,e.ROV_Account from RovAccount as e Left join Supplier_Customer as s on e.Account_Name = s.Name left join Refernce_Calculation as r on r.Name = e.Account_Name", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "اسم الحساب";
                dataTable.Columns[1].ColumnName = "نوع الحساب";
                dataTable.Columns[2].ColumnName = "الرصيد الحالي";
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
                SetValues();
            }
            catch
            {
                sqlConnection.Close();
            }
        }
        private void SetValues()
        {
            int TotalNeed = 0, TotalMastPay=0;
            for (int i = 0; i < Show_dataGridView.Rows.Count;i++)
            {
                if (Show_dataGridView.Rows[i].Cells[1].Value.ToString() == "زبون")
                    TotalMastPay += Convert.ToInt32(Show_dataGridView.Rows[i].Cells[2].Value);
                else if (Show_dataGridView.Rows[i].Cells[1].Value.ToString() == "مورد")
                    TotalNeed += Convert.ToInt32(Show_dataGridView.Rows[i].Cells[2].Value);

            }

            TotalNeed_label.Text = TotalNeed.ToString();
            TotalMastPay_label.Text = TotalMastPay.ToString();
        }
        private void Serch()
        {
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select e.Account_Name,case when s.Account_Type = 'Supplier' then 'مورد' when s.Account_Type = 'Customer' then 'زبون' else 'حساب مرجعي' end as AccountType,e.ROV_Account from RovAccount as e Left join Supplier_Customer as s on e.Account_Name = s.Name left join Refernce_Calculation as r on r.Name = e.Account_Name " + Check_Text(), sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "اسم الحساب";
                dataTable.Columns[1].ColumnName = "نوع الحساب";
                dataTable.Columns[2].ColumnName = "الرصيد الحالي";
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
                SetValues();
            }
            catch { }
        }
        
        private string Check_Text()
        {
            string where = "where ";
            byte AddAnd = 0;
            if (AccuntName_comboBox.Text == "" && AccuntType_comboBox.Text == "")
                return "";
            else
            {
                if (AccuntName_comboBox.Text != "")//1 state
                {
                    switch (AddAnd) {
                        case 0: where += (" (e.Account_Name = '" + AccuntName_comboBox.Text + "' or s.Name ='" + AccuntName_comboBox.Text + "')");
                    AddAnd = 1;break;
                        case 1:  where += (" and (e.Account_Name = '" + AccuntName_comboBox.Text + "' or s.Name ='" + AccuntName_comboBox.Text + "')");
                            break;
                    }
                }
                if (AccuntType_comboBox.Text != "")//2 state
                {
                    string AccuntTypeText ="" ;
                    switch (AccuntType_comboBox.Text)
                    {
                        case "مورد":AccuntTypeText = "Supplier"; break;
                        case "زبون": AccuntTypeText = "Customer"; break;
                        case "حساب مرجعي": AccuntTypeText = ""; break;
                    }if(AccuntTypeText != "")
                    switch (AddAnd)
                    {   
                        case 0: where += (" (s.Account_Type = '" + AccuntTypeText + "')"); AddAnd = 1; break;
                        case 1: where += (" and (s.Account_Type = '" + AccuntTypeText + "')"); break;
                    }
                    else
                        switch (AddAnd)
                        {
                            case 0: where += ("  (r.Name = e.Account_Name)"); AddAnd = 1; break;
                            case 1: where += ("  and (r.Name = e.Account_Name)");  break;
                        }
                }
                return where;
            }
        }
        public void CompoBox_TextChange(object sender, EventArgs e)
        {  
            Serch();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Clear();
            Load_Data();
            Get_AccuntName();
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            //Form_Print fro = new Form_Print();

            // if (MessageBox.Show("هل تريد طباعة ناتج البحث", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            // {
            //     sqlConnection.Open();
            //     sqlDataAdapter = new SqlDataAdapter("select * from Device ", sqlConnection);
            //     sqlDataAdapter.Fill(fro.DataSetLab.Device);
            //     fro.reportViewer1.RefreshReport();
            //     fro.ShowDialog();
            //     sqlConnection.Close();
            // }
            // else
            // {
            //     sqlConnection.Open();
            //     sqlDataAdapter = new SqlDataAdapter("select * from Device where Dev_Barcode = '6210000001' ", sqlConnection);
            //     sqlDataAdapter.Fill(fro.DataSetLab.Device);
            //     fro.reportViewer1.RefreshReport();
            //     fro.ShowDialog();
            //     sqlConnection.Close();
            // }
            int heoight = Show_dataGridView.Height;
            Show_dataGridView.Height = Show_dataGridView.RowCount * Show_dataGridView.RowTemplate.Height * 2;
            bmp = new Bitmap(Show_dataGridView.Width, Show_dataGridView.Height);
            Show_dataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, Show_dataGridView.Width, Show_dataGridView.Height));
            Show_dataGridView.Height = heoight;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bmp;
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
