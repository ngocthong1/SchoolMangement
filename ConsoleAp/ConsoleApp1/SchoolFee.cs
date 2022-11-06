using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SchoolFee
    {
        public int idStudent { get; set; }
        public string tuitionPaymentDate { get; set; }
        public double scholarship { get; set; }
        public SchoolFee(int idStudent, string tuitionPaymentDate, double scholarship)
        {
            this.idStudent = idStudent;
            this.tuitionPaymentDate = tuitionPaymentDate;
            this.scholarship = scholarship;
        }
        public SchoolFee()
        {
        }
        public void display()
        {
            Console.WriteLine("idStudent: " + this.idStudent);
            Console.WriteLine("tuitionPaymentDate: " + this.tuitionPaymentDate);
            Console.WriteLine("scholarship: " + this.scholarship);
        }
        public SchoolFee createSchoolfee()
        {
            SchoolFee schoolfee = new SchoolFee();
            Console.WriteLine("Please enter idStudent ");
            schoolfee.idStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter tuitionPaymentDate");
            schoolfee.tuitionPaymentDate = (Console.ReadLine());
            Console.WriteLine("Please enter scholarship");
            schoolfee.scholarship = double.Parse(Console.ReadLine());
            return schoolfee;
        }
        public SchoolFee updateIdStudent(SchoolFee schoolfee)
        {
            Console.WriteLine("Please enter your new idStudent ");
            schoolfee.idStudent = int.Parse(Console.ReadLine());
            return schoolfee;
        }
        public SchoolFee updatetuitionPaymentDate(SchoolFee schoolfee)
        {
            Console.WriteLine("Please enter tuitionPaymentDate");
            schoolfee.tuitionPaymentDate = (Console.ReadLine());
            return schoolfee;
        }
        public SchoolFee updateScholarship(SchoolFee schoolfee)
        {
            Console.WriteLine("Please enter scholarship");
            schoolfee.scholarship = double.Parse(Console.ReadLine());
            return schoolfee;
        }

    }
}
