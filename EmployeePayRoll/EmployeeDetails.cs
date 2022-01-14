using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    internal class EmployeeDetails
    {
        public static int Employee_ID { get; set; }
        public  static string Employee_Name { get; set; }
        public static  int Salary { get; set; }
        public static DateTime StartDate { get; set; }
        public static char Gender { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Employee_Address { get; set; }
        public static string Department { get; set; }
        public static float BasicPay { get; set; }
        public static float Deductions { get; set; }
        public static float Taxable_pay { get; set; }
        public static  float Tax { get; set; }
        public static float NetPay { get; set; }



    }
}
