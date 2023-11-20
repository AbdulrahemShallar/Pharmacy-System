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
    public partial class UserControl_Account_statement : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private static UserControl_Account_statement _instance;
        public static UserControl_Account_statement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Account_statement();
                return _instance;
            }
        }
   
        public void Clear()
        {
            Show_dataGridView.Rows.Clear();
            AccuntName_comboBox.Text =  "";
            EnabelDate_checkBox.Checked = false;
            TotalMastPay_label.Text = TotalNeed_label.Text = Total_label.Text = "0";
            Get_AccuntName();
        }
        public UserControl_Account_statement()
        {
            InitializeComponent();
        }
        public void GetAccountFromSerch(string Account_Name)
        {
            AccuntName_comboBox.Text = Account_Name;
            Serch();
        }
        private void UserControl_Account_statement_Load(object sender, EventArgs e)
        {
            Show_dataGridView.Font = new Font("Tajawal", 10);
            //Show_dataGridView.Size = new Size(954, 477);
                Get_AccuntName();
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
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //**************************************SERCH FOR BILLS ONLE********************************
        private void Serch()
        {
            try
            {
                string select = "select [DATE],Reference_Number,"
+ " case "
+ " when isToAccountRefernce_Caluculation = 0  then(select Name from Supplier_Customer where To_Account_ID = ID)"
+ " when isToAccountRefernce_Caluculation != 0  then(select Name from Refernce_Calculation where To_Account_ID = ID)"
+ " end as to_Account_Name"
+ " ,Value,Resolved,[Statement],"
+ " (select ROV_Account from RovAccount where Account_Name = case "
+ " when isToAccountRefernce_Caluculation = 0  then(select Name from Supplier_Customer where To_Account_ID = ID)"
+ " when isToAccountRefernce_Caluculation != 0  then(select Name from Refernce_Calculation where To_Account_ID = ID)"
+ " end)as Rov,Recipt_Type"
+ " from Receipt where (To_Account_ID = (case "
+ " when isToAccountRefernce_Caluculation = 0  then(select ID from Supplier_Customer where Name = '" + AccuntName_comboBox.Text + "')"
+ " when isToAccountRefernce_Caluculation != 0  then(select ID from Refernce_Calculation where Name = '" + AccuntName_comboBox.Text + "')"
+ " end))"+ Check_Text();
                string select1 = "select[DATE], Reference, Item_Number,"
        + " case when Payment_Method = 0 then 'اجل'"
        + " when Payment_Method = 1 then 'نقدا'"
        + " when Payment_Method = 2 then 'اجل / نقدا' end as Payment_Method,"
        + " case when Invoice_Type = 0 then 'فاتورة شراء'"
        + " when Invoice_Type = 1 then 'فاتورة مبيع'"
        + " when Invoice_Type = 2 then 'مرتجع شراء' "
        + " when Invoice_Type = 3 then 'مرتجع مبيع'"
        + " when Invoice_Type = 4 then 'مرتجع نقدي' end as Invoice_Type"
        + " ,Total_Value,Paidup,Resolved,Rest,[Statement],"
        + " (select ROV_Account from RovAccount where Account_Name = case "
        + " when isAccountRefernce_Caluculation IS null  then(select Name from Supplier_Customer where Account_ID = ID)"
        + " when isAccountRefernce_Caluculation  IS Not null then(select Name from Refernce_Calculation where Account_ID = ID)"
        + " end)as Rov from Invoice  where (Account_ID = (case "
        + " when isAccountRefernce_Caluculation IS null  then(select ID from Supplier_Customer where Name = '" + AccuntName_comboBox.Text + "')"
        + " when isAccountRefernce_Caluculation  IS Not null then(select ID from Refernce_Calculation where Name = '" + AccuntName_comboBox.Text + "')"
        + " end))"+ Check_Text();
                double TotalNeed = 0;
                double TotalMastPay = 0;
                Show_dataGridView.Rows.Clear();
                sqlDataAdapter = new SqlDataAdapter(select, sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Show_dataGridView.Rows.Add();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[0].Value = dataTable.Rows[i][0].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[1].Value = dataTable.Rows[i][1].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[2].Value = "سند";
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[4].Value = dataTable.Rows[i][2].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[8].Value = dataTable.Rows[i][3].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[10].Value = dataTable.Rows[i][4].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[13].Value = dataTable.Rows[i][5].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[12].Value = dataTable.Rows[i][6].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[6].Value = dataTable.Rows[i][7].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Aquamarine;
                    TotalNeed += double.Parse(dataTable.Rows[i][3].ToString());
                }
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(select1, sqlConnection);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter1.Fill(dataTable1);
                for (int i = 0; i < dataTable1.Rows.Count; i++)
                {
                    Show_dataGridView.Rows.Add();

                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[0].Value = dataTable1.Rows[i][0].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[1].Value = dataTable1.Rows[i][1].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[2].Value = "فاتورة";
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[3].Value = dataTable1.Rows[i][2].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[5].Value = dataTable1.Rows[i][3].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[7].Value = dataTable1.Rows[i][4].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[8].Value = dataTable1.Rows[i][5].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[9].Value = dataTable1.Rows[i][6].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[10].Value = dataTable1.Rows[i][7].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[11].Value = dataTable1.Rows[i][8].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[13].Value = dataTable1.Rows[i][9].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].Cells[12].Value = dataTable1.Rows[i][6].ToString();
                    Show_dataGridView.Rows[Show_dataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.SkyBlue;
                    TotalMastPay += double.Parse(dataTable1.Rows[i][5].ToString());
                }
                  
                Show_dataGridView.Sort(this.Show_dataGridView.Columns[0], ListSortDirection.Ascending);
                if (dataTable.Rows.Count == 0 && dataTable1.Rows.Count == 0)
                    Show_dataGridView.Rows.Clear();
                TotalNeed_label.Text = TotalNeed.ToString();
                TotalMastPay_label.Text = TotalMastPay.ToString();
                Total_label.Text = (TotalNeed - TotalMastPay).ToString();
            }
            catch { Show_dataGridView.Rows.Clear(); }
        }
        private string Check_Text()
        {
            string where = "";
            if (!EnabelDate_checkBox.Checked)
                return "";
            else
            {
                if (EnabelDate_checkBox.Checked)
                    if (From_dateTimePicker.Text != "" && To_dateTimePicker.Text != "")
                    {
                      where += (" and ([Date] between '" + From_dateTimePicker.Text + "'  and '" + To_dateTimePicker.Text + "')");
                    }
                    else
                    {
                        MessageBox.Show("يوجد خطأ في تحديد التاريخ.\nالرجاء التأكد من القيم المدخلة والمحاولة مرة ثاينة.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        where += "";
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

        private void Sersh_button_Click(object sender, EventArgs e)
        {   if (AccuntName_comboBox.Text != "")
                Serch();
            else
                MessageBox.Show("لا يمكن ترك مربع الاسم فارغ","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void EnabelDate_checkBox_CheckedChanged(object sender, EventArgs e)
        {   
            From_dateTimePicker.Enabled = To_dateTimePicker.Enabled = EnabelDate_checkBox.Checked;
            Serch();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
