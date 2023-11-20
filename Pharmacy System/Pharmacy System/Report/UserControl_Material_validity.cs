﻿using System;
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
    public partial class UserControl_Material_validity : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private static UserControl_Material_validity _instance;
        public static UserControl_Material_validity Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Material_validity();
                return _instance;
            }
        }
        public UserControl_Material_validity()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            Show_dataGridView.Controls.Clear();
            Show_dataGridView.DataSource = "";
            ItemName_comboBox.Text  = "";
            From_dateTimePicker.Value = System.DateTime.Today;
            EnabelDate_checkBox.Checked = ShowValidityMatrerial_checkBox.Checked = false;
            Get_ItemName();
        }

        private void UserControl_Material_validity_Load(object sender, EventArgs e)
        {
            Get_ItemName();
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
        private void Load_Data()
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("select * from Store", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "رقم الجهاز";
                dataTable.Columns[1].ColumnName = "إسم الجهاز";
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
            //try
            //{
            //    Show_dataGridView.Controls.Clear();
            //    sqlConnection.Open();
            //    if (!ShowValidityMatrerial_checkBox.Checked)//يجلب المواد بدون المواد المنهية الاصحية
            //        sqlDataAdapter = new SqlDataAdapter("select Dev_Id,Dev_Name,Dev_Type,Dev_Lab,Dev_Barcode,Dev_BrokenState from Device " + Check_Text(), con);
            //    else
            //    { //استعلام يجلب الاعمدة مع المواد المتهية الصلاحية}
            //    dataTable = new DataTable();
            //    sqlDataAdapter.Fill(dataTable);
            //    dataTable.Columns[0].ColumnName = "رقم الجهاز";
            //    dataTable.Columns[1].ColumnName = "إسم الجهاز";
            //    dataTable.Columns[2].ColumnName = "نوع الجهاز";
            //    dataTable.Columns[3].ColumnName = "االمخبر";
            //    dataTable.Columns[4].ColumnName = "الباركود";
            //    dataTable.Columns[5].ColumnName = "العطل";
            //    Show_dataGridView.DataSource = dataTable;
            //    sqlConnection.Close();
            //}
            //catch { }
        }
        private string Check_Text()
        {
            string where = "where ";
            byte AddAnd = 0;
            if (ItemName_comboBox.Text == "" && !EnabelDate_checkBox.Checked)
                return "";
            else
            {
                if (ItemName_comboBox.Text != "")//1 state
                {
                    where += (" Item_Name = '" + ItemName_comboBox.Text + "'");
                    AddAnd = 1;
                }
                if (EnabelDate_checkBox.Checked)//تحديد تاريخ الشراء
                    if (From_dateTimePicker.Text != "")
                    {
                        switch (AddAnd)
                        {
                            case 0: where += (" [Date] = '" + From_dateTimePicker.Text + "'"); AddAnd = 1; break;
                            case 1: where += (" and [Date] = '" + From_dateTimePicker.Text + "'"); break;
                        }
                    }
                return where;
            }
        }

        private void EnabelDate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            From_dateTimePicker.Enabled = EnabelDate_checkBox.Checked;
            Serch();
        }

        private void ShowValidityMatrerial_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Serch();
        }
        public void CompoBox_TextChange(object sender, EventArgs e)
        {
            Serch();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Load_Data();
            Get_ItemName();
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
