using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_System.Classes
{
    class Class_Languag
    {

        private static string Languag = "Arabic";
        //private static string Languag = "English";
        public static void setLanguag(string languag)
        {
            Languag = languag;
        }
        public static string getLanguag()
        {
            return Languag;
        }
    }
}
