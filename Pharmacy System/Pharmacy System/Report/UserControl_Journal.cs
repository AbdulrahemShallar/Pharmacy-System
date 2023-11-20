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
    public partial class UserControl_Journal : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private static UserControl_Journal _instance;
        public static UserControl_Journal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Journal();
                return _instance;
            }
        }
        public UserControl_Journal()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            Show_dataGridView.Controls.Clear();
            Show_dataGridView.DataSource = "";
            From_dateTimePicker.Value = To_dateTimePicker.Value = System.DateTime.Today;
            ShowAll_checkBox.Checked = false;
        }
        private void UserControl_Journal_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_dataGridView.Font = new Font("Tajawal", 10);
        }
        private void SetHeadName()
        {
            dataTable.Columns[0].ColumnName = "التاريخ";
            dataTable.Columns[1].ColumnName = "الرقم المرجعي";
            dataTable.Columns[2].ColumnName = "من حساب ";
            dataTable.Columns[3].ColumnName = "إلى حساب";
            dataTable.Columns[4].ColumnName = "القيمة";
            dataTable.Columns[5].ColumnName = "الحسم";
            dataTable.Columns[6].ColumnName = "نوع السند";
            dataTable.Columns[7].ColumnName = "البيان";
            dataTable.Columns[8].ColumnName = "منظم الفاتورة";
        }
        private void Load_Data()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(select+ " order by[date]", sqlConnection);
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
                   
                    if (From_dateTimePicker.Text != "" && To_dateTimePicker.Text != "" && !ShowAll_checkBox.Checked)
                    {
                       return (" where [Date] between '" + From_dateTimePicker.Text + "'  and '" + To_dateTimePicker.Text + "' order by[date]"); 
                    }
                    else
                    {
                        //MessageBox.Show("يوجد خطأ في تحديد التاريخ.\nالرجاء التأكد من القيم المدخلة والمحاولة مرة ثاينة.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return " order by[date]";
                    }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Clear();
            Load_Data();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
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
        string select = "select [Date],Reference_Number,"
                        +" case "
                        +"when isToAccountRefernce_Caluculation = 0  then(select Name from Supplier_Customer where To_Account_ID = ID)"
                        +" when isToAccountRefernce_Caluculation != 0 then(select Name from Refernce_Calculation where To_Account_ID = ID)"
                        +" end as to_Account_Name,"
                        +" case "
                        +" when isFromAccountRefernce_Caluculation = 0  then(select Name from Supplier_Customer where From_Account_ID = ID)"
                        +" when isFromAccountRefernce_Caluculation != 0 then(select Name from Refernce_Calculation where From_Account_ID = ID)"
                        +" end as From_Account_Name,"
                        + " Value,Resolved,Recipt_Type,[Statement],Organizer_Name from Receipt ";

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
