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
    public partial class UserControl_Material_inventory : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private static UserControl_Material_inventory _instance;
        public static UserControl_Material_inventory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Material_inventory();
                return _instance;
            }
        }
        public void GetItemFromSerch(String Item_Name)
        {
            ItemName_comboBox.Text = Item_Name;
            Serch();
        }
        public UserControl_Material_inventory()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            Show_dataGridView.Controls.Clear();
            Get_ItemName();
            Get_StoreName();
            ItemName_comboBox.Text = StoreName_comboBox.Text = "";
            amountIn_label.Text = amountOut_label.Text = amountTotal_label.Text = "0"; 
            
        }

        private void UserControl_Material_inventory_Load(object sender, EventArgs e)
        {
            Show_dataGridView.Font = new Font("Tajawal", 10);
            Clear();
            Load_Data();
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
        private void Load_Data()
        {
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select (select Store_Name from Store where ID = Store_ID) as Store_Name,[Site],(select Item_Name from Item where ID= Item_ID)as Item_Name,(select Unit_Name from Unit_Material where ID = ItemUnit_ID)as Unit_Name,Item_Quantity,Note from Store_Details where (Item_Quantity != 0)", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "اسم المستودع";
                dataTable.Columns[1].ColumnName = "الموقع";
                dataTable.Columns[2].ColumnName = "اسم المادة ";
                dataTable.Columns[3].ColumnName = "الواحدة";
                dataTable.Columns[4].ColumnName = "ملاحظة";
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch
            {
                sqlConnection.Close();
            }
        }
        //**************************************SERCH FOR BILLS ONLE********************************
        private void Serch()
        {
            try
            {
                Show_dataGridView.Controls.Clear();
                sqlConnection.Close();
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select (select Store_Name from Store where ID = Store_ID) as Store_Name,[Site],(select Item_Name from Item where ID= Item_ID)as Item_Name,(select Unit_Name from Unit_Material where ID = ItemUnit_ID)as Unit_Name,Item_Quantity,Note from Store_Details where (Item_Quantity != 0)" + Check_Text(), sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "اسم المستودع";
                dataTable.Columns[1].ColumnName = "الموقع";
                dataTable.Columns[2].ColumnName = "اسم المادة ";
                dataTable.Columns[3].ColumnName = "الواحدة";
                dataTable.Columns[4].ColumnName = "ملاحظة";
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch { }
        }
        private string Check_Text()
        {
            string where = "";
            if (ItemName_comboBox.Text == "" && StoreName_comboBox.Text == "")
                return "";
            else
            {
                if (ItemName_comboBox.Text != "")//1 state
                {
                    where += (" and (Item_ID = (select ID from Item where Item_Name = '"+ ItemName_comboBox.Text + "'))" );
                }
                if (StoreName_comboBox.Text != "")//2 state
                {
                      where += (" and (Store_ID = (select ID from Store where Store_Name = '"+ StoreName_comboBox.Text + "' ))" );
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

        private void ItemName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string amountOut = "select SUM(Quantity)*-1 from Invoice_Details where (Item_ID =(select ID from Item where Item_Name = '"+ItemName_comboBox.Text+"'))and (Invoice_Number in (select ID from Invoice where Invoice_Type in (0,3,4)))";
                string amountIn = "select SUM(Quantity) from Invoice_Details where (Item_ID =(select ID from Item where Item_Name = '"+ItemName_comboBox.Text+"')) and (Invoice_Number in (select ID from Invoice where Invoice_Type in (1,2)))";
                sqlConnection.Close();
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(amountIn, sqlConnection);
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(amountOut, sqlConnection);
                dataTable = new DataTable();
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter1.Fill(dataTable1);
                if (dataTable.Rows[0][0].ToString() != null && dataTable1.Rows[0][0].ToString() != null)
                {
                    amountIn_label.Text = dataTable.Rows[0][0].ToString();
                    amountOut_label.Text = dataTable1.Rows[0][0].ToString();
                    amountTotal_label.Text = (int.Parse(amountIn_label.Text) - int.Parse(amountOut_label.Text)).ToString();
                }
            }
            catch {
                amountIn_label.Text = "0";
                amountOut_label.Text = "0";
                amountTotal_label.Text = "0";
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
