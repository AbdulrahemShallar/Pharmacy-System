using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.UserControls
{
    public partial class UserControl_Edite : UserControl
    {
        public UserControl_Edite()
        {
            InitializeComponent();
            setLanguage(Classes.Class_Languag.getLanguag());
        }
        private Button[] buttons()
        {
            Button[] button = new Button[]
            {   AccountCard_button, CustomerCard_button,SupplierCard_button, AddStore_button , AddItem_button ,
                AddUnit_button,ReceiptVoucher_button,PaymentVoucher_button,SelasBill_button,BuyBill_button,
                ReturnBuyBill_button, ReturnSelesBill_button,RetrunCashBill_button
            };
            return button;
        }
        public void setSize()
        {
            Button[] button = buttons();
            for (int i = 0; i < button.Length; i++)
            {
                button[i].Size = new Size((this.Size.Width / 6), (this.Size.Height / 6));
                button[i].Font = new Font("Tajawal", button[i].Font.Size + 1.5f); ;
            }
        }
        public void setLanguage(String Languagename)
        {
            Button[] button = buttons();
            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    AccountCard_button.Text = "بيانات حساب";
                    CustomerCard_button.Text = "بطاقة زبون";
                    SupplierCard_button.Text = "بطاقة مورد";
                    AddStore_button.Text = "بطاقة مستودع";
                    AddItem_button.Text = "بيانات مادة";
                    AddUnit_button.Text = " واحدة مادة";
                    ReceiptVoucher_button.Text = "سند قبض";
                    PaymentVoucher_button.Text = "سند دفع";
                    BuyBill_button.Text = " فاتورة شراء";
                    SelasBill_button.Text = "فاتورة مبيع";
                    ReturnBuyBill_button.Text = "مرتجع شراء";
                    ReturnSelesBill_button.Text = "مرتجع مبيع";
                    RetrunCashBill_button.Text = "مرتجع نقدي";
                    for (int i = 0; i < button.Length; i++)
                    {
                        button[i].Font = new Font("Tajawal", 8.5f);
                    }

                    break;
                case "إنكليزي":
                case "English":
                    AccountCard_button.Text = " Account Info";
                    CustomerCard_button.Text = "Customer Card";
                    SupplierCard_button.Text = "Supplier Card";
                    AddStore_button.Text = "Modifi Store";
                    AddItem_button.Text = "Modifi Item";
                    AddUnit_button.Text = "Modifi Unit";
                    ReceiptVoucher_button.Text = "Receipt Voucher";
                    PaymentVoucher_button.Text = " Payment Voucher";
                    BuyBill_button.Text = "BuyBill";
                    SelasBill_button.Text = "SelasBill";
                    ReturnBuyBill_button.Text = "ReturnBuyBill";
                    ReturnSelesBill_button.Text = "Return Seles Bill";
                    RetrunCashBill_button.Text = "Retrun Cash Bill";
                    for (int i = 0; i < button.Length; i++)
                    {
                        button[i].Font = new Font("Tajawal", 8);
                    }
                    break;
            }
        }
        private void UserControlEdite_SizeChanged(object sender, EventArgs e)
        {
            setSize();
        }

        private void AddItem_button_Click(object sender, EventArgs e)
        {
            UpdateAndDelete.UpdateDeleteItem_Form updateDeleteItem_Form = new UpdateAndDelete.UpdateDeleteItem_Form(AddItem_button.BackgroundImage, "تعديل مادة");
            updateDeleteItem_Form.ShowDialog();
        }

        private void AddUnit_button_Click(object sender, EventArgs e)
        {
            UpdateAndDelete.UpdateDeleteUnitItem_Form updateDeleteUnitItem_Form = new UpdateAndDelete.UpdateDeleteUnitItem_Form(AddUnit_button.BackgroundImage, "تعديل واحدة");
            updateDeleteUnitItem_Form.ShowDialog();
        }

        private void CustomerCard_button_Click(object sender, EventArgs e)
        {
            UpdateAndDelete.UpdateDeleteSupplier_Form updateDeleteSupplier_Form = new UpdateAndDelete.UpdateDeleteSupplier_Form(AddUnit_button.BackgroundImage, "تعديل حساب زبون");
            updateDeleteSupplier_Form.ShowDialog();
        }

        private void SupplierCard_button_Click(object sender, EventArgs e)
        {
            UpdateAndDelete.UpdateDeleteSupplier_Form updateDeleteSupplier_Form = new UpdateAndDelete.UpdateDeleteSupplier_Form(AddUnit_button.BackgroundImage, "تعديل حساب المورد");
            updateDeleteSupplier_Form.ShowDialog();
        }

        private void AccountCard_button_Click(object sender, EventArgs e)
        {
            UpdateAndDelete.UpdateDeleteReferenceCalculattion_Form updateDeleteReferenceCalculattion_Form = new UpdateAndDelete.UpdateDeleteReferenceCalculattion_Form(AddUnit_button.BackgroundImage, "تعديل بيانات حساب");
            updateDeleteReferenceCalculattion_Form.ShowDialog();
        }

        private void AddStore_button_Click(object sender, EventArgs e)
        {
            UpdateAndDelete.UpdateDeleteStore_Form updateDeleteStore_Form = new UpdateAndDelete.UpdateDeleteStore_Form(AddUnit_button.BackgroundImage, "تعديل مستودع");
            updateDeleteStore_Form.ShowDialog();
        }
    }
}
