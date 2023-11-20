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
    public partial class Form_Main : Form
    {  
       int Form_Width = 0;
       int Form_Height = 0;
        private static string Organizer_Name;
        public static void set_Organizer_Name(string Organizers_Name)=> Organizer_Name = Organizers_Name;
        public static string get_Organizer_Name()
        { return Organizer_Name; }

        public Form_Main()
        {
          
            InitializeComponent();
             Form_Width = this.Size.Width;
            Form_Height = this.Size.Height;
            setLanguage(Classes.Class_Languag.getLanguag());
            Class_Connection class_Connection = new Class_Connection(true);
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.CommandText = "Add_Unit_Material";
            //sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value=1;
            //sqlCommand.Parameters.Add("@Unit_Name", SqlDbType.NVarChar, 50).Value = "Meter";
            //class_Connection.executeNonQuery(sqlCommand:sqlCommand);
           
        }
        
        private void Clear_BordarRoundedButton()
        {
            roundedButton_Add.BorderColor = roundedButton_Edite.BorderColor = roundedButton_Delete.BorderColor = roundedButton_Setting.BorderColor = Color.White;
        }
        private void RoundedButton1_MouseUp(object sender, MouseEventArgs e)
        {
            Clear_BordarRoundedButton();
            roundedButton_Add.BorderColor = Color.FromArgb(84, 210, 225);
        }

        private void RoundedButton2_MouseUp(object sender, MouseEventArgs e)
        {
            Clear_BordarRoundedButton();
            roundedButton_Edite.BorderColor = Color.FromArgb(84, 210, 225);
        }
        private void RoundedButton3_MouseUp(object sender, MouseEventArgs e)
        {
            Clear_BordarRoundedButton();
            roundedButton_Delete.BorderColor = Color.FromArgb(84, 210, 225);
        }
        private void RoundedButton4_MouseUp(object sender, MouseEventArgs e)
        {
            Clear_BordarRoundedButton();
            roundedButton_Setting.BorderColor = Color.FromArgb(84, 210, 225);
        }

        private void Form_Main_DoubleClick(object sender, EventArgs e)
        {
          
        }
        byte Tick_Byte = 0 ;
        private void Timer_ForAction_Tick(object sender, EventArgs e)
        {
            switch (Tick_Byte)
            {
                case 0:bunifuTransition1.HideSync(userControl_Serch1);
                    bunifuTransition1.ShowSync(userControl_ViewReport1);
                    Tick_Byte++;
                    break;
                case 1:
                    bunifuTransition1.ShowSync(userControl_Serch1);
                    bunifuTransition1.HideSync(userControl_ViewReport1);
                    Tick_Byte = 0;
                    break;
            }
        }
        private void clear_ForeColor()
        {
            roundedButton_Add.ForeColor = Color.Gray;
            roundedButton_Edite.ForeColor = Color.Gray;
            roundedButton_Delete.ForeColor = Color.Gray;
            roundedButton_Setting.ForeColor = Color.Gray;
        }
        private void RoundedButton_Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                UserControls.UserControl_Add userControlAdd = new UserControls.UserControl_Add();
                panel5.Controls.Clear();
                userControlAdd.Dock = DockStyle.Fill;
                panel5.Controls.Add(userControlAdd);
                roundedButton_Add.ForeColor = Color.FromArgb(34, 81, 149);
                clear_ForeColor();
                roundedButton_Add.ForeColor = Color.FromArgb(34, 81, 149);
            }
            catch { }
           
        }

        private void Exit_Button_Click(object sender, EventArgs e) => Application.Exit();

        private void Minimaized_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximaized_button_Click(object sender, EventArgs e)
        {
            if (this.Size.Width == Form_Width || this.Size.Height == Form_Height)//Maximaized the Form
            {
               
                this.WindowState = FormWindowState.Maximized;
                userControl_ViewReport1.Report_label1.Font = new Font("Tajawal", 38, FontStyle.Bold);
                userControl_ViewReport1.Report_label2.Font = new Font("Tajawal Medium", 24,FontStyle.Bold);
                userControl_ViewReport1.Report_label3.Font = new Font("Tajawal", 13); 
                userControl_Serch1.Serch_label1.Font = new Font("Tajawal", 38, FontStyle.Bold);
                userControl_Serch1.Serch_label2.Font = new Font("Tajawal Medium", 24, FontStyle.Bold);
                userControl_Serch1.Serch_label3.Font = new Font("Tajawal", 13);
                userControl_Serch1.Serch_label1.Size = new Size(475,94);
                userControl_Serch1.Serch_label2.Size = new Size(475,69);
                userControl_Serch1.Serch_label3.Size = new Size(475, 138);
                userControl_ViewReport1.Report_label1.Size = new Size(475,94);
                userControl_ViewReport1.Report_label2.Size = new Size(475,69);
                userControl_ViewReport1.Report_label3.Size = new Size(475, 138);
                panel3.Size = new Size(550, 449);
                panel3.Padding = new Padding(75, 75, 0, 0);
            }
            else if ((this.Size.Width > Form_Width || this.Size.Height > Form_Height) && this.Size.Width > 200)//Minimized the form to normal
            {
                this.WindowState = FormWindowState.Normal;
                userControl_ViewReport1.Report_label1.Font = new Font("Tajawal", 34, FontStyle.Bold);
                userControl_ViewReport1.Report_label2.Font = new Font("Tajawal Medium", 20, FontStyle.Bold);
                userControl_ViewReport1.Report_label3.Font = new Font("Tajawal", 12);
                userControl_Serch1.Serch_label1.Font = new Font("Tajawal", 34, FontStyle.Bold);
                userControl_Serch1.Serch_label2.Font = new Font("Tajawal Medium", 20, FontStyle.Bold);
                userControl_Serch1.Serch_label3.Font = new Font("Tajawal", 12);
                userControl_Serch1.Serch_label1.Size = new Size(407, 94);
                userControl_Serch1.Serch_label2.Size = new Size(407, 69);
                userControl_Serch1.Serch_label3.Size = new Size(407, 138);
                userControl_ViewReport1.Report_label1.Size = new Size(407, 94);
                userControl_ViewReport1.Report_label2.Size = new Size(407, 69);
                userControl_ViewReport1.Report_label3.Size = new Size(407, 138);
                panel3.Size = new Size(403, 449);
                panel3.Padding = new Padding(0, 0, 0, 0);
            }
        }
        public void setLanguage(String Languagename)
        {

            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    //Button
                    roundedButton_Add.Text = "إضافة";
                    roundedButton_Edite.Text = "تعديل";
                    roundedButton_Delete.Text = "حذف";
                    roundedButton_Setting.Text = "اعدادات";
                    //File Menu Item
                    ملفToolStripMenuItem.Text = "ملف";
                    فتحToolStripMenuItem.Text = "فتح ملف";
                    إنشاءملفجديدToolStripMenuItem.Text = "إنشاء ملف جديد";
                    قفلالبرنامجToolStripMenuItem.Text = "قفل البرنامج";
                    تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
                    تبديلالمستخدمToolStripMenuItem.Text = "تبديل المستخدم";
                    النسخالاحتياطيToolStripMenuItem.Text = "النسخ الاحتياطي";
                    نسخاحتياطيفوريToolStripMenuItem.Text = "نسخ احتياطي فوري";
                    نسخاحتياطيعلىملفToolStripMenuItem.Text = "نسخ احتياطي على ملف";
                    ادارةالنسخالأحتياطيToolStripMenuItem.Text = "ادارة النسخ الأحتياطي";
                    اعداداتالطباعةToolStripMenuItem.Text = "اعدادات الطباعة";
                    خياراتالملفToolStripMenuItem.Text = "خيارات الملف";
                    خروجToolStripMenuItem.Text = "خروج";
                    //Definitions menu Item
                    تعديلToolStripMenuItem.Text = "تعاريف";
                    بطاقةحسابToolStripMenuItem.Text = "بطاقة حساب";
                    بطاقةزبونToolStripMenuItem.Text = "بطاقة زبون";
                    بطاقةمرودToolStripMenuItem.Text = "بطاقة مورد";
                    بطاقةمستودعToolStripMenuItem.Text = "بطاقة مستودع";
                    دمجمستودعToolStripMenuItem.Text = "دمج مستودع";
                    //Item Menu Item
                    الموادToolStripMenuItem.Text = "المواد";
                    اضافةمادةToolStripMenuItem.Text = "اضافة مادة";
                    اضافةواحدةمادةToolStripMenuItem.Text = "اضافة واحدة مادة";
                    تواجدمادةToolStripMenuItem.Text = "تواجد مادة";
                    الموادالغيرنشطةToolStripMenuItem.Text = "المواد الغير نشطة";
                    بحثعنمادةToolStripMenuItem.Text = "بحث عن مادة";
                    تعديلاسعارمادةToolStripMenuItem.Text = "تعديل اسعار مادة";
                    استخداماتمادةToolStripMenuItem.Text = "استخدامات مادة";
                    //Bonds Menu Item
                    سنداتToolStripMenuItem.Text = "سندات";
                    قيدافتتاحيToolStripMenuItem.Text = "قيد افتتاحي";
                    سندقبضToolStripMenuItem.Text = "سند قبض";
                    سنددفعToolStripMenuItem.Text = "سند دفع";
                    يوميةالصندوقToolStripMenuItem.Text = "يومية الصندوق";
                    مقبوضاتالصندوقToolStripMenuItem.Text = "مقبوضات الصندوق";
                    مدفوعاتالصندوقToolStripMenuItem.Text = "مدفوعات الصندوق";
                    بحثعنسندToolStripMenuItem.Text = "بحث عن سند";
                    //Bills Menu Item
                    فواتيرToolStripMenuItem.Text = "فواتير";
                    نقطةبيعToolStripMenuItem.Text = "نقطة بيع";
                    كاشToolStripMenuItem.Text = "كاش";
                    شراءToolStripMenuItem.Text = "شراء";
                    مبيعToolStripMenuItem.Text = "مبيع";
                    مرتجعشراءToolStripMenuItem.Text = "مرتجع شراء";
                    مرتجعمبيعToolStripMenuItem.Text = "مرتجع مبيع";
                    بضاعةاولمدةToolStripMenuItem.Text = "بضاعة اول مدة";
                    مرتجعنقديToolStripMenuItem.Text = "مرتجع نقدي";
                    بحثالفواتيرToolStripMenuItem.Text = "بحث الفواتير";
                    //Reports Menu Item
                    تقاريرمخزنيةToolStripMenuItem.Text = "تقارير";
                    حركةالفواتيرتجميعيToolStripMenuItem.Text = "حركة الفواتير  - تجميعي";
                    حركةالموادتجميعيToolStripMenuItem.Text = "حركة المواد - تجميعي";
                    ارباحالموادتجميعيToolStripMenuItem.Text = "ارباح المواد - تجميعي";
                    جردالمواجToolStripMenuItem.Text = "جرد المواد";
                    صلاحيةالموادToolStripMenuItem.Text = "صلاحية المواد";
                    الموادالتالفةToolStripMenuItem.Text = "المواد التالفة";
                    دفتريوميةToolStripMenuItem.Text = "دفتر يومية";
                    ارصدةحساباتtoolStripMenuItem1.Text = "ارصدة الحسابات";
                    كشفحسابToolStripMenuItem.Text = "كشف حساب";
                    //Tools Menu Item
                    أدواتToolStripMenuItem.Text = "ادوات";

                    تعديلكلمةالمرورToolStripMenuItem.Text = "تعديل كلمة المرور";

                    //instructions Menu Item 
                    تعليماتToolStripMenuItem.Text = "تعليمات";
                    دعمفنيToolStripMenuItem.Text = "دعم فني";
                    حولالبرنامجToolStripMenuItem.Text = "حول البرنامج";
                    //Panal3 
                    panel3.RightToLeft = RightToLeft.Yes;
                    break;
                case "إنكليزي":
                case "English": 
                    //Button
                    roundedButton_Add.Text = "ADD";
                    roundedButton_Edite.Text = "MOFIFY";
                    roundedButton_Delete.Text = "DELETE";
                    roundedButton_Setting.Text = "SETTINGS";
                    //File Menu Item
                    ملفToolStripMenuItem.Text = "File"; 
                    فتحToolStripMenuItem.Text = "Open file";
                    إنشاءملفجديدToolStripMenuItem.Text = "Create new file";
                    قفلالبرنامجToolStripMenuItem.Text = "Program lock";
                    تسجيلالخروجToolStripMenuItem.Text = "Sign out";
                    تبديلالمستخدمToolStripMenuItem.Text = "Switch user";
                    النسخالاحتياطيToolStripMenuItem.Text = "Backup";
                    نسخاحتياطيفوريToolStripMenuItem.Text = "Instant backup";
                    نسخاحتياطيعلىملفToolStripMenuItem.Text = "Instant backup";
                    ادارةالنسخالأحتياطيToolStripMenuItem.Text = "Backup management";
                    اعداداتالطباعةToolStripMenuItem.Text = "Print settings";
                    خياراتالملفToolStripMenuItem.Text = "File options";
                    خروجToolStripMenuItem.Text = "Exit";
                    //Definitions menu Item
                    تعديلToolStripMenuItem.Text = "Definitions";
                    بطاقةحسابToolStripMenuItem.Text = "Account card";
                    بطاقةزبونToolStripMenuItem.Text = "Customer card";
                    بطاقةمرودToolStripMenuItem.Text = "Supplier Card";
                    بطاقةمستودعToolStripMenuItem.Text = "Warehouse card";
                    دمجمستودعToolStripMenuItem.Text = "Consolidate a warehouse";
                    //Materials Menu Item
                    الموادToolStripMenuItem.Text = "Materials";
                    اضافةمادةToolStripMenuItem.Text = "Add a subject";
                    اضافةواحدةمادةToolStripMenuItem.Text = "Add one article";
                    تواجدمادةToolStripMenuItem.Text = "Existence of material";
                    الموادالغيرنشطةToolStripMenuItem.Text = "Inactive materials";
                    بحثعنمادةToolStripMenuItem.Text = "Search for an item";
                    تعديلاسعارمادةToolStripMenuItem.Text = "Adjust the price of an item";
                    استخداماتمادةToolStripMenuItem.Text = "Uses of a substance";
                    //Bonds Menu Item
                    سنداتToolStripMenuItem.Text = "Bonds";
                    قيدافتتاحيToolStripMenuItem.Text = "An opening constraint";
                    سندقبضToolStripMenuItem.Text = "Catch ReceiptCatch Receipt";
                    سنددفعToolStripMenuItem.Text = "Payment voucher";
                    يوميةالصندوقToolStripMenuItem.Text = "Journal of the Fund";
                    مقبوضاتالصندوقToolStripMenuItem.Text = "Fund receipts";
                    مدفوعاتالصندوقToolStripMenuItem.Text = "Fund payments";
                    بحثعنسندToolStripMenuItem.Text = "Search for support";
                    //Bills Menu Item
                    فواتيرToolStripMenuItem.Text = "Bills";
                    نقطةبيعToolStripMenuItem.Text = "Selling point";
                    كاشToolStripMenuItem.Text = "Cash";
                    شراءToolStripMenuItem.Text = "Purchase";
                    مبيعToolStripMenuItem.Text = "Sale";
                    مرتجعشراءToolStripMenuItem.Text = "Returned purchase";
                    مرتجعمبيعToolStripMenuItem.Text = "Sales return";
                    بضاعةاولمدةToolStripMenuItem.Text = "Goods for the first period";
                    مرتجعنقديToolStripMenuItem.Text = "Cash back";
                    بحثالفواتيرToolStripMenuItem.Text = "Invoice search";
                    //Reports Menu Item
                    تقاريرمخزنيةToolStripMenuItem.Text = "Reports";
                    حركةالفواتيرتجميعيToolStripMenuItem.Text = "Billing Movement - Collective";
                    حركةالموادتجميعيToolStripMenuItem.Text = "Material Movement - Synthesis";
                    ارباحالموادتجميعيToolStripMenuItem.Text = "Material Profits - Collective";
                    جردالمواجToolStripMenuItem.Text = "Material inventory";
                    صلاحيةالموادToolStripMenuItem.Text = "Material validity";
                    الموادالتالفةToolStripMenuItem.Text = "Damaged items";
                    دفتريوميةToolStripMenuItem.Text = "Journal";
                    ارصدةحساباتtoolStripMenuItem1.Text = "Account balances";
                    كشفحسابToolStripMenuItem.Text = "Account statement";
                    //Tools Menu Item
                    أدواتToolStripMenuItem.Text = "Tools";
     
                    تعديلكلمةالمرورToolStripMenuItem.Text = "Password change";
       
                    //instructions Menu Item 
                    تعليماتToolStripMenuItem.Text = "instructions";
                    دعمفنيToolStripMenuItem.Text = "Technical Support";
                    حولالبرنامجToolStripMenuItem.Text = "About the program";
                    panel3.RightToLeft = RightToLeft.No;
                    break;
            }
        }

        private void RoundedButton_Edite_Click(object sender, EventArgs e)
        {
            try
            {
                UserControls.UserControl_Edite userControlEdite = new UserControls.UserControl_Edite();
                panel5.Controls.Clear();
                userControlEdite.Dock = DockStyle.Fill;
                panel5.Controls.Add(userControlEdite);
                clear_ForeColor();
                roundedButton_Edite.ForeColor = Color.FromArgb(34, 81, 149);
            }
            catch { }
        }

        private void RoundedButton_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                UserControls.UserControl_Delete UserControl_Delete = new UserControls.UserControl_Delete();
                panel5.Controls.Clear();
                UserControl_Delete.Dock = DockStyle.Fill;
                panel5.Controls.Add(UserControl_Delete);
                clear_ForeColor();
                roundedButton_Delete.ForeColor = Color.FromArgb(34, 81, 149);
            }
            catch { }
        }

        private void RoundedButton_Setting_Click(object sender, EventArgs e)
        {
            try
            {

                UserControls.UserControl_Setting  userControl_Setting= new UserControls.UserControl_Setting();
                panel5.Controls.Clear();
                userControl_Setting.Dock = DockStyle.Fill;
                panel5.Controls.Add(userControl_Setting);
                roundedButton_Setting.ForeColor = Color.FromArgb(34, 81, 149);
                clear_ForeColor();
                roundedButton_Setting.ForeColor = Color.FromArgb(34, 81, 149);
            }
            catch { }

        }

        private void حركةالفواتيرتجميعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Billing_Movement");
            form_Report.ShowDialog();
        }

        private void حركةالموادتجميعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_Movement_Synthesis");
            form_Report.ShowDialog();
        }

        private void ارباحالموادتجميعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_Profits_Collective");
            form_Report.ShowDialog();
        }

        private void جردالمواجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_inventory");
            form_Report.ShowDialog();
        }

        private void صلاحيةالموادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Material_validity");
            form_Report.ShowDialog();
        }

        private void الموادالراكدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Stagnant_material");
            form_Report.ShowDialog();
        }

        private void الموادالتالفةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Damaged_items");
            form_Report.ShowDialog();
        }

        private void دفتريوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Journal");
            form_Report.ShowDialog(); 
        }

        private void ارصدةحساباتtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Account_balances");
            form_Report.ShowDialog();
        }

        private void كشفحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Account_statement");
            form_Report.ShowDialog();
        }

        private void ارباحوخسائرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Profit_and_loss");
            form_Report.ShowDialog();
        }

        private void بطاقةحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ReferenceCalculattion form_ReferenceCalculattion = new Form_ReferenceCalculattion(Properties.Resources.business_building, بطاقةحسابToolStripMenuItem.Text);
            form_ReferenceCalculattion.ShowDialog();
        }

        private void بطاقةزبونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SupplierAndCustmer form_UserControl = new Form_SupplierAndCustmer(Properties.Resources.business_group, بطاقةزبونToolStripMenuItem.Text);
            form_UserControl.ShowDialog();
        }

        private void بطاقةمرودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SupplierAndCustmer form_UserControl = new Form_SupplierAndCustmer(Properties.Resources.business_building_2, بطاقةمرودToolStripMenuItem.Text);
            form_UserControl.ShowDialog();
        }

        private void بطاقةمستودعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Store form_Store = new Form_Store(Properties.Resources.Store, بطاقةمستودعToolStripMenuItem.Text);
            form_Store.ShowDialog();
        }

        private void اضافةمادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Item form_Item = new Form_Item(Properties.Resources.lab_items, اضافةمادةToolStripMenuItem.Text);
            form_Item.ShowDialog();
        }

        private void اضافةواحدةمادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UnitItem form_UnitItem = new Form_UnitItem(Properties.Resources.hospital_2, اضافةواحدةمادةToolStripMenuItem.Text);
            form_UnitItem.ShowDialog();
        }

        private void قيدافتتاحيToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void سندقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Receipt form_Receipt = new Form_Receipt(Properties.Resources.Receipt_Voucher, سندقبضToolStripMenuItem.Text);
            form_Receipt.ShowDialog();
        }

        private void سنددفعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Receipt form_Receipt = new Form_Receipt(Properties.Resources.Payment_Voucher, سنددفعToolStripMenuItem.Text);
            form_Receipt.ShowDialog();
        }

        private void كاشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Casher form_Casher = new Form_Casher();
            form_Casher.Show();
        }

        private void شراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(Properties.Resources.Buy, شراءToolStripMenuItem.Text);
            form_Bill.ShowDialog();
        }

        private void مبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(Properties.Resources.Sales, مبيعToolStripMenuItem.Text);
            form_Bill.ShowDialog();
        }

        private void مرتجعشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(Properties.Resources.return_Buy, مرتجعشراءToolStripMenuItem.Text);
            form_Bill.ShowDialog();
        }

        private void مرتجعمبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(Properties.Resources.Return_Selas, مرتجعمبيعToolStripMenuItem.Text);
            form_Bill.ShowDialog();
        }

        private void مرتجعنقديToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(Properties.Resources.return_Cach, مرتجعنقديToolStripMenuItem.Text);
            form_Bill.ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void الموادالغيرنشطةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_Report = new Form_Report("UserControl_Stagnant_material");
            form_Report.ShowDialog();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //Form_Login form_Login = new Form_Login();
            //this.Visible = false;
            //form_Login.ShowDialog();
            //if (!form_Login.isTrue)
            //    this.Close();
            //else
           try
            {
                this.Visible = true;
                SqlConnection sqlConnection = new SqlConnection(Class_Connection.con);
                SqlCommand sqlCommand;
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ID,Item_Name from Item where [Expiry_Date] <= '" + System.DateTime.Today.ToString("dd/MM/yyyy") + "' ", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "Add_Damaged_Item";
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(dataTable.Rows[i][0].ToString());
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    notifyIcon1.Icon = this.Icon;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.BalloonTipText = "تم إضافة المادة "+ dataTable.Rows[i][1].ToString() + " إلى المواد التالفة ";
                    notifyIcon1.BalloonTipTitle = "وجود كمية تالفة";
                    notifyIcon1.ShowBalloonTip(12);
                }
            }
            catch { }
            
        }

        private void تعديلكلمةالمرورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_User form_User = new Form_User("UserControl");
            form_User.ShowDialog();
        }

        private void نسخاحتياطيفوريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Class_Connection.con);
                SqlCommand com;
                con.Open();
                com = new SqlCommand("Backup Database pharmacy To Disk='D:\\Copy.bak' ", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم انشاء نسخة احتياطية بنجاح \n في المسار" + "D:\\Copy.bak", "نجت المهمة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException xx)
            {
                MessageBox.Show(" لا يمكن انشاء نسخة احتياطية يجب كتابة اسم النسخة والإمتداد " + xx.Message, "فشل المهمة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void نسخاحتياطيعلىملفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Class_Connection.con);
                SqlCommand com;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup Files (*.Bak ) |*.bak";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    con.Open();
                    com = new SqlCommand("Backup Database pharmacy To Disk='" + sf.FileName + "' ", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم انشاء نسخة احتياطية بنجاح \n في المسار" + sf.FileName, "نجت المهمة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException xx)
            {
                MessageBox.Show(" لا يمكن انشاء نسخة احتياطية يجب كتابة اسم النسخة والإمتداد " + xx.Message, "فشل المهمة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ادارةالنسخالأحتياطيToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form_User form_User = new Form_User("BackUPData");
            form_User.ShowDialog();
        }
    }
}

