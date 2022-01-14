using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeePayRoll
{
    internal class SqlConnect
    {
        public void PayRoll()
        { 
           string connectionstring = "Data Source=DESKTOP-FC404HQ\\SQLEXPRESS;Initial Catalog=payroll_service;Integrated Security=True";
           
            
                EmployeeDetails details = new EmployeeDetails();
                using (SqlConnection connect = new SqlConnection(connectionstring)
)
                {
                    string query = @"SELECT Employee_ID,Employee_Name,Salary,StartDate, Gender, PhoneNumber,
                Employee_Address,Department,BasicPay, Deductions, Taxable_pay,Tax,NetPay FROM employee_payroll;";

                    //sql command object defining
                    SqlCommand cmd = new SqlCommand(query, connect);
                     connect.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                 
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        EmployeeDetails.Employee_ID = dr.GetInt32(0);
                        EmployeeDetails.Employee_Name = dr.GetString(1);
                        EmployeeDetails.Salary = dr.GetInt32(2);
                        EmployeeDetails.StartDate = dr.GetDateTime(3);
                        EmployeeDetails.Gender = Convert.ToChar(dr.GetInt32(4));
                        EmployeeDetails.PhoneNumber = dr.GetString(5);
                        EmployeeDetails.Employee_Address = dr.GetString(6);
                        EmployeeDetails.Department = dr.GetString(7);
                        EmployeeDetails.BasicPay = dr.GetInt32(8);
                        EmployeeDetails.Deductions = dr.GetInt32(9);
                        EmployeeDetails.Taxable_pay = dr.GetInt32(10);
                        EmployeeDetails.NetPay = dr.GetInt32(11);

                    }
                }
                else
                {
                    Console.WriteLine("NO DATA FOUND");
                }
                dr.Close();
                connect.Close();//closing connnection
                }
          

          
        }
    }
}

