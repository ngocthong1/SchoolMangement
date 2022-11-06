namespace ConsoleApp1
{
    internal class Grade
    {
        public int id { get; set; }
        public double gpa { get; set; }
        public int idStudent { get; set; }
        public int idSubject { get; set; }
        public Grade(double gpa, int idStudent, int idSubject)
        {
            this.gpa = gpa;
            this.idStudent = idStudent;
            this.idSubject = idSubject;
        }
        public Grade()
        {
        }
        public void display()
        {
            Console.WriteLine("id: " + this.id);
            Console.WriteLine("gpa: " + this.gpa);
            Console.WriteLine(" idStudent: " + this.idStudent);
            Console.WriteLine("idSubject: " + this.idSubject);
        }
        public Grade createGrade()
        {
            Grade grade = new Grade();
            Console.WriteLine("Please enter id");
            grade.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter gpa");
            grade.gpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter idStudent ");
            grade.idStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter subject");
            grade.idSubject = int.Parse(Console.ReadLine());
            return grade;
        }
        public Grade updateGpa(Grade grade)
        {
            Console.WriteLine("Please enter your new gpa");
            grade.gpa = double.Parse(Console.ReadLine());
            return grade;
        }
    }
}
