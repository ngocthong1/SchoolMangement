using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher : Person
    {
        public int Salary { get; set; }
        public Teacher(int id, string name, string phoneNumber, int age, int salary):base(id,name,phoneNumber,age)
        {
            this.Salary = salary;
        }
        public Teacher()
        {
        }
        public void display()
        {
            Console.WriteLine("name:" + this.Name);
            Console.WriteLine("id:" + this.ID);
            Console.WriteLine("phoneNumber:" + this.PhoneNumber);
            Console.WriteLine("age:" + this.Age);
            Console.WriteLine("salary:" + this.Salary);
        }
        public Teacher createTeacher()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Please enter id ");
            teacher.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter name");
            teacher.Name = (Console.ReadLine());
            Console.WriteLine("Please enter phoneNumber");
            teacher.PhoneNumber = (Console.ReadLine());
            Console.WriteLine("Please enter age");
            teacher.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter salary");
            teacher.Salary = int.Parse(Console.ReadLine());
            return teacher;
        }
        public Teacher updateId(Teacher teacher)
        {
            Console.WriteLine("Please enter your new id ");
            teacher.ID = int.Parse(Console.ReadLine());

            return teacher;
        }
        public Teacher updateName(Teacher teacher)
        {
            Console.WriteLine("Please enter your new name");
            teacher.Name = (Console.ReadLine());

            return teacher;
        }

        public Teacher updatePhoneNumber(Teacher teacher)
        {
            Console.WriteLine("Please enter your new phoneNumber");
            teacher.PhoneNumber = (Console.ReadLine());

            return teacher;
        }

        public Teacher updateAge(Teacher teacher)
        {
            Console.WriteLine("Please enter your new age");
            teacher.Age = int.Parse(Console.ReadLine());

            return teacher;
        }

        public Teacher updateSalary(Teacher teacher)
        {
            Console.WriteLine("Please enter your new salary");
            teacher.Salary = int.Parse(Console.ReadLine());

            return teacher;
        }



    }
}
