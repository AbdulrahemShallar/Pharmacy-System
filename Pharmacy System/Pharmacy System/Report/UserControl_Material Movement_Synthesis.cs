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
    public partial class UserControl_Material_Movement_Synthesis : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        bool isLoad = false;
        private static UserControl_Material_Movement_Synthesis _instance;
        public static UserControl_Material_Movement_Synthesis Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Material_Movement_Synthesis();
                return _instance;
            }
        }
        public UserControl_Material_Movement_Synthesis()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            isLoad = true;
            Show_dataGridView.Controls.Clear();
            Show_dataGridView.DataSource = "";
            From_dateTimePicker.Value = To_dateTimePicker.Value = System.DateTime.Today;
            Get_ItemName();
            Get_StoreName();
            ItemName_comboBox.Text = StoreName_comboBox.Text = "";
            isLoad = false;
        }

        private void UserControl_Material_Movement_Synthesis_Load(object sender, EventArgs e)
        {
            isLoad = true;
            Clear();
        }
        private void Get_ItemName()
        {

            try
            {
                sqlDataAdapter = new SqlDataAdapter("select Item_Name from Item", sqlConnection);
                sqlConnection.Open();
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                ItemName_comboBox.ValueMember = "Item_Name";
                ItemName_comboBox.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Get_StoreName()
        {

            try
            {
                sqlDataAdapter = new SqlDataAdapter("select Store_Name from Store", sqlConnection);
                sqlConnection.Open();
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                StoreName_comboBox.ValueMember = "Store_Name";
                StoreName_comboBox.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        //**************************************SERCH FOR BILLS ONLE********************************
        private void Serch()
        {
            try
            {  
                sqlConnection.Close();
                sqlConnection.Open();
                string x = "select Invoice_Number,(select Item_name from Item where ID = Item_ID) AS item_name,(select Unit_Name from Unit_Material where ID = Unit_ID) as Unit_Name,Quantity,Unit_Price,Total_Price,Note,(select store_name from Store where ID =Store_ID) as Store_Name from Invoice_Details,Invoice where Invoice.ID = Invoice_Details.Invoice_Number" + Check_Text();
                sqlDataAdapter = new SqlDataAdapter("select Invoice_Number,(select Item_name from Item where ID = Item_ID) AS item_name,(select Unit_Name from Unit_Material where ID = Unit_ID) as Unit_Name,Quantity,Unit_Price,Total_Price,Note,(select store_name from Store where ID =Store_ID) as Store_Name from Invoice_Details,Invoice where Invoice.ID = Invoice_Details.Invoice_Number" + Check_Text(), sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "رقم الفاتورة";
                dataTable.Columns[1].ColumnName = "إسم المادة";
                dataTable.Columns[2].ColumnName = "الواحدة";
                dataTable.Columns[3].ColumnName = "الكمية";
                dataTable.Columns[4].ColumnName = "السعر الاجمالي";
                dataTable.Columns[5].ColumnName = "ملاحظة";
                dataTable.Columns[6].ColumnName = "المستودع";
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch { }
        }
        private string Check_Text()
        {
            string where = " ";
            if (ItemName_comboBox.Text == "" && StoreName_comboBox.Text == "" && !EnabelDate_checkBox.Checked)
                return "";
            else
            {
                if (ItemName_comboBox.Text != "")//1 state
                {
                    where += (" and Item_ID = (select ID from Item where Item_Name = '"+ItemName_comboBox.Text+"')");
                }
                if (StoreName_comboBox.Text != "")//2 state
                {
                   where += (" and Store_ID = (select ID from Store where Store_Name = '" + StoreName_comboBox.Text + "')");
                }
                if (EnabelDate_checkBox.Checked)
                    if (From_dateTimePicker.Text != "" && To_dateTimePicker.Text != "")
                    {
                        where += (" and (Invoice.[Date] between '" + From_dateTimePicker.Text + "'  and '" + To_dateTimePicker.Text + "')");
                    }
                    else
                    {
                        MessageBox.Show("يوجد خطأ في تحديد التاريخ.\nالرجاء التأكد من القيم المدخلة والمحاولة مرة ثاينة.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        where += "";
                    }
                return where;
            }
        }

        private void EnabelDate_checkBox_CheckedChanged(object sender, EventArgs e)
        {   if (ItemName_comboBox.Text != "" || StoreName_comboBox.Text != "")
            {
                From_dateTimePicker.Enabled = To_dateTimePicker.Enabled = EnabelDate_checkBox.Checked;
                Serch();
            }
            else
            {
                MessageBox.Show("يجب اختيار اسم مادة او مستودع اولا.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                EnabelDate_checkBox.Checked = false;
            }
        }
        public void CompoBox_TextChange(object sender, EventArgs e)
        {  if(!isLoad)
            Serch();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Clear();
            
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

        private void From_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoad)
                Serch();
        }

        private void To_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoad)
                Serch();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
