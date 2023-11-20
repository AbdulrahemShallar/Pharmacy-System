using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pharmacy_System
{
    public partial class From_CheakSersh : Form
    {
        public From_CheakSersh()
        {
            InitializeComponent();
        }

        private void Cansole_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Get_AccuntName()
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name from Supplier_Customer UNION All select Name From Refernce_Calculation", sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                AccuntName_comboBox.ValueMember = "Name";
                AccuntName_comboBox.DataSource = dataTable;
                AccuntName_comboBox.Text = "";
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Get_ItemName()
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Item_Name from Item", sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                ItemName_comboBox.ValueMember = "Item_Name";
                ItemName_comboBox.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            SqlDataAdapter sqlDataAdapter;
            DataTable dataTable;
            if (radioButton1.Checked)
            {
                if (AccuntName_comboBox.Text != "")
                {
                    try
                    {
                        sqlDataAdapter = new SqlDataAdapter("select Name from Supplier_Customer where Name = '" + AccuntName_comboBox.Text + "' UNION All select Name From Refernce_Calculation where Name='" + AccuntName_comboBox.Text + "'", sqlConnection);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows[0][0].ToString() != "")
                        {
                            Form_Report form_Report = new Form_Report("UserControl_FromSerchAccount", AccuntName_comboBox.Text);
                            form_Report.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن ايجاد الاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AccuntName_comboBox.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("لا يمكن ايجاد الاسم المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AccuntName_comboBox.Text = "";
                    }
                }
                else { MessageBox.Show("يجب اختيار حساب اولا.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (radioButton2.Checked)
            {
                 if (ItemName_comboBox.Text != "")
                {
                    try
                    {
                        sqlDataAdapter = new SqlDataAdapter("select Item_Name from Item where Item_Name = '"+ItemName_comboBox.Text+"'", sqlConnection);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows[0][0].ToString() != "")
                        {
                            Form_Report form_Report = new Form_Report("UserControl_FormSerchItem", ItemName_comboBox.Text);
                            form_Report.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن ايجاد المادة المدخلة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ItemName_comboBox.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("لا يمكن ايجاد المادة المدخلة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ItemName_comboBox.Text = "";
                    }
                }
                else { MessageBox.Show("يجب تحديد مادة اولا.","",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            else if(radioButton3.Checked)
            {
                if (Barcode_Textbox.Text != "")
                {
                    try
                    {
                        sqlDataAdapter = new SqlDataAdapter("select i.Item_Name,(select Store_Name from Store where ID = i.Store_ID)as Store_Name,i.Main_Company,i.Location,i.Selling_Price,s.Item_Quantity from Item i ,Store_Details s  where (i.ID = s.Item_ID) and (Barcode = '"+Barcode_Textbox.Text+"')", sqlConnection);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows[0][0].ToString() != "")
                        { 
                            MessageBox.Show("اسم المادة : "+dataTable.Rows[0][0].ToString()+"\n"+ "موجودة ضمن المستودع : " + dataTable.Rows[0][1].ToString() + "\n"+
                                "الكمية المتوفرة : " + dataTable.Rows[0][5].ToString() + "\n"+ "الموقع  : " + dataTable.Rows[0][3].ToString() + "\n"+
                                "تصنيع شركة : " + dataTable.Rows[0][2].ToString() + "\n"+ "سعر المبيع : " + dataTable.Rows[0][4].ToString() + "\n","",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                            Barcode_Textbox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن ايجاد الباركود المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Barcode_Textbox.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("لا يمكن ايجاد الباركود المدخل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Barcode_Textbox.Text = "";
                    }
                }
                else { MessageBox.Show("يجب ادخال باركود اولا.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
                MessageBox.Show("الرجاء تحديد طريقة بحث اولا.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > ((int)Keys.D0) - 1) && (e.KeyChar < ((int)Keys.D9) + 1) || (e.KeyChar == (int)Keys.Back))
            {
                return;
            }
            e.Handled = true;
            if (e.KeyChar == 13)
                SendKeys.Send("{tab}");
        }
        void Clear()
        {
            AccuntName_comboBox.Visible = AccuntName_label.Visible = false;
            ItemName_comboBox.Visible = ItemName_label.Visible = false;
            Barcode_label.Visible = Barcode_Textbox.Visible = false;
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            Get_AccuntName();
            AccuntName_comboBox.Visible = AccuntName_label.Visible = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            Get_ItemName();
            ItemName_comboBox.Visible = ItemName_label.Visible = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            Clear();
            Barcode_label.Visible = Barcode_Textbox.Visible = true;
        }
    }
}
