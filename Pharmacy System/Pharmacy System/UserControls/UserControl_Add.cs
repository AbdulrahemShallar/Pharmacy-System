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
    public partial class UserControl_Add : UserControl
    {
        private Button[] buttons()
        {
            Button[] button = new Button[]
            {   AccountCard_button, CustomerCard_button,SupplierCard_button, AddStore_button , AddItem_button ,
                AddUnit_button,ReceiptVoucher_button,PaymentVoucher_button,Cash_button,BuyBill_button,SelasBill_button,
                ReturnBuyBill_button, ReturnSelesBill_button,RetrunCashBill_button
            };
             return button;
        }
       
        public UserControl_Add()
        {   
            InitializeComponent();
            setLanguage(Classes.Class_Languag.getLanguag());
        }
      
        public void setSize()
        {
            Button[] button = buttons();
            for (int i = 0; i < button.Length ; i++)
            {
                button[i].Size = new Size((this.Size.Width / 6), (this.Size.Height / 6));
                button[i].Font = new Font("Tajawal",button[i].Font.Size + 1.5f); ;
            }
        }
        public void setLanguage(String Languagename)
        {
            Button[] button = buttons();
            switch (Languagename)
            {
                case "عربي": 
                case "Arabic":
                    AccountCard_button.Text = "بطاقة حساب";
                    CustomerCard_button.Text = "بطاقة زبون";
                    SupplierCard_button.Text = "بطاقة مورد";
                    AddStore_button.Text = "بطاقة مستودع";
                    AddItem_button.Text = "اضافة مادة";
                    AddUnit_button.Text = " واحدة مادة";
                    ReceiptVoucher_button.Text = "سند قبض";
                    PaymentVoucher_button.Text = "سند دفع";
                    Cash_button.Text = "كاش";
                    BuyBill_button.Text = "فاتورة شراء";
                    SelasBill_button.Text = "فاتورة مبيع";
                    ReturnBuyBill_button.Text = "مرتجع شراء";
                    ReturnSelesBill_button.Text = "مرتجع مبيع";
                    RetrunCashBill_button.Text = "مرتجع نقدي";
                    for (int i = 0; i < button.Length; i++)
                    {
                        button[i].Font = new Font("Tajawal", 8.5f);
                    }
                    
                    break ;
                case "إنكليزي":
                case "English":
                    AccountCard_button.Text = " Account Card";
                    CustomerCard_button.Text = "Customer Card";
                    SupplierCard_button.Text = "Supplier Card";
                    AddStore_button.Text = "Add Store";
                    AddItem_button.Text = "Add Item";
                    AddUnit_button.Text = "Add Unit";
                    ReceiptVoucher_button.Text = "Receipt Voucher";
                    PaymentVoucher_button.Text = "Payment Voucher";
                    Cash_button.Text = "Cash";
                    BuyBill_button.Text = "Buy Bill";
                    SelasBill_button.Text = "Selas Bill";
                    ReturnBuyBill_button.Text = "Return BuyBill";
                    ReturnSelesBill_button.Text = "Return Seles Bill";
                    RetrunCashBill_button.Text = "Retrun Cash Bill";
                    for (int i = 0; i < button.Length; i++)
                    {
                        button[i].Font = new Font("Tajawal", 8);
                    } 
                    break;
            }
        }
        private void UserControlAdd_SizeChanged(object sender, EventArgs e)
        {
            setSize();
        }

        private void AccountCard_button_Click(object sender, EventArgs e)
        {
            Form_ReferenceCalculattion form_ReferenceCalculattion = new Form_ReferenceCalculattion(AccountCard_button.BackgroundImage, AccountCard_button.Text);
            form_ReferenceCalculattion.ShowDialog();
        }

        private void CustomerCard_button_Click(object sender, EventArgs e)
        {
            Form_SupplierAndCustmer form_UserControl = new Form_SupplierAndCustmer(CustomerCard_button.BackgroundImage,CustomerCard_button.Text);
            form_UserControl.ShowDialog();
        }

        private void SupplierCard_button_Click(object sender, EventArgs e)
        {
            Form_SupplierAndCustmer form_UserControl = new Form_SupplierAndCustmer(SupplierCard_button.BackgroundImage, SupplierCard_button.Text);
            form_UserControl.ShowDialog();
        }

        private void AddUnit_button_Click(object sender, EventArgs e)
        {
            Form_UnitItem form_UnitItem = new Form_UnitItem(AddUnit_button.BackgroundImage, AddUnit_button.Text);
            form_UnitItem.ShowDialog();
        }

        private void AddItem_button_Click(object sender, EventArgs e)
        {
            Form_Item form_Item = new Form_Item(AddItem_button.BackgroundImage, AddItem_button.Text);
            form_Item.ShowDialog();
        }

        private void AddStore_button_Click(object sender, EventArgs e)
        {
            Form_Store form_Store = new Form_Store(AddStore_button.BackgroundImage, AddStore_button.Text);
            form_Store.ShowDialog();
        }

        private void ReceiptVoucher_button_Click(object sender, EventArgs e)
        {
            Form_Receipt form_Receipt=new Form_Receipt(ReceiptVoucher_button.BackgroundImage, ReceiptVoucher_button.Text);
            form_Receipt.ShowDialog();

        }

        private void PaymentVoucher_button_Click(object sender, EventArgs e)
        {
            Form_Receipt form_Receipt = new Form_Receipt(PaymentVoucher_button.BackgroundImage, PaymentVoucher_button.Text);
            form_Receipt.ShowDialog();
        }

        private void BuyBill_button_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(BuyBill_button.BackgroundImage, BuyBill_button.Text);
            form_Bill.ShowDialog();
        }

        private void SelasBill_button_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(BuyBill_button.BackgroundImage, SelasBill_button.Text);
            form_Bill.ShowDialog();
        }

        private void ReturnBuyBill_button_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(BuyBill_button.BackgroundImage, ReturnBuyBill_button.Text);
            form_Bill.ShowDialog();
        }

        private void ReturnSelesBill_button_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(BuyBill_button.BackgroundImage, ReturnSelesBill_button.Text);
            form_Bill.ShowDialog();
        }

        private void RetrunCashBill_button_Click(object sender, EventArgs e)
        {
            Form_Bill form_Bill = new Form_Bill(BuyBill_button.BackgroundImage, RetrunCashBill_button.Text);
            form_Bill.ShowDialog();
        }

        private void Cash_button_Click(object sender, EventArgs e)
        {
            Form_Casher form_Casher = new Form_Casher();
            form_Casher.Show();
        }
    }
}
