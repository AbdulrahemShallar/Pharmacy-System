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

namespace Pharmacy_System.UpdateAndDelete
{
    public partial class UpdateDeleteReceipt_Form : Form
    {
        private static UpdateDeleteReceipt_Form _instance;
        public static UpdateDeleteReceipt_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateDeleteReceipt_Form();
                return _instance;
            }
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
        public UpdateDeleteReceipt_Form()
        {
            InitializeComponent();
        }
        public UpdateDeleteReceipt_Form(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
        }
        private void Clear()
        {
            ReferenceNumberValue_Textbox.Text = ToAccountValue_comboBox.Text = FromAccountValue_comboBox.Text
                = Value_Textbox.Text = ResolvedValue_Textbox.Text = StatmentValue_Textbox.Text = "";
            PreviousMonitoringValue_label.Text = ROVAccountValue_label.Text = CurrentMonitoringValue_label.Text = "0";
            Date_dateTimePicker.Value = System.DateTime.Today;
            Date_dateTimePicker.Focus();
        }

        private void UpdateDeleteReceipt_Form_Load(object sender, EventArgs e)
        { }
        //    if (Title_Label.Text == "تعديل سند قبض" || Title_Label.Text == "تعديل سند دفع")
        //    {
        //            MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل رقم السند :");
        //            myMessgeBox.ShowDialog();

        //    }
        //    if (Title_Label.Text == "حذف سند قبض" || Title_Label.Text == "حذف سند دفع")
        //    {
        //            MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل رقم السند :"));
        //            myMessgeBox.ShowDialog();
        //    }
        //    if (!UserControls.Get_ID.close)
        //        this.Close();
        //    Clear();
        //    Load_Data(ID);
        //    if (Title_Label.Text == "تعديل سند قبض" || Title_Label.Text == "تعديل سند دفع")
        //        setEnabel(true);
        //    else if (Title_Label.Text == "حذف سند قبض" || Title_Label.Text == "حذف سند دفع")
        //        setEnabel(false);
        //    this.Visible = true;
        //}
        //private void Load_Data(int ID)
        //{
        //    try
        //    {
        //        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Supplier_Customer where ID =" + ID, sqlConnection);
        //        sqlConnection.Open();
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);
        //        sqlConnection.Close();
        //        IDValue_Textbox.Text = dataTable.Rows[0][0].ToString();
        //        Date_dateTimePicker.Text = dataTable.Rows[0][1].ToString();
        //        ReferenceNumberValue_Textbox.Text = dataTable.Rows[0][2].ToString();
        //        ToAccountValue_comboBox.Text = dataTable.Rows[0][3].ToString();
        //        FromAccountValue_comboBox.Text = dataTable.Rows[0][5].ToString();
        //        Value_Textbox.Text = dataTable.Rows[0][6].ToString();
        //        ResolvedValue_Textbox.Text = dataTable.Rows[0][7].ToString();
        //        StatmentValue_Textbox.Text = dataTable.Rows[0][8].ToString();
        //        OrganizerNameValue_label.Text = dataTable.Rows[0][9].ToString();

        //    }
        //    catch
        //    {
        //        this.Close();
        //    }

        //}
    }
}
