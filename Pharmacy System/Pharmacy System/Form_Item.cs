using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Pharmacy_System
{
    public partial class Form_Item : Form
    {
        string messageEmpty,  textMessageOk, textMessageNo , UnitNotFound , StoreNotFound;
        public Form_Item()
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
        public Form_Item(Image image, string labeltext)
        {
            InitializeComponent();
            Title_Label.Text = labeltext;
            Title_pictureBox.BackgroundImage = image;
            setLanguage(Classes.Class_Languag.getLanguag());


        }
        public void setLanguage(String Languagename)
        {
            Label[] labels = new Label[] { ID_label,Name_label,Details_label,Source_label,MainCopmany_label,Store_label,Location_label,
                MinimumQuantity_label,MaximumQuantity_label,Note_label,Barcode_label,ProductionDate_label,ExpiryDate_label,CheekValidityDate_label,
                Unit_label,PurchaasingPrice_label,SellingPrice_label,ItemImage_label 
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
                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = DetailsValue_Textbox.RightToLeft =
                        SourceValue_Textbox.RightToLeft = MainCopmanyValue_Textbox.RightToLeft = StoreValue_comboBox.RightToLeft =
                        LocationValue_Textbox.RightToLeft = MinimumQuantityValue_Textbox.RightToLeft =
                        MaximumQuantityValue_Textbox.RightToLeft = NoteValue_Textbox.RightToLeft = BarcodeValue_Textbox.RightToLeft =
                        ProductionDateValue_dateTimePicker.RightToLeft = ExpiryDateValue_dateTimePicker.RightToLeft =
                        UnitValue_comboBox.RightToLeft = PrchaasingPriceValue_Textbox.RightToLeft =
                        SellingPriceValue_Textbox.RightToLeft =Unit_groupBox.RightToLeft = Price_groupBox.RightToLeft= RightToLeft.Yes;
                    ID_label.Text = "رقم المعرف :";
                    Name_label.Text = "الإسم :";
                    Details_label.Text = "المواصفات : ";
                    Source_label.Text = "المصدر :";
                    MainCopmany_label.Text = "الشركة المصنعة :";
                    Store_label.Text = "المستودع :";
                    Location_label.Text = "الموقع :";
                    MinimumQuantity_label.Text = "حد الكمية الادنى :";
                    MaximumQuantity_label.Text = "حد الكمية الاعلى :  ";
                    Note_label.Text = "ملاحظة :";
                    Barcode_label.Text = "باركود :";
                    ProductionDate_label.Text = "تاريخ التصنيع :";
                    ExpiryDate_label.Text = "تاريخ الانتهاء :";
                    CheekValidityDate_label.Text = "تدقيق تاريخ الصلاحية : ";
                    Unit_label.Text = "الواحدة :";
                    PurchaasingPrice_label.Text = "سعر الشراء :";
                    SellingPrice_label.Text = "سعر المبيع :";
                    ItemImage_label.Text = "صورة الدواء : ";
                    Unit_groupBox.Text = "واحدة الدواء ";
                    Price_groupBox.Text = "سعر الدواء ";
                    AddUnit_button.Text = "إضافة واحدة ";
                    ChoseImage_button.Text = "إختيار صورة";
                    messageEmpty = "يجب ملئ جميع الصناديق لحفظ العملية بنجاح .";
                    textMessageOk = "تم حفظ الفاتورة بنجاح .";
                    textMessageNo = "لم يتم حفظ الفاتورة.\nالرجاء التأكد من البيانات المدخلة .";
                    UnitNotFound = "اسم الواحدة المدخل غير موجود هل تريد اضافته ؟";
                    StoreNotFound = "اسم المستودع المدخل غير موجود هل تريد اضافة مستودع جديد ؟ ";
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
                    IDValue_Textbox.RightToLeft = NameValue_Textbox.RightToLeft = DetailsValue_Textbox.RightToLeft =
                        SourceValue_Textbox.RightToLeft = MainCopmanyValue_Textbox.RightToLeft = StoreValue_comboBox.RightToLeft =
                        LocationValue_Textbox.RightToLeft = MinimumQuantityValue_Textbox.RightToLeft =
                        MaximumQuantityValue_Textbox.RightToLeft = NoteValue_Textbox.RightToLeft = BarcodeValue_Textbox.RightToLeft =
                        ProductionDateValue_dateTimePicker.RightToLeft = ExpiryDateValue_dateTimePicker.RightToLeft =
                        UnitValue_comboBox.RightToLeft = PrchaasingPriceValue_Textbox.RightToLeft =
                        SellingPriceValue_Textbox.RightToLeft = Unit_groupBox.RightToLeft = Price_groupBox.RightToLeft = RightToLeft.No;
                    ID_label.Text = "ID :";
                    Name_label.Text = "Name :";
                    Details_label.Text = "Details :";
                    Source_label.Text = "Source :";
                    MainCopmany_label.Text = "Main Copmany :";
                    Store_label.Text = "Store :";
                    Location_label.Text = "Location :";
                    MinimumQuantity_label.Text = "Min Quantity :";
                    MaximumQuantity_label.Text = "Max Quantity :";
                    Note_label.Text = "Note :";
                    Barcode_label.Text = "Barcode :";
                    ProductionDate_label.Text = "Production Date :";
                    ExpiryDate_label.Text = "Expiry Date :";
                    CheekValidityDate_label.Text = "Cheek Validity Date :";
                    Unit_label.Text = "Unit :";
                    PurchaasingPrice_label.Text = "Purchaasing Price :";
                    SellingPrice_label.Text = "Selling Price :";
                    ItemImage_label.Text = "Item Image :";
                    Unit_groupBox.Text = "Medicine Unit";
                    Price_groupBox.Text = "Medicine Price";
                    AddUnit_button.Text = "Add Unit";
                    ChoseImage_button.Text = "Chose Image";
                    messageEmpty = "All boxes must be filled to save the process successfully .";
                    textMessageOk = "The invoice has been successfully saved.";
                    textMessageNo = "The invoice has not been saved.\nPlease check the data entered.";
                    UnitNotFound = "The name of the one you entered does not exist. Do you want to add it?";
                    StoreNotFound = "The entered warehouse name does not exist. Do you want to add a new warehouse?";
                    Save_button.Text = "Save";
                    Cansel_button.Text = "Cansel";
                    break;
            }
        }
        private void Clear()
        {
            NameValue_Textbox.Text = DetailsValue_Textbox.Text = SourceValue_Textbox.Text = MainCopmanyValue_Textbox .Text =
                StoreValue_comboBox.Text  = LocationValue_Textbox.Text = BarcodeValue_Textbox.Text =UnitValue_comboBox.Text =
                NoteValue_Textbox.Text = "";
            MinimumQuantityValue_Textbox.Text = MaximumQuantityValue_Textbox.Text = NoteValue_Textbox.Text = 
                PrchaasingPriceValue_Textbox.Text= SellingPriceValue_Textbox.Text =  "0";
            ProductionDateValue_dateTimePicker.Value = ExpiryDateValue_dateTimePicker.Value = System.DateTime.Today;
            CheekValidityDateValue_Checkbox.Checked = true;
            ItemImage_pictureBox.Image = null;
            Class_Connection class_Connection = new Class_Connection();
            IDValue_Textbox.Text = class_Connection.getMaxID("Item");
        }

        private void Form_Item_Load(object sender, EventArgs e)
        {
            Clear();
            getStoreName();
            getUnitName();
            UnitValue_comboBox.Text =StoreValue_comboBox.Text =  "";
        }

        private void Cansel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isNotEmpty()
        {
            if (IDValue_Textbox.Text == "" || NameValue_Textbox.Text == "" || UnitValue_comboBox.Text == "")
            {
                MessageBox.Show(messageEmpty, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           
            for (int i = 0; i < StoreValue_comboBox.Items.Count ; i++)
            {
                if (StoreValue_comboBox.GetItemText(StoreValue_comboBox.Items[i]).Equals(StoreValue_comboBox.Text))
                {
                    return true ;
                }    
            }
            if (MessageBox.Show(StoreNotFound, "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
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
          
            for (int i = 0; i < UnitValue_comboBox.Items.Count ; i++)
            {
                if (UnitValue_comboBox.GetItemText(UnitValue_comboBox.Items[i]).Equals(UnitValue_comboBox.Text))
                {
                    return true;
                }
            }
            if (MessageBox.Show(UnitNotFound, "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                AddUnit_buttonEvint();

            return false;
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (isNotEmpty() && isStoreNameInLList() && isUnitNameInList())
            {   
                Class_Connection class_Connection = new Class_Connection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Add_Item";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(IDValue_Textbox.Text);
                sqlCommand.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = NameValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Details", SqlDbType.NVarChar , 250 ).Value = DetailsValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Source", SqlDbType.NVarChar, 50).Value = SourceValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Location", SqlDbType.NVarChar, 50).Value = LocationValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Main_Company", SqlDbType.NVarChar,50).Value = MainCopmanyValue_Textbox.Text;
                sqlCommand.Parameters.Add("@Store_Name", SqlDbType.NVarChar , 50).Value = StoreValue_comboBox.SelectedValue.ToString();
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
                sqlCommand.Parameters.Add("@Barcode", SqlDbType.NVarChar , 50 ).Value = BarcodeValue_Textbox.Text;
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
          
                class_Connection.executeNonQuery(sqlCommand: sqlCommand,textMessageOk,textMessageNo);
                Clear();
            }

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
        private void Exit_Button_Click(object sender, EventArgs e) => this.Close();

        private void Minimaized_button_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
    }
}
