using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public double gpa { get; set; }
        public Student(int id, string name, string phoneNumber, int age, double gpa):base(id,name,phoneNumber,age)
        {
            this.gpa = gpa;
        }
        public Student()
        {
        }
        public void display()
        {
            Console.WriteLine("name:" + this.Name);
            Console.WriteLine("id:" + this.ID);
            Console.WriteLine("phoneNumber:" + this.PhoneNumber);
            Console.WriteLine("age:" + this.Age);
            Console.WriteLine("gpa:" + this.gpa);
        }
        public Student createStudent()
        {
            Student student = new Student();
            Console.WriteLine("Please enter gpa");
            student.gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter id ");
            student.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter name");
            student.Name = (Console.ReadLine());
            Console.WriteLine("Please enter phoneNumber");
            student.PhoneNumber = (Console.ReadLine());
            Console.WriteLine("Please enter age");
            student.Age = int.Parse(Console.ReadLine());

            return student;

        }
        public Student updateName(Student student)
        {
            Console.WriteLine("Please enter your new name");
            student.Name = (Console.ReadLine());

            return student;

        }
        public Student updateGpa(Student student)
        {
            Console.WriteLine("Please enter your new gpa");
            student.gpa = double.Parse(Console.ReadLine());

            return student;
        }
        public Student updateId(Student student)
        {
            Console.WriteLine("Please enter your new id ");
            student.ID = int.Parse(Console.ReadLine());

            return student;
        }
        public Student updatePhoneNumber(Student student)
        {
            Console.WriteLine("Please enter your new phoneNumber");
            student.PhoneNumber = (Console.ReadLine());

            return student;
        }
        public Student updateAge(Student student)
        {
            Console.WriteLine("Please enter your new age");
            student.Age = int.Parse(Console.ReadLine());

            return student;
        }


    }

}
