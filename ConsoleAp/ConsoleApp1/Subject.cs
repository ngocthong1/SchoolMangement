using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Subject
    {
        public int id { get; set; }
        public int idRoom { get; set; }
        public int idTeacher { get; set; }
        public Subject(int idSubject, int idRoom, int idTeacher)
        {
            this.id = idSubject;
            this.idRoom = idRoom;
            this.idTeacher = idTeacher;
        }
        public Subject()
        {
        }
        public void display()
        {
            Console.WriteLine("idSubject: " + this.id);
            Console.WriteLine("id Room: " + this.idRoom);
            Console.WriteLine("idTeacher" + this.idTeacher);
        }
        public Subject createSubject()
        {
            Subject subject = new Subject();
            Console.WriteLine(" Please enter idSubject");
            subject.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter idRoom");
            subject.idRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter idTeacher");
            subject.idTeacher = int.Parse(Console.ReadLine());
            return subject;
        }
        public Subject updateIdSubject(Subject subject)
        {
            Console.WriteLine(" Please enter your new idSubject");
            subject.id = int.Parse(Console.ReadLine());
            return subject;
        }
        public Subject updateIdRoom(Subject subject)
        {
            Console.WriteLine("Please enter your new idRoom");
            subject.idRoom = int.Parse(Console.ReadLine());
            return subject;
        }
        public Subject updateIdTeacher(Subject subject)
        {
            Console.WriteLine("Please enter your new idTeacher");
            subject.idTeacher = int.Parse(Console.ReadLine());
            return subject;
        }


    }
}
