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
using System.IO;

namespace Pharmacy_System.UpdateAndDelete
{
    public partial class UpdateDeleteItem_Form : Form
    {
        private static UpdateDeleteItem_Form _instance;
        public static UpdateDeleteItem_Form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateDeleteItem_Form();
                return _instance;
            }
        }
        public UpdateDeleteItem_Form()
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
        public UpdateDeleteItem_Form(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
        }
        private void Clear()
        {
            NameValue_Textbox.Text = DetailsValue_Textbox.Text = SourceValue_Textbox.Text = MainCopmanyValue_Textbox.Text =
                StoreValue_comboBox.Text = LocationValue_Textbox.Text = BarcodeValue_Textbox.Text = UnitValue_comboBox.Text =
                NoteValue_Textbox.Text = "";
            MinimumQuantityValue_Textbox.Text = MaximumQuantityValue_Textbox.Text = NoteValue_Textbox.Text =
                PrchaasingPriceValue_Textbox.Text = SellingPriceValue_Textbox.Text = "0";
            ProductionDateValue_dateTimePicker.Value = ExpiryDateValue_dateTimePicker.Value = System.DateTime.Today;
            CheekValidityDateValue_Checkbox.Checked = true;
            ItemImage_pictureBox.Image = null;
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Item");
        }
        public static int ID;
        private void UpdateDeleteItem_Form_Load(object sender, EventArgs e)
        {
            MyMessgeBox myMessgeBox = new MyMessgeBox("get_id", "ادخل اسم المادة");
            myMessgeBox.ShowDialog();
            if (!UserControls.Get_ID.close)
                this.Close();
            Clear();
            getStoreName();
            getUnitName();
            Load_Data(ID);
            if (Title_Label.Text == "تعديل مادة")
                setEnabel(true);
            else
                setEnabel(false);
            this.Visible = true;
        }
        private void Load_Data(int ID)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID,Item_Name,Details,Source,Main_Company,(select Store_Name from Store where ID = Store_ID),Location,Minimum_Quantity,Maximum_Quantity,Note,Barcode,Production_Date,Expiry_Date,Check_Validity_Date, (select Unit_Name from Unit_Material where ID= Unit_ID),Purchasing_Price,Selling_Price,Item_Image from Item where ID =" + ID, sqlConnection);
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                IDValue_Textbox.Text = dataTable.Rows[0][0].ToString();
                NameValue_Textbox.Text = dataTable.Rows[0][1].ToString();
                DetailsValue_Textbox.Text = dataTable.Rows[0][2].ToString();
                SourceValue_Textbox.Text = dataTable.Rows[0][3].ToString();
                LocationValue_Textbox.Text = dataTable.Rows[0][6].ToString();
                MainCopmanyValue_Textbox.Text = dataTable.Rows[0][4].ToString();
                StoreValue_comboBox.SelectedValue = dataTable.Rows[0][5].ToString();
                MinimumQuantityValue_Textbox.Text = dataTable.Rows[0][7].ToString();
                MaximumQuantityValue_Textbox.Text = dataTable.Rows[0][8].ToString();
                NoteValue_Textbox.Text = dataTable.Rows[0][9].ToString();
                if (dataTable.Rows[0][13].ToString() != "")
                    CheekValidityDateValue_Checkbox.Checked = (bool)dataTable.Rows[0][13];
                else
                    CheekValidityDateValue_Checkbox.Checked = false;
                if (dataTable.Rows[0][11].ToString() != "")
                    ProductionDateValue_dateTimePicker.Value = (DateTime)dataTable.Rows[0][11];
                if (dataTable.Rows[0][12].ToString() != "")
                    ExpiryDateValue_dateTimePicker.Value = (DateTime)dataTable.Rows[0][12];
                UnitValue_comboBox.Text = dataTable.Rows[0][14].ToString();
                PrchaasingPriceValue_Textbox.Text = dataTable.Rows[0][15].ToString();
                SellingPriceValue_Textbox.Text = dataTable.Rows[0][16].ToString();
                BarcodeValue_Textbox.Text = dataTable.Rows[0][10].ToString();
                try
                {
                    byte[] img = (byte[])(dataTable.Rows[0][17]);
                    MemoryStream ms = new MemoryStream(img);
                    ItemImage_pictureBox.Image = Image.FromStream(ms);
                }
                catch
                {
                    ItemImage_pictureBox.Image = null;
                }
            }
            catch {
                this.Close();
            }

        }
        void setEnabel(bool State)
        {
          IDValue_Textbox.Enabled = NameValue_Textbox.Enabled = DetailsValue_Textbox.Enabled = SourceValue_Textbox.Enabled = MainCopmanyValue_Textbox.Enabled =
                StoreValue_comboBox.Enabled = LocationValue_Textbox.Enabled = BarcodeValue_Textbox.Enabled = UnitValue_comboBox.Enabled =
                NoteValue_Textbox.Enabled = State;
            MinimumQuantityValue_Textbox.Enabled = MaximumQuantityValue_Textbox.Enabled = NoteValue_Textbox.Enabled =
                PrchaasingPriceValue_Textbox.Enabled = SellingPriceValue_Textbox.Enabled = State;
            ProductionDateValue_dateTimePicker.Enabled = ExpiryDateValue_dateTimePicker.Enabled = State;
            CheekValidityDateValue_Checkbox.Enabled = State;
            AddUnit_button.Enabled = ChoseImage_button.Enabled = State;
        }
        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || NameValue_Textbox.Text == "" || UnitValue_comboBox.Text == "")
            {
                MessageBox.Show("يجب ملئ جميع الصناديق لحفظ العملية بنجاح .", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void getStoreName()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Store_Name from Store", sqlConnection);
                sqlConnection.Open();
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                StoreValue_comboBox.ValueMember = "Store_Name";
                StoreValue_comboBox.DataSource = dt;
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void AddUnit_buttonEvint()
        {
            Form_UnitItem form_UnitItem = new Form_UnitItem();
            form_UnitItem.ShowDialog();
            getUnitName();
            UnitValue_comboBox.Text = "";
        }

        private void AddUnit_button_Click(object sender, EventArgs e)
        {
            AddUnit_buttonEvint();
        }
        private bool isStoreNameInLList()
        {

            for (int i = 0; i < StoreValue_comboBox.Items.Count; i++)
            {
                if (StoreValue_comboBox.GetItemText(StoreValue_comboBox.Items[i]).Equals(StoreValue_comboBox.Text))
                {
                    return true;
                }
            }
            if (MessageBox.Show("اسم المستودع المدخل غير موجود هل تريد اضافة مستودع جديد ؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Form_Store form_Store = new Form_Store();
                form_Store.ShowDialog();
                getStoreName();
                StoreValue_comboBox.Text = "";
            }
            return false;
        }
        private bool isUnitNameInList()
        {

            for (int i = 0; i < UnitValue_comboBox.Items.Count; i++)
            {
                if (UnitValue_comboBox.GetItemText(UnitValue_comboBox.Items[i]).Equals(UnitValue_comboBox.Text))
                {
                    return true;
                }
            }
            if (MessageBox.Show("اسم الواحدة المدخل غير موجود هل تريد اضافته ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                AddUnit_buttonEvint();

            return false;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Title_Label.Text == "تعديل مادة")
            {
                Update();
                this.Visible = false;
                UpdateDeleteItem_Form_Load(sender, e);
            }
            else
            {
                Delete();
                this.Visible = false;
                UpdateDeleteItem_Form_Load(sender, e);
            }
        }
        private void Update()
        {
            try
            {
                if (isNotEmpty() && isStoreNameInLList() && isUnitNameInList())
                {
                    Class_Connection class_Connection = new Class_Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Update_Item";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    sqlCommand.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Details", SqlDbType.NVarChar, 250).Value = DetailsValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Source", SqlDbType.NVarChar, 50).Value = SourceValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar, 50).Value = LocationValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Main_Company", SqlDbType.NVarChar, 50).Value = MainCopmanyValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Store_Name", SqlDbType.NVarChar, 50).Value = StoreValue_comboBox.SelectedValue.ToString();
                    if (MinimumQuantityValue_Textbox.Text != "")
                        sqlCommand.Parameters.Add("@Minimum_Quantity", SqlDbType.Int).Value = int.Parse(MinimumQuantityValue_Textbox.Text);
                    else
                        sqlCommand.Parameters.Add("@Minimum_Quantity", SqlDbType.Int).Value = 0;
                    if (MaximumQuantityValue_Textbox.Text != "")
                        sqlCommand.Parameters.Add("@Maximum_Quantity", SqlDbType.Int).Value = int.Parse(MaximumQuantityValue_Textbox.Text);
                    else
                        sqlCommand.Parameters.Add("@Maximum_Quantity", SqlDbType.Int).Value = 0;
                    sqlCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 250).Value = NoteValue_Textbox.Text;
                    sqlCommand.Parameters.Add("@Check_Validity_Date", SqlDbType.Bit).Value = CheekValidityDateValue_Checkbox.Checked;
                    sqlCommand.Parameters.Add("@Production_Date", SqlDbType.DateTime).Value = ProductionDateValue_dateTimePicker.Value;
                    sqlCommand.Parameters.Add("@Expiry_Date", SqlDbType.DateTime).Value = ExpiryDateValue_dateTimePicker.Value;
                    sqlCommand.Parameters.Add("@Unit_Name", SqlDbType.NVarChar).Value = UnitValue_comboBox.Text;
                    if (PrchaasingPriceValue_Textbox.Text != "")
                        sqlCommand.Parameters.Add("@Purchasing_Price", SqlDbType.Float).Value = float.Parse(PrchaasingPriceValue_Textbox.Text);
                    else
                        sqlCommand.Parameters.Add("@Purchasing_Price", SqlDbType.Float).Value = 0;
                    if (SellingPriceValue_Textbox.Text != "")
                        sqlCommand.Parameters.Add("@Selling_Price", SqlDbType.Float).Value = float.Parse(SellingPriceValue_Textbox.Text);
                    else
                        sqlCommand.Parameters.Add("@Selling_Price", SqlDbType.Float).Value = 0;
                    sqlCommand.Parameters.Add("@Barcode", SqlDbType.NVarChar, 50).Value = BarcodeValue_Textbox.Text;
                    MemoryStream ms = new MemoryStream();
                    if (ItemImage_pictureBox.Image != null)
                    {
                        ItemImage_pictureBox.Image.Save(ms, ItemImage_pictureBox.Image.RawFormat);
                        byte[] img = ms.ToArray();
                        sqlCommand.Parameters.Add("@Item_Image", SqlDbType.Image).Value = img;
                    }
                    else
                    {
                        ItemImage_pictureBox.Image = ItemImage_pictureBox.ErrorImage;
                        ItemImage_pictureBox.Image.Save(ms, ItemImage_pictureBox.Image.RawFormat);
                        byte[] img = ms.ToArray();
                        sqlCommand.Parameters.Add("@Item_Image", SqlDbType.Image).Value = img;
                    }

                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم تعديل المادة بنجاح .", "لم يتم تعديل المادة.\nالرجاء التأكد من البيانات المدخلة .");
                    Clear();
                }
            }
            catch { }
        }
        private void Delete()
        {
            try
            {
                if (isNotEmpty() && isStoreNameInLList() && isUnitNameInList())
                {
                    Class_Connection class_Connection = new Class_Connection();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "Delete_Item";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                    class_Connection.executeNonQuery(sqlCommand: sqlCommand, "تم تعديل الفاتورة بنجاح .", "لم يتم تعديل الفاتورة.\nالرجاء التأكد من البيانات المدخلة .");
                    Clear();
                }
            }
            catch { }
        }

        private void ChoseImage_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "مسار الصورة||*.JPG;*.PNG;*.GIF;(*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    ItemImage_pictureBox.Image = Image.FromFile(op.FileName);
                    SendKeys.Send("{tab}");
                }
            }
            catch
            {
                MessageBox.Show("ادخال خاطئ", "يجب ان تكون الصورة ذات الإمتدادت (JPG OR PNG)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getUnitName()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Unit_Name from Unit_Material", sqlConnection);
                sqlConnection.Open();
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                UnitValue_comboBox.ValueMember = "Unit_Name";
                UnitValue_comboBox.DataSource = dt;
                sqlConnection.Close();
            }
            catch (Exception x) { MessageBox.Show(x.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
