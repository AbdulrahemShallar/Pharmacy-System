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
    public partial class UserControl_Serch : UserControl
    {   
         
        public UserControl_Serch()
        {
            InitializeComponent();
            setLanguage(Classes.Class_Languag.getLanguag());
        }

        private void RoundedButton_Serch_Click(object sender, EventArgs e)
        {
            From_CheakSersh from_CheakSersh = new From_CheakSersh();
            from_CheakSersh.ShowDialog();
        }

        public void setLanguage(String Languagename)
        {
        
            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    Serch_label1.RightToLeft = RightToLeft.Yes;
                    Serch_label2.RightToLeft = RightToLeft.Yes;
                    Serch_label3.RightToLeft = RightToLeft.Yes;
                    Serch_label1.Text = "البحث";
                    Serch_label2.Text = "سهولة البحث";
                    Serch_label3.Text = "البحث عن دواء محدد والوصول الى موقعه المسجل في اي مستودع بكل سهولة و دقة وذلك تبعا لما يمليه المستخدم في عملية البحث حيث يمكنه من البحث حسب اسم الدواء او اسم  الباركود وحتة يمكن البحث حسب رقم الدواء.";
                    roundedButton_Serch.Text = "بحث";
                    break;
                case "إنكليزي":
                case "English":
                    Serch_label1.RightToLeft = RightToLeft.No;
                    Serch_label2.RightToLeft = RightToLeft.No;
                    Serch_label3.RightToLeft = RightToLeft.No;
                    Serch_label1.Text = "Serch";
                    Serch_label2.Text = "Ease of searching";
                    Serch_label3.Text = "Searching for a specific drug and accessing its registered location in any warehouse with ease and accuracy, according to what the user dictates in the search process, as it enables him to search by drug name or barcode name, and even it can search by drug number.";
                    roundedButton_Serch.Text = "Serch";
                    break;
            }
        }
    }
}
