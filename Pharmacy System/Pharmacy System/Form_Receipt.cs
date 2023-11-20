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
    public partial class Form_Receipt : Form
    {
        string messageEmpty, textMessageOk, textMessageNo , AccountNotFound;
        float PreviousMonitoring = 0;
        public Form_Receipt()
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
        public Form_Receipt(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag());
        }
        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { ID_label,Date_label,ReferenceNumber_label,ToAccount_label,FromAccount_label,Value_label
                ,Resolved_label,PreviousMonitoring_label,ROVAccount_label,CurrentMonitoring_label,OrganizerName_label,
                PreviousMonitoringValue_label,ROVAccountValue_label,CurrentMonitoringValue_label,OrganizerNameValue_label,Statment_label
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
                    IDValue_Textbox.RightToLeft = Date_dateTimePicker.RightToLeft = ReferenceNumberValue_Textbox.RightToLeft =
                       ToAccountValue_comboBox.RightToLeft = FromAccountValue_comboBox.RightToLeft = Value_Textbox.RightToLeft =
                       ResolvedValue_Textbox.RightToLeft = StatmentValue_Textbox.RightToLeft = RightToLeft.Yes;
                    ID_label.Text = "رقم المعرف :";
                    Date_label.Text = "تاريخ  :";
                    ReferenceNumber_label.Text = "رقم المرجع :";
                    ToAccount_label.Text = "الحساب :";
                    FromAccount_label.Text = "ح / النقدية :";
                    Value_label.Text = "قيمة نقدية :";
                    Resolved_label.Text = "الحسم :";
                    PreviousMonitoring_label.Text = "رصيد سابق  :";
                    ROVAccount_label.Text = "رصيد حساب :";
                    CurrentMonitoring_label.Text = "رصيد حالي :";
                    OrganizerName_label.Text = "منظم السند :";
                    messageEmpty = "يجب ملئ جميع الصناديق لحفظ العملية بنجاح .";
                    textMessageOk = "تم حفظ السند بنجاح .";
                    textMessageNo = "لم يتم حفظ السند.\nالرجاء التأكد من البيانات المدخلة .";
                    AccountNotFound = "اسم الحساب المدخل غير موجود هل تريد اضافته ؟";
                    Save_button.Text = "حفظ";
                    Cansel_button.Text = "إلغاء";
                    Statment_label.Text = "البيان :";
                    break;
                case "إنكليزي":
                case "English":
                    this.RightToLeftLayout = true;
                    for (int i = 0; i < labels.Length; i++)
                    {
                        labels[i].RightToLeft = RightToLeft.No;
                    }
                    IDValue_Textbox.RightToLeft = Date_dateTimePicker.RightToLeft = ReferenceNumberValue_Textbox.RightToLeft =
                        ToAccountValue_comboBox.RightToLeft = FromAccountValue_comboBox.RightToLeft = Value_Textbox.RightToLeft =
                        ResolvedValue_Textbox.RightToLeft = RightToLeft.No;
                    ID_label.Text = "ID :";
                    Date_label.Text = "Date :";
                    ReferenceNumber_label.Text = "Reference Number :";
                    ToAccount_label.Text = "ToAccount :";
                    FromAccount_label.Text = "FromAccount :";
                    Value_label.Text = "Value :";
                    Resolved_label.Text = "Resolved :";
                    PreviousMonitoring_label.Text = ":PreviousMonitoring";
                    ROVAccount_label.Text = ": ROVAccount";
                    CurrentMonitoring_label.Text = ":CurrentMonitoring";
                    OrganizerName_label.Text = ": Organizer Name";
                    messageEmpty = "All boxes must be filled to save the process successfully .";
                    textMessageOk = "The Receipt has been successfully saved.";
                    textMessageNo = "The Receipt has not been saved.\nPlease check the data entered.";
                    AccountNotFound = "The entered account name does not exist.\n Do you want to add it?";
                    Save_button.Text = "Save";
                    Cansel_button.Text = "Cansel";
                    Statment_label.Text = "Statment :";
                    break;
            }
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || ToAccountValue_comboBox.Text == "" || FromAccountValue_comboBox.Text == ""
                || Value_Textbox.Text == "" )
            {
                MessageBox.Show(messageEmpty, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private bool isAccountNameInList(ComboBox comboBox)
        {

            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.GetItemText(comboBox.Items[i]).Equals(comboBox.Text))
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
        private void getAccountName()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Name from Supplier_Customer UNION All select Name From Refernce_Calculation", sqlConnection);
                sqlConnection.Open();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                sqlDataAdapter.Fill(dt);
                sqlDataAdapter.Fill(dt1);
                ToAccountValue_comboBox.ValueMember =  "Name";
                ToAccountValue_comboBox.DataSource = dt;
                FromAccountValue_comboBox.ValueMember = "Name";
                FromAccountValue_comboBox.DataSource = dt1;
                sqlConnection.Close();

            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Form_Receipt_Load(object sender, EventArgs e)
        {
            Clear();
            getAccountName();
            OrganizerNameValue_label.Text = Form_Main.get_Organizer_Name();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Class_Connection class_Connection = new Class_Connection();
            if (isNotEmpty() && isAccountNameInList(ToAccountValue_comboBox) && isAccountNameInList(FromAccountValue_comboBox))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Add_Receipt";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = Date_dateTimePicker.Value;
                if (ReferenceNumberValue_Textbox.Text != "")
                    sqlCommand.Parameters.Add("@Reference_Number", SqlDbType.Int).Value = int.Parse(ReferenceNumberValue_Textbox.Text);
                else
                    sqlCommand.Parameters.Add("@Reference_Number", SqlDbType.Int).Value = 0;
                sqlCommand.Parameters.Add("@To_Account_Name", SqlDbType.NVarChar, 50).Value = ToAccountValue_comboBox.Text;
                sqlCommand.Parameters.Add("@From_Account_Name", SqlDbType.NVarChar, 50).Value = FromAccountValue_comboBox.Text;
                if (Value_Textbox.Text != "")
                    sqlCommand.Parameters.Add("@Value", SqlDbType.Float).Value = float.Parse(Value_Textbox.Text);
                else
                    sqlCommand.Parameters.Add("@Value", SqlDbType.Float).Value = 0;
                if (ResolvedValue_Textbox.Text != "")
                    sqlCommand.Parameters.Add("@Resolved", SqlDbType.Float).Value = float.Parse(ResolvedValue_Textbox.Text);
                else
                    sqlCommand.Parameters.Add("@Resolved", SqlDbType.Float).Value = 0;
                sqlCommand.Parameters.Add("@Recipt_Type", SqlDbType.NVarChar, 50).Value = Title_Label.Text;
                sqlCommand.Parameters.Add("@Statement", SqlDbType.NVarChar, 50).Value = StatmentValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Organizer_Name", SqlDbType.NVarChar, 50).Value = OrganizerNameValue_label.Text;
                class_Connection.executeNonQuery(sqlCommand: sqlCommand, textMessageOk, textMessageNo);
                class_Connection.Update_Rov(FromAccountValue_comboBox.Text, float.Parse(CurrentMonitoringValue_label.Text));
                Clear();
            }
        }

        private void FromAccountValue_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class_Connection class_Connection = new Class_Connection();
            PreviousMonitoring= float.Parse(class_Connection.get_Rov(FromAccountValue_comboBox.Text));
            PreviousMonitoringValue_label.Text = PreviousMonitoring.ToString();
        }

        private void Value_Textbox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
             CurrentMonitoringValue_label.Text = (PreviousMonitoring - float.Parse(Value_Textbox.Text)).ToString();
            }
            catch { }
        }

        private void ResolvedValue_Textbox_KeyUp(object sender, KeyEventArgs e)
        {
            try {
                CurrentMonitoringValue_label.Text = (PreviousMonitoring - float.Parse(Value_Textbox.Text)).ToString();
               }
            catch { }
        }

        private void Clear()
        {
            ReferenceNumberValue_Textbox.Text =ToAccountValue_comboBox.Text = FromAccountValue_comboBox.Text 
                =Value_Textbox.Text=ResolvedValue_Textbox.Text =StatmentValue_Textbox.Text = "";
            PreviousMonitoringValue_label.Text = ROVAccountValue_label.Text = CurrentMonitoringValue_label.Text = "0";
            Date_dateTimePicker.Value = System.DateTime.Today;
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Receipt");
            Date_dateTimePicker.Focus();
        }

        private void Exit_Button_Click(object sender, EventArgs e) => this.Close();

        private void Minimaized_button_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
    }
}
