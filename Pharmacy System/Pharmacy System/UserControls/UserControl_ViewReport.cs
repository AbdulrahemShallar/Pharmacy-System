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
    public partial class UserControl_ViewReport : UserControl
    {
        public UserControl_ViewReport()
        {
            InitializeComponent();
            setLanguage(Classes.Class_Languag.getLanguag());

        }
        public void setLanguage(String Languagename)
        {

            switch (Languagename)
            {
                case "عربي":
                case "Arabic":
                    Report_label1.RightToLeft = RightToLeft.Yes;
                    Report_label2.RightToLeft = RightToLeft.Yes;
                    Report_label3.RightToLeft = RightToLeft.Yes;
                    Report_label1.Text = "تقارير";
                    Report_label2.Text = "أنواع التقارير";
                    Report_label3.Text = "تتكون التقارير من عدد من الانواع التي تساعد في اداء عمل بشل سريع ودقيق ومنه اتقارير الموادالتالفة وتقارير الموستدوعات وتقارير الزبائن والموردين وغيرها من التقارير التي ترفع من سوية العمل وسرعته الزمنية وكفائته الانتاجية.";
                    roundedButton_Report.Text = "عرض";
                    break;
                case "إنكليزي":
                case "English":
                    Report_label1.RightToLeft = RightToLeft.No;
                    Report_label2.RightToLeft = RightToLeft.No;
                    Report_label3.RightToLeft = RightToLeft.No;
                    Report_label1.Text = "Reports";
                    Report_label2.Text = "Types of reports";
                    Report_label3.Text = "Reports consist of a number of types that help in performing work in a fast and accurate manner, including reports of damaged materials, reports of dispatches, reports of customers and suppliers, and other reports that raise the level of work, its speed of time, and its production efficiency.";
                    roundedButton_Report.Text = "Show";
                    break;
            }
        }

        private void RoundedButton_Report_Click(object sender, EventArgs e)
        {
            Form_ChosenReport form_ChosenReport = new Form_ChosenReport();
            form_ChosenReport.ShowDialog();
        }
    }
}
