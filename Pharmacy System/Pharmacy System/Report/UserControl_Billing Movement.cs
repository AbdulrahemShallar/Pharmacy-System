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
    public partial class UserControl_Billing_Movement : UserControl
    {

        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private static UserControl_Billing_Movement _instance;
        public static UserControl_Billing_Movement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Billing_Movement();
                return _instance;
            }
        }
        public UserControl_Billing_Movement()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            Show_dataGridView.Controls.Clear();
            Show_dataGridView.DataSource = "";
            EnabelDate_checkBox.Checked = false;
            From_dateTimePicker.Value = To_dateTimePicker.Value = System.DateTime.Today;
        }

        private void UserControl_Billing_Movement_Load(object sender, EventArgs e)
        {    
            Load_Data();
        }

        
        private void SetHeadName()
        {
            dataTable.Columns[0].ColumnName = "الرقم المرجعي";
            dataTable.Columns[1].ColumnName = "التاريخ";
            dataTable.Columns[2].ColumnName = "الحساب";
            dataTable.Columns[3].ColumnName = "طريقة الدفع";
            dataTable.Columns[4].ColumnName = "البيان";
            dataTable.Columns[5].ColumnName = "عدد البنود";
            dataTable.Columns[6].ColumnName = "القيمة الإجمالية";
            dataTable.Columns[7].ColumnName = "الحسم";
            dataTable.Columns[8].ColumnName = "المدفوع";
            dataTable.Columns[9].ColumnName = "الباقي";
            dataTable.Columns[10].ColumnName = "رقم الإيصال";
            dataTable.Columns[11].ColumnName = "نوع الفاتورة";
            dataTable.Columns[12].ColumnName = "منظم الفاتورة";
        }
        private void Load_Data()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(select, sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                SetHeadName();
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }
        }
        private void Serch()
        {
            try
            {
                Show_dataGridView.Controls.Clear();
            sqlConnection.Close();
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(select + Check_Text(), sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                SetHeadName();
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch { }
        }
        private string Check_Text()
        {
            string where = " where ";
            byte AddAnd = 0;
            if ( !EnabelDate_checkBox.Checked && !Buy_checkBox.Checked && !Seles_checkBox.Checked && !ReturnBuy_checkBox.Checked 
                && !ReturnSeles_checkBox.Checked)
                return "";
            else
            {
                if (EnabelDate_checkBox.Checked)
                    if (From_dateTimePicker.Text != "" && To_dateTimePicker.Text != "")
                    {
                        switch (AddAnd)
                        {
                            case 0: where += (" ([Date] between '" + From_dateTimePicker.Text + "'  and '" + To_dateTimePicker.Text + "' )"); AddAnd = 1; break;
                            case 1: where += (" and ([Date] between '" + From_dateTimePicker.Text + "'  and '" + To_dateTimePicker.Text + "')"); break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("يوجد خطأ في تحديد التاريخ.\nالرجاء التأكد من القيم المدخلة والمحاولة مرة ثاينة.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        where += "";
                    }
                if (Buy_checkBox.Checked)//2 state
                {
                    switch (AddAnd)
                    {
                        case 0: where += (" ( Invoice_Type = 0 ) "); AddAnd = 1; break;
                        case 1: where += (" or ( Invoice_Type = 0 ) "); break;
                    }
                }
                if (Seles_checkBox.Checked)
                {
                    switch (AddAnd)
                    {
                        case 0: where += (" (Invoice_Type = 1)"); AddAnd = 1; break;
                        case 1: where += (" or (Invoice_Type = 1)"); break;
                    }
                }
                if (ReturnBuy_checkBox.Checked)
                {
                    switch (AddAnd)
                    {
                        case 0: where += (" (Invoice_Type = 2)"); AddAnd = 1; break;
                        case 1: where += (" or (Invoice_Type = 2)"); break;
                    }
                }
                if (ReturnSeles_checkBox.Checked)
                {
                    switch (AddAnd)
                    {
                        case 0: where += (" (Invoice_Type = 3)"); AddAnd = 1; break;
                        case 1: where += (" or (Invoice_Type = 3)"); break;
                    }
                }
                return where;
            }
        }
        private void EnabelDate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            From_dateTimePicker.Enabled = To_dateTimePicker.Enabled = EnabelDate_checkBox.Checked;
            Serch();
        }
        public void CompoBox_TextChange(object sender, EventArgs e)
        {
           Serch();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Clear();
            Load_Data();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Serch();
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
        string select =
                    "select Reference,[Date],case "
                    + "when isAccountRefernce_Caluculation IS NULL  then(select Name from Supplier_Customer where Account_ID = ID)"
                    + "when isAccountRefernce_Caluculation IS Not Null  then(select Name from Refernce_Calculation where Account_ID = ID)"
                    + "end as Account_Name,"
                    + "case "
                    + "when Payment_Method = 1 then 'اجل'"
                    + "when Payment_Method = 2  then 'نقدا'"
                    + "when Payment_Method = 3  then 'اجل / نقدا'"
                    + "end as Payment_Method,[Statement], Item_Number"
                    + ", Total_Value, Resolved, Paidup, Rest, Receipt_Number,"
                    + "case "
                    + "when  Invoice_Type = 0  then 'فاتورة شراء'"
                    + "when Invoice_Type = 1  then 'فاتورة مبيع'"
                    + "when Invoice_Type = 2  then 'مرتجع شراء'"
                    + "when Invoice_Type = 3  then 'مرتجع مبيع'"
                    + "when  Invoice_Type = 4  then 'مرتجع نقدي'"
                    + "end as Invoice_Type, Organizer_Name from Invoice";

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
