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
    public partial class UserControl_Damaged_items : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private static UserControl_Damaged_items _instance;
        public static UserControl_Damaged_items Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Damaged_items();
                return _instance;
            }
        }
        public void Clear()
        {
            Show_dataGridView.Controls.Clear();
            Show_dataGridView.DataSource = "";
            Total_label.Text = PriceTotal_label.Text = "0";
            Load_Data();
        }
        public UserControl_Damaged_items()
        {
            InitializeComponent();
        }

        private void UserControl_Damaged_items_Load(object sender, EventArgs e)
        {
            Show_dataGridView.Font = new Font("Tajawal", 10);
            Load_Data();
        }
       
        private void Load_Data()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select Item_Name,Quntity,Export_Date,Unit_Price,Total_Price,Barcode,Note from Damaged_Item ", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "اسم المادة";
                dataTable.Columns[1].ColumnName = "الكمية التالفة";
                dataTable.Columns[2].ColumnName = "تاريخ الانتهاء";
                dataTable.Columns[3].ColumnName = "سعر الواحدة";
                dataTable.Columns[4].ColumnName = "السعر الاجمالي";
                dataTable.Columns[5].ColumnName = "البراكود";
                dataTable.Columns[6].ColumnName = "ملاحظة";
                Show_dataGridView.DataSource = dataTable;
                sqlConnection.Close();
                set_labelValue();
            }
            catch
            {
                sqlConnection.Close();
            }
        }
        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Load_Data();
            Clear();
        }
        private void set_labelValue()
        {
            try
            {
                int total = 0, priceTotal = 0;
                for (int i = 0; i < Show_dataGridView.Rows.Count; i++)
                {
                    total += int.Parse(Show_dataGridView.Rows[i].Cells[1].Value.ToString());
                    priceTotal += int.Parse(Show_dataGridView.Rows[i].Cells[4].Value.ToString());
                }
                Total_label.Text = total.ToString();
                PriceTotal_label.Text = priceTotal.ToString();
            }
            catch
            {
                Total_label.Text = "0";
                PriceTotal_label.Text = "0";
            }
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
