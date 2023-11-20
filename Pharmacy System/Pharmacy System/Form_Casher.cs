using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_System.UserControls;
namespace Pharmacy_System
{
    public partial class Form_Casher : Form
    {
        string[] name = { "btn1", "btn2", "btn3", "btn4", "btn5", "btn6" };
        DataTable dataTable;
        int x = 0,MaxId;
        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
        SqlCommand sqlCommand;
        public Form_Casher()
        {
            InitializeComponent();
        }

        private void Casher_Form_Load(object sender, EventArgs e)
        {
            LoadButton_Click(sender, e);
            Fill_panel.Size = new Size((Medial_panel.Width / 2)-140, this.Height);
            Right_panel.Size = new Size((Medial_panel.Width / 2)-30, this.Height);
            //Barcode_panel.Size = new Size(Sersh_panel.Width / 2, Sersh_panel.Height);
           // Barcode_Textbox.Location = new Point(Barcode_label.Location.X - 245, 6);
            Item_dataGridView.Size = new Size(Item_dataGridView.Width, (Fill_panel.Height / 3) * 2);
            Down_panel.Size = new Size(Down_panel.Width, (Fill_panel.Height / 3));
            setOrganizer_Name();

            Class_Connection class_Connection = new Class_Connection();
            MaxId = int.Parse(class_Connection.getMaxID("Invoice").ToString());
            getItemName();

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
        private void setOrganizer_Name()
        {
            string Organizer_Name= Form_Main.get_Organizer_Name();
            OrganizerName_label.Text = Organizer_Name;
            sqlCommand = new SqlCommand("select [Image] from [User] where Name = '"+Organizer_Name+"'", sqlConnection);
            sqlConnection.Open();
            try
            {
                byte[] img = (byte[])(sqlCommand.ExecuteScalar());
                MemoryStream ms = new MemoryStream(img);
                OrganizerName_pictureBox.Image = Image.FromStream(ms);
            }
            catch
            {
                OrganizerName_pictureBox.Image = null;
            }
            sqlConnection.Close();
        }
        private void StoreName_label_Click(object sender, EventArgs e)
        {

        }
        private void get_UnitPrice(int RowIndex)
        {
            for (int i = 0; i < Item_dataGridView.Rows.Count-1; i++)
            {
                //if (Item_dataGridView.CurrentCell.ColumnIndex == 0)
                //{
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "select Selling_Price from Item where ID = (select Unit_ID from Item where Item_Name = '" + Item_dataGridView.Rows[RowIndex].Cells[0].Value.ToString() + "') ";
                        sqlConnection.Open();
                        String Selling_Price = sqlCommand.ExecuteScalar().ToString();
                        sqlConnection.Close();
                        Item_dataGridView.Rows[RowIndex].Cells[3].Value = Selling_Price;
                        this.Item_dataGridView.CurrentCell = Item_dataGridView[0, RowIndex];

                }
                catch { }
                //}
            }
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void LoadButton_Click(Object sender, EventArgs e)
        {
            x = 0;
            Right_panel.Controls.Clear();
            SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Item_Name,Item_Image from Item where ID IN (select Cash_Button from Setting)", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (i == 0)
                {
                    UserControl_CasherItem b = new UserControl_CasherItem();
                    b.Name = dataTable.Rows[x][0] + "";
                    b.TextLabel1 = dataTable.Rows[x][0].ToString();
                    if (dataTable.Rows[x][1].ToString() == "")
                        b.PicterBox = null;
                    else
                    {
                        byte[] img = (byte[])(dataTable.Rows[x][1]);
                        MemoryStream ms = new MemoryStream(img);
                        b.PicterBox = Image.FromStream(ms);
                    }
                    x++;
                    b.Text = "Click";
                    b.bunifuFlatButton1.Click += new EventHandler(this.button_click);
                    b.Padding = new Padding(0);
                    Right_panel.Controls.Add(b);
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        UserControl_CasherItem b = new UserControl_CasherItem();
                        b.Name = dataTable.Rows[x][0] + "";
                        b.TextLabel1 = dataTable.Rows[x][0].ToString();
                        if (dataTable.Rows[x][1].ToString() == "")
                            b.PicterBox = null;
                        else
                        {
                            byte[] img = (byte[])(dataTable.Rows[x][1]);
                            MemoryStream ms = new MemoryStream(img);
                            b.PicterBox = Image.FromStream(ms);

                        }

                        x++;
                        b.Text = "Click";
                        b.bunifuFlatButton1.Click += new EventHandler(this.button_click);
                        b.Padding = new Padding(0);
                        Right_panel.Controls.Add(b);
                    }
                    else
                    {
                        UserControl_CasherItem b = new UserControl_CasherItem();
                        b.Name = dataTable.Rows[x][0].ToString();
                        b.TextLabel1 = dataTable.Rows[x][0].ToString();
                        if (dataTable.Rows[x][1].ToString() == "")
                            b.PicterBox = null;
                        else
                        {
                            byte[] img = (byte[])(dataTable.Rows[x][1]);
                            MemoryStream ms = new MemoryStream(img);
                            b.PicterBox = Image.FromStream(ms);
                        }
                        x++;
                        b.Text = "Click";
                        b.bunifuFlatButton1.Click += new EventHandler(this.button_click);
                        b.Padding = new Padding(0);
                        Right_panel.Controls.Add(b);
                    }
                    
                }
            }
        }
        public void button_click(object sender, EventArgs e)
        {

            UserControl_CasherItem btn = sender as UserControl_CasherItem;

            MessageBox.Show(btn.button_name + " Clicked");
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Form_Input form_Input = new Form_Input("Add");
            form_Input.ShowDialog();
            LoadButton_Click(sender, e);
        }


        private void Item_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {  
            int TotalValue = 0;
            int QuantitiesValue = 0;
                getUnitName(e.RowIndex);
                get_UnitPrice(e.RowIndex);
            try
                {
                    for (int i = 0; i < Item_dataGridView.Rows.Count - 1; ++i)
                    {
                        Item_dataGridView.Rows[i].Cells[4].Value = Convert.ToInt32(Item_dataGridView.Rows[i].Cells[2].Value) *
                   Convert.ToInt32(Item_dataGridView.Rows[i].Cells[3].Value);
                    }
                }
                catch { }
                for (int i = 0; i < Item_dataGridView.Rows.Count; ++i)
                {
                    TotalValue += Convert.ToInt32(Item_dataGridView.Rows[i].Cells[4].Value);
                    QuantitiesValue += Convert.ToInt32(Item_dataGridView.Rows[i].Cells[2].Value);
                }

                TotalValue_label.Text = TotalValue.ToString();
                NumberOfItemsValue_label.Text = (Item_dataGridView.Rows.Count - 1).ToString();

               
          
        }
        private void getUnitName(int RowIndex)
        {

            for (int i = 0; i < Item_dataGridView.Rows.Count-1; i++)
            {
                if (Item_dataGridView.CurrentCell.ColumnIndex == 0)
                {
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "select Unit_Name from Unit_Material where ID = (select Unit_ID from Item where Item_Name = '" + Item_dataGridView.Rows[RowIndex].Cells[0].Value.ToString() + "') ";
                        sqlConnection.Open();
                        String Unit_Name = sqlCommand.ExecuteScalar().ToString();
                        sqlConnection.Close();
                        Item_dataGridView.Rows[RowIndex].Cells[1].Value = Unit_Name;
                        this.Item_dataGridView.CurrentCell = Item_dataGridView[1, RowIndex];

                    }
                    catch { }
                }
            }
            try
            {
               Item_dataGridView.Rows[RowIndex].Cells[2].Value.ToString();
                        
            }
            catch { Item_dataGridView.Rows[RowIndex].Cells[2].Value = 1; }
        }

        private bool DataGridViewisNotEmpty()
        {
            if (Item_dataGridView.Rows[0].Cells[0].Value == null || Item_dataGridView.Rows[0].Cells[1].Value == null ||
                Item_dataGridView.Rows[0].Cells[2].Value == null || Item_dataGridView.Rows[0].Cells[3].Value == null ||
                Item_dataGridView.Rows[0].Cells[4].Value == null)
            {
                MessageBox.Show("يجب ادخال بيانات مادة واحدة على الاقل لاتمام العملية بشكل صحيح .", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (DataGridViewisNotEmpty() && RestValuelabel.Text == "0")
            {
                Class_Connection class_Connection = new Class_Connection();
                SqlCommand sqlCommand1 = new SqlCommand();
                sqlCommand1.CommandText = "Add_Invoice";
                sqlCommand1.Parameters.Add("@ID", SqlDbType.Int).Value = MaxId;
                sqlCommand1.Parameters.Add("@Reference", SqlDbType.NVarChar, 10).Value = "";
                sqlCommand1.Parameters.Add("@Date", SqlDbType.Date).Value = System.DateTime.Now;
                sqlCommand1.Parameters.Add("@Account_Name", SqlDbType.NVarChar, 50).Value = "مورد نقدي";
                sqlCommand1.Parameters.Add("@Payment_Method", SqlDbType.Bit).Value = 1;
                sqlCommand1.Parameters.Add("@Statement", SqlDbType.NVarChar, 150).Value = "";
                sqlCommand1.Parameters.Add("@Item_Number", SqlDbType.Int).Value = int.Parse(NumberOfItemsValue_label.Text);
                sqlCommand1.Parameters.Add("@Total_Value", SqlDbType.Float).Value = double.Parse(TotalValue_label.Text);
                if (DescountValue_textBox.Text != "")
                    sqlCommand1.Parameters.Add("@Resolved", SqlDbType.Float).Value = double.Parse(DescountValue_textBox.Text);
                else
                    sqlCommand1.Parameters.Add("@Resolved", SqlDbType.Float).Value = 0;
                if (PayedValue_textBox.Text != "")
                    sqlCommand1.Parameters.Add("@Paidup", SqlDbType.Float).Value = double.Parse(PayedValue_textBox.Text);
                else
                    sqlCommand1.Parameters.Add("@Paidup", SqlDbType.Float).Value = 0;
                sqlCommand1.Parameters.Add("@Rest", SqlDbType.Float).Value = 0d;
                sqlCommand1.Parameters.Add("@Receipt_Number", SqlDbType.Int).Value = 0;
                sqlCommand1.Parameters.Add("@Invoice_Type", SqlDbType.Bit).Value = 4;
                sqlCommand1.Parameters.Add("@Organizer_Name", SqlDbType.NVarChar, 50).Value = OrganizerName_label.Text;
                class_Connection.executeNonQuery(sqlCommand: sqlCommand1);
                for (int i = 0; i < Item_dataGridView.Rows.Count - 1; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    string maxid = class_Connection.getMaxID("Invoice_Details");
                    sqlCommand.CommandText = "Add_Invoice_Details";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(maxid);
                    sqlCommand.Parameters.Add("@Invoice_Number", SqlDbType.Int).Value = MaxId;
                    sqlCommand.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = Item_dataGridView.Rows[i].Cells[0].Value.ToString();
                    sqlCommand.Parameters.Add("@Unit_Name", SqlDbType.NVarChar, 50).Value = Item_dataGridView.Rows[i].Cells[1].Value.ToString();
                    sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(Item_dataGridView.Rows[i].Cells[2].Value);
                    sqlCommand.Parameters.Add("@Unit_Price", SqlDbType.Float).Value = Convert.ToDouble(Item_dataGridView.Rows[i].Cells[3].Value);
                    sqlCommand.Parameters.Add("@Total_Price", SqlDbType.Float).Value = Convert.ToDouble(Item_dataGridView.Rows[i].Cells[4].Value);
                    sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = "";
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand);
                }
                class_Connection.Update_Rov("مورد نقدي", float.Parse(RestValuelabel.Text));
                MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
            else
                MessageBox.Show("لا يمكن حفظ فاتورة نقدية اذا لم يتم دفع كامل المبلغ.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void Clear()
        {
                RestValuelabel.Text = TotalValue_label.Text = DescountValue_textBox.Text =PayedValue_textBox.Text= "0";
            Item_dataGridView.Rows.Clear();
        }

        private void ExitButton_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsFound(string Item_name)
        {
            try
            {
                for (int i = 0; i < Item_dataGridView.Rows.Count; i++)
                {
                    if (Item_dataGridView.Rows[i].Cells[0].Value == null) { return false; }
                    string z = Item_dataGridView.Rows[i].Cells[0].Value.ToString();
                    if (Item_name == z)
                    {
                        Item_dataGridView.Rows[i].Cells[2].Value = (int.Parse(Item_dataGridView.Rows[i].Cells[2].Value.ToString()) + 1).ToString();
                        Barcode_Textbox.SelectAll();
                        Barcode_Textbox.Focus();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch { }
            return false;
        }
        private void ChoseNameByBarcode()
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "select Item_Quantity from Store_Details where ID = (select ID from Item where Barcode = '" + Barcode_Textbox.Text+"') and Item_Quantity > 0";
                    sqlConnection.Open();
                    int state = int.Parse(sqlCommand.ExecuteScalar().ToString());
                    sqlConnection.Close();
                if (state > 0)
                {
                    sqlCommand.CommandText = "select Item_Name from Item where Barcode = '" + Barcode_Textbox.Text + "'";
                    sqlConnection.Open();
                    String Item_name = sqlCommand.ExecuteScalar().ToString();
                    sqlConnection.Close();
                    if (!IsFound(Item_name))
                    {
                        DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, (Item_dataGridView.RowCount - 1));
                        Item_dataGridView.Rows.Add(Item_name);
                        Item_dataGridView_CellEndEdit(Item_dataGridView, e);
                        Barcode_Textbox.SelectAll();
                        Barcode_Textbox.Focus();
                    }
                
                }
                else
                { MessageBox.Show("No Quanitey for this Item !!"); }
            }
            catch { }
        }
        private void Barcode_Textbox_TextChanged(object sender, EventArgs e)
        {
            ChoseNameByBarcode();
            Barcode_Textbox.Focus();
        }

        private void TotalValue_label_TextChanged_1(object sender, EventArgs e)
        {
            double TotalValue = 0, DescountValue = 0, PayedValue = 0;
            if(TotalValue_label.Text != "")
            TotalValue = double.Parse(TotalValue_label.Text);
            if(DescountValue_textBox.Text != "")
            DescountValue = double.Parse(DescountValue_textBox.Text);
            if(PayedValue_textBox.Text != "")
            PayedValue = double.Parse(PayedValue_textBox.Text);
            RestValuelabel.Text = (TotalValue - DescountValue - PayedValue).ToString();
        }
        public void ChoseNameBybutton(string Button_Name)
        {
            try
            {
                 DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, (Item_dataGridView.RowCount - 1));
                 Item_dataGridView.Rows.Add(Button_Name);
                 Item_dataGridView_CellEndEdit(Item_dataGridView, e);
                 Barcode_Textbox.SelectAll();
                 Barcode_Textbox.Focus();    
            }
            catch { }
        }

    }
}
