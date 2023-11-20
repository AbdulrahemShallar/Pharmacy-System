using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Form_Bill : Form
    {
        string messageEmpty, messageEmptyDataGridView, textMessageOk , AccountNotFound;
        float PreviousMonitoring = 0;
        public Form_Bill()
        {
            InitializeComponent();
            
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
        public Form_Bill(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag());
        }
        private void Exit_Button_Click(object sender, EventArgs e) => this.Close();

        private void Minimaized_button_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { AccountName_label, Payment_label, Statrment_label , Invoice_label , ID_label ,
            Reference_label ,Date_label,NumberOfItems_label,Quantities_label,Total_label,Resolved_label,Paidup_label,Rest_label,
                NumberOfItemsValue_label,QuantitiesValue_label,TotalValue_label
            };


            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    this.RightToLeftLayout = false;
                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].RightToLeft = RightToLeft.Yes;
                    }
                    AccountNameValue_comboBox.RightToLeft = PaymentValue_comboBox.RightToLeft = StatrmentValue_Textbox.RightToLeft =
                        IDValue_Textbox.RightToLeft = ReferenceValue_Textbox.RightToLeft = Date_dateTimePicker.RightToLeft =
                        ResolvedValue_textBox.RightToLeft = PaidupValue_textBox.RightToLeft = InvoiceValue_dataGridView.RightToLeft = RightToLeft.Yes;
                    AccountName_label.Text = "حساب العميل :";
                    Payment_label.Text = "طريقة الدفع :";
                    Statrment_label.Text = "البيان :";
                    Invoice_label.Text = "الفاتورة";
                    ID_label.Text = "الرقم :";
                    Reference_label.Text = "المرجع :";
                    Date_label.Text = "التاريخ :";
                    NumberOfItems_label.Text = "عدد البنود :";
                    Quantities_label.Text = "الكميات :";
                    Total_label.Text = "الاجمالي :";
                    Resolved_label.Text = "الحسم : ";
                    Paidup_label.Text = "المدفوع :";
                    Rest_label.Text = "الباقي :";
                    ReceiptNumber_label.Text = "رقم الايصال :";
                    PreviousMonitoring_label.Text = "رصيد سابق :";
                    CurrentMonitoring_label.Text = "رصيد حالي :";
                    OrganizerName_label.Text = "منظم السند :";
                    PaymentValue_comboBox.Text = "اجل";
                    PaymentValue_comboBox.Items.Add("اجل");
                    PaymentValue_comboBox.Items.Add("نقدا");
                    PaymentValue_comboBox.Items.Add("اجل / نقدا");
                    InvoiceValue_dataGridView.Columns[0].HeaderText = "اسم الدواء";
                    InvoiceValue_dataGridView.Columns[1].HeaderText = "الواحدة";
                    InvoiceValue_dataGridView.Columns[2].HeaderText = "الكمية";
                    InvoiceValue_dataGridView.Columns[3].HeaderText = "السعر الافرادي";
                    InvoiceValue_dataGridView.Columns[4].HeaderText = "السعر الاجمالي";
                    InvoiceValue_dataGridView.Columns[5].HeaderText = "ملاحظة";
                    InvoiceValue_dataGridView.Columns[6].HeaderText = "من مستودع";
                    messageEmpty = "يجب ملئ جميع الصناديق لحفظ العملية بنجاح .";
                    messageEmptyDataGridView = "يجب ادخال بيانات مادة واحدة على الاقل لاتمام العملية بشكل صحيح .";
                    textMessageOk = "تم حفظ الفاتورة بنجاح ."; 
                    AccountNotFound = "اسم الحساب المدخل غير موجود هل تريد اضافته ؟";  
                    Save_button.Text = "حفظ";
                    Cansel_button.Text = "إلغاء";
                    break;
                case "إنكليزي":
                case "English":
                    this.RightToLeftLayout = true;
                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].RightToLeft = RightToLeft.No;
                    }
                    AccountNameValue_comboBox.RightToLeft = PaymentValue_comboBox.RightToLeft = StatrmentValue_Textbox.RightToLeft =
                        IDValue_Textbox.RightToLeft = ReferenceValue_Textbox.RightToLeft = Date_dateTimePicker.RightToLeft =
                        ResolvedValue_textBox.RightToLeft = PaidupValue_textBox.RightToLeft = InvoiceValue_dataGridView.RightToLeft = RightToLeft.No;
                    AccountName_label.Text = "Account Name :";
                    Payment_label.Text = "Payment :";
                    Statrment_label.Text = "Statrment :";
                    Invoice_label.Text = "Invoice :";
                    ID_label.Text = "ID :";
                    Reference_label.Text = "Reference :";
                    Date_label.Text = "Date :";
                    NumberOfItems_label.Text = "Linage :";
                    Quantities_label.Text = "Quantities :";
                    Total_label.Text = "Total :";
                    Resolved_label.Text = "Resolved :";
                    Paidup_label.Text = "Paidup :";
                    Rest_label.Text = "Rest :";
                    ReceiptNumber_label.Text = "Receipt:";
                    PreviousMonitoring_label.Text = "Previous :";
                    CurrentMonitoring_label.Text = "Current :";
                    OrganizerName_label.Text = "Organizer N. :";
                    PaymentValue_comboBox.Text = "paid later";
                    PaymentValue_comboBox.Items.Add("paid later");
                    PaymentValue_comboBox.Items.Add("Cash");
                    PaymentValue_comboBox.Items.Add("paid later \\ Cash");
                    InvoiceValue_dataGridView.Columns[0].HeaderText = "Drug Name";
                    InvoiceValue_dataGridView.Columns[1].HeaderText = "Unit";
                    InvoiceValue_dataGridView.Columns[2].HeaderText = "Quantity.";
                    InvoiceValue_dataGridView.Columns[3].HeaderText = "Unit price";
                    InvoiceValue_dataGridView.Columns[4].HeaderText = "Total price";
                    InvoiceValue_dataGridView.Columns[5].HeaderText = "Note";
                    InvoiceValue_dataGridView.Columns[6].HeaderText = "From Store";
                    messageEmpty = "All boxes must be filled to save the process successfully .";
                    messageEmptyDataGridView = "At least one material data must be entered to complete the process correctly.";
                    textMessageOk = "The invoice has been successfully saved.";
                    AccountNotFound = "The entered account name does not exist.\n Do you want to add it?";
                    Save_button.Text = "Save";
                    Cansel_button.Text = "Cansel";
                    break;
            }
        }
        private void Clear()
        {
            AccountNameValue_comboBox.Text = StatrmentValue_Textbox.Text = ReferenceValue_Textbox.Text = "";
            NumberOfItemsValue_label.Text = QuantitiesValue_label.Text = TotalValue_label.Text =
                ResolvedValue_textBox.Text = PaidupValue_textBox.Text = RestValue_label.Text =
                ReceiptNumberValue_textBox.Text = PreviousMonitoringValue_label.Text = CurrentMonitoringValue_label.Text = "0";
                PaymentValue_comboBox.Text = PaymentValue_comboBox.Items[0].ToString();
            Date_dateTimePicker.Value = System.DateTime.Today;
            InvoiceValue_dataGridView.Rows.Clear();
        }
        private bool isAccountNameInList()
        {

            for (int i = 0; i < AccountNameValue_comboBox.Items.Count; i++)
            {
                if (AccountNameValue_comboBox.GetItemText(AccountNameValue_comboBox.Items[i]).Equals(AccountNameValue_comboBox.Text))
                {
                    return true;
                }
            }
            if (MessageBox.Show(AccountNotFound, "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Form_SupplierAndCustmer form_SupplierAndCustmer = new Form_SupplierAndCustmer();
                form_SupplierAndCustmer.ShowDialog();
            }
            return false;
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" ||  AccountNameValue_comboBox.Text == "" ||
                NumberOfItemsValue_label.Text == "" || TotalValue_label.Text == "" || ResolvedValue_textBox.Text == "" ||
                PaidupValue_textBox.Text == "" || RestValue_label.Text == "" || ReceiptNumberValue_textBox.Text == "")
            {
                MessageBox.Show(messageEmpty, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private bool DataGridViewisNotEmpty()
        { 
            if(InvoiceValue_dataGridView.Rows[0].Cells[0].Value == null || InvoiceValue_dataGridView.Rows[0].Cells[1].Value == null ||
                InvoiceValue_dataGridView.Rows[0].Cells[2].Value == null|| InvoiceValue_dataGridView.Rows[0].Cells[3].Value == null ||
                InvoiceValue_dataGridView.Rows[0].Cells[4].Value == null || InvoiceValue_dataGridView.Rows[0].Cells[4].Value == null)
            {
                MessageBox.Show(messageEmptyDataGridView, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void Form_Bill_Load(object sender, EventArgs e)
        {
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Invoice");
            OrganizerNameValue_label.Text = Form_Main.get_Organizer_Name();
            getAccountName();
            getItemName();

            AccountNameValue_comboBox.Text = "";
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getItemName()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Item_Name from Item", sqlConnection);
                sqlConnection.Open();
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                ItemName_Column.ValueMember = "Item_Name";
                ItemName_Column.DataSource = dt;
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
        private void InvoiceValue_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {    
            int TotalValue = 0;
            int QuantitiesValue = 0;
            getUnitName(e.RowIndex);
            getStoreName(e.RowIndex);
            get_UnitPrice(e.RowIndex);
            try {
                for (int i = 0; i < InvoiceValue_dataGridView.Rows.Count-1; ++i)
                {
                    InvoiceValue_dataGridView.Rows[i].Cells[4].Value = Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value) *
               Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[3].Value);
                }
                }
            catch { }
            for (int i = 0; i < InvoiceValue_dataGridView.Rows.Count; ++i)
            {
                TotalValue += Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[4].Value);
                QuantitiesValue += Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value);
            }

            TotalValue_label.Text = TotalValue.ToString();
            QuantitiesValue_label.Text = QuantitiesValue.ToString();
            NumberOfItemsValue_label.Text = (InvoiceValue_dataGridView.Rows.Count-1).ToString();
          
        }

        private void RestValue()
        {
            RestValue_label.Text = (Convert.ToInt32(TotalValue_label.Text) - (Convert.ToInt32(ResolvedValue_textBox.Text)+Convert.ToInt32(PaidupValue_textBox.Text))).ToString();
        }

        private void TotalValue_label_TextChanged(object sender, EventArgs e)
        {
            RestValue();
        }

        private void ResolvedValue_textBox_TextChanged(object sender, EventArgs e)
        {
            RestValue();

        }

        private void PaidupValue_textBox_TextChanged(object sender, EventArgs e)
        {
            RestValue();
        }

        private void RestValue_label_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Title_Label.Text)
                {
                    case "فاتورة شراء":
                    case "Buy Bill":
                    case "فاتورة مبيع":
                        case "Selas Bill": CurrentMonitoringValue_label.Text = (PreviousMonitoring + float.Parse(RestValue_label.Text)).ToString(); break;
                    case "مرتجع نقدي":
                    case "Retrun Cash Bill":
                    case "مرتجع شراء":
                    case "Return BuyBill":
                    case "مرتجع مبيع":
                    case "Return Seles Bill": CurrentMonitoringValue_label.Text = (PreviousMonitoring - float.Parse(RestValue_label.Text)).ToString(); break;

                }
                
            }
            catch { }
        }

        private void AccountNameValue_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class_Connection class_Connection = new Class_Connection();
            PreviousMonitoring = float.Parse(class_Connection.get_Rov(AccountNameValue_comboBox.Text));
            PreviousMonitoringValue_label.Text = PreviousMonitoring.ToString();
        }

        private void getUnitName(int RowIndex)
        {

            for (int i = 0; i < InvoiceValue_dataGridView.Rows.Count; i++)
            {
                if (InvoiceValue_dataGridView.CurrentCell.ColumnIndex == 0 )
                {
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "select Unit_Name from Unit_Material where ID = (select Unit_ID from Item where Item_Name = '" + InvoiceValue_dataGridView.Rows[RowIndex].Cells[0].Value.ToString() + "') ";
                        sqlConnection.Open();
                        String Unit_Name = sqlCommand.ExecuteScalar().ToString();
                        sqlConnection.Close();
                        InvoiceValue_dataGridView.Rows[RowIndex].Cells[1].Value = Unit_Name;
                        this.InvoiceValue_dataGridView.CurrentCell = InvoiceValue_dataGridView[1, RowIndex];
                    
                    }
                    catch { }
                }
            }
            try
            {
                InvoiceValue_dataGridView.Rows[RowIndex].Cells[2].Value.ToString();

            }
            catch { InvoiceValue_dataGridView.Rows[RowIndex].Cells[2].Value = 1; }
        }
        private void get_UnitPrice(int RowIndex)
        {
            for (int i = 0; i < InvoiceValue_dataGridView.Rows.Count - 1; i++)
            {
                //if (Item_dataGridView.CurrentCell.ColumnIndex == 0)
                //{
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "select Selling_Price from Item where ID = (select Unit_ID from Item where Item_Name = '" + InvoiceValue_dataGridView.Rows[RowIndex].Cells[0].Value.ToString() + "') ";
                    sqlConnection.Open();
                    String Selling_Price = sqlCommand.ExecuteScalar().ToString();
                    sqlConnection.Close();
                    InvoiceValue_dataGridView.Rows[RowIndex].Cells[3].Value = Selling_Price;
                    this.InvoiceValue_dataGridView.CurrentCell = InvoiceValue_dataGridView[0, RowIndex];

                }
                catch { }
                //}
            }
        }
        private void QuantitiesValue_label_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            for (int i = 0; i < InvoiceValue_dataGridView.Rows.Count-1; i++)
            {
                string item_name = InvoiceValue_dataGridView.Rows[i].Cells[0].Value.ToString();
                string store_name = InvoiceValue_dataGridView.Rows[i].Cells[6].Value.ToString();
                int Quantity = int.Parse(InvoiceValue_dataGridView.Rows[i].Cells[2].Value.ToString());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Item_Quantity from Store_Details where Item_ID = (select ID from Item where Item_Name ='" + item_name + "') and Store_ID = (select ID from Store where Store_Name = '" + store_name + "')", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (int.Parse(dataTable.Rows[0][0].ToString()) < Quantity)
                {
                    MessageBox.Show("لا يمكن اضافة الكمية المحددة اكبر من الكمية الموجودة في المستودع المحدد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InvoiceValue_dataGridView.Rows[i].Cells[2].Value = dataTable.Rows[0][0].ToString();
                }
            }
        }

        private void getStoreName(int RowIndex)
        {   
            string[] storename = { InvoiceValue_dataGridView.Rows[RowIndex].Cells[0].Value.ToString()};
            try
            {
                if (InvoiceValue_dataGridView.Rows[RowIndex].Cells[6].Value.ToString() == "")
                {
                }
            }
            catch
            {
                Form_Replay form_Replay = new Form_Replay("StoreName", storename);
                form_Replay.ShowDialog();
                InvoiceValue_dataGridView.Rows[RowIndex].Cells[6].Value = UserControls.TestStoreName_UserControl.store_name;
            }
        }
        private void getAccountName()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name from Supplier_Customer UNION All select Name From Refernce_Calculation", sqlConnection);
                sqlConnection.Open();
                DataTable dt=new DataTable();
                 sqlDataAdapter.Fill(dt);
                AccountNameValue_comboBox.ValueMember = "Name";
                AccountNameValue_comboBox.DataSource = dt;
                sqlConnection.Close();
                 
            }
             catch (Exception x) { MessageBox.Show(x.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        } 
        
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (isNotEmpty() && DataGridViewisNotEmpty() && isAccountNameInList()) 
            {
                Class_Connection class_Connection = new Class_Connection();
                SqlCommand sqlCommand1 = new SqlCommand();
                sqlCommand1.CommandText = "Add_Invoice";
                sqlCommand1.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand1.Parameters.Add("@Reference", SqlDbType.NVarChar , 10 ).Value = ReferenceValue_Textbox.Text;
                sqlCommand1.Parameters.Add("@Date", SqlDbType.Date).Value = Date_dateTimePicker.Value;
                sqlCommand1.Parameters.Add("@Account_Name", SqlDbType.NVarChar,50).Value = AccountNameValue_comboBox.Text;
                sqlCommand1.Parameters.Add("@Payment_Method", SqlDbType.Bit).Value = PaymentValue_comboBox.SelectedIndex;
                sqlCommand1.Parameters.Add("@Statement", SqlDbType.NVarChar, 50).Value = StatrmentValue_Textbox.Text;
                sqlCommand1.Parameters.Add("@Item_Number", SqlDbType.Int).Value = int.Parse(NumberOfItemsValue_label.Text);
                sqlCommand1.Parameters.Add("@Total_Value", SqlDbType.Float).Value = float.Parse(TotalValue_label.Text);
                sqlCommand1.Parameters.Add("@Resolved", SqlDbType.Float).Value = float.Parse(ResolvedValue_textBox.Text);
                sqlCommand1.Parameters.Add("@Paidup", SqlDbType.Float).Value = float.Parse(PaidupValue_textBox.Text);
                sqlCommand1.Parameters.Add("@Rest", SqlDbType.Float).Value = float.Parse(RestValue_label.Text);
                sqlCommand1.Parameters.Add("@Receipt_Number", SqlDbType.Int).Value = int.Parse(ReceiptNumberValue_textBox.Text);
                switch (Title_Label.Text)
                {
                    case "فاتورة شراء":
                    case "Buy Bill": sqlCommand1.Parameters.Add("@Invoice_Type", SqlDbType.Bit).Value = 0;break;
                    case "فاتورة مبيع":
                    case "Selas Bill": sqlCommand1.Parameters.Add("@Invoice_Type", SqlDbType.Bit).Value = 1; break;
                    case "مرتجع شراء":
                    case "Return BuyBill": sqlCommand1.Parameters.Add("@Invoice_Type", SqlDbType.Bit).Value = 2; break;
                    case "مرتجع مبيع":
                    case "Return Seles Bill": sqlCommand1.Parameters.Add("@Invoice_Type", SqlDbType.Bit).Value = 3; break;
                    case "مرتجع نقدي":
                    case "Retrun Cash Bill": sqlCommand1.Parameters.Add("@Invoice_Type", SqlDbType.Bit).Value = 4; break;
                }     
                sqlCommand1.Parameters.Add("@Organizer_Name", SqlDbType.NVarChar, 50).Value = OrganizerNameValue_label.Text;

                class_Connection.executeNonQuery(sqlCommand: sqlCommand1);

                for (int i = 0; i < InvoiceValue_dataGridView.Rows.Count - 1; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    string maxid = class_Connection.getMaxID("Invoice_Details");
                    sqlCommand.CommandText = "Add_Invoice_Details";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(maxid);
                    sqlCommand.Parameters.Add("@Invoice_Number", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    sqlCommand.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = InvoiceValue_dataGridView.Rows[i].Cells[0].Value.ToString();
                    sqlCommand.Parameters.Add("@Unit_Name", SqlDbType.NVarChar, 50).Value = InvoiceValue_dataGridView.Rows[i].Cells[1].Value.ToString();
                    switch (Title_Label.Text)
                    {
                        case "فاتورة شراء":
                        case "Buy Bill": sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value);  break;
                        case "فاتورة مبيع":
                        case "Selas Bill": sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value =Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value)*-1; break;
                        case "مرتجع شراء":
                        case "Return BuyBill": sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value)*-1; break;
                        case "مرتجع مبيع":
                        case "Return Seles Bill": sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value); break;
                        case "مرتجع نقدي":
                        case "Retrun Cash Bill": sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(InvoiceValue_dataGridView.Rows[i].Cells[2].Value); break;
                    }
                   
                    sqlCommand.Parameters.Add("@Unit_Price", SqlDbType.Float).Value = Convert.ToDouble(InvoiceValue_dataGridView.Rows[i].Cells[3].Value);
                    sqlCommand.Parameters.Add("@Total_Price", SqlDbType.Float).Value = Convert.ToDouble(InvoiceValue_dataGridView.Rows[i].Cells[4].Value);
                    sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = Convert.ToString(InvoiceValue_dataGridView.Rows[i].Cells[5].Value);
                    sqlCommand.Parameters.Add("@Store_Name", SqlDbType.NVarChar, 50).Value = Convert.ToString(InvoiceValue_dataGridView.Rows[i].Cells[6].Value);
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand);
                }
                class_Connection.Update_Rov(AccountNameValue_comboBox.Text, float.Parse(CurrentMonitoringValue_label.Text));

                MessageBox.Show(textMessageOk, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }

        }
    }
}
