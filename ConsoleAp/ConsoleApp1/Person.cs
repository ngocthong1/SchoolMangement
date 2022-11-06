using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private int _id;
        private string _name;
        private string _phoneNumber;
        private int _age;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public Person(int id, string name, string phoneNumber, int age)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age;
        }
        public Person()
        {

        }

    }
}
