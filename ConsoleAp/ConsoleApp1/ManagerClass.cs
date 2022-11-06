namespace ConsoleApp1
{
    internal class ManagerClass : IManagement
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Room> rooms;
        private List<SchoolFee> schoolFees;
        private List<Subject> subjects;
        private List<Grade> grades;


        // Singleton design pattern
        private static ManagerClass schoolManagement = new ManagerClass();
        private ManagerClass()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            rooms = new List<Room>();
            schoolFees = new List<SchoolFee>();
            subjects = new List<Subject>();
            grades = new List<Grade>();
        }
        public static ManagerClass getInstance()
        {
            return schoolManagement;
        }



        // Polymorphism
        private void add(Student student)
        {
            students.Add(student);
        }
        private void add(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        private void add(Room room)
        {
            rooms.Add(room);
        }
        private void add(SchoolFee schoolFee)
        {
            schoolFees.Add(schoolFee);
        }
        private void add(Grade grade)
        {
            grades.Add(grade);
        }
        private void add(Subject subject)
        {
            subjects.Add(subject);
        }




        // Create
        public void controlCreate()
        {
            Console.WriteLine("Vui long nhap option: ");
            int option = int.Parse(Console.ReadLine());
            if (option == 7)
            {
                return;
            }
            switch (option)
            {
                case 1:
                    {
                        Student student = new Student().createStudent();
                        add(student);
                        break;
                    }
                case 2:
                    {
                        Teacher teacher = new Teacher().createTeacher();
                        add(teacher);
                        break;
                    }
                case 3:
                    {
                        Subject subject = new Subject().createSubject();
                        add(subject);
                        break;
                    }
                case 4:
                    {
                        SchoolFee schoolFee = new SchoolFee().createSchoolfee();
                        add(schoolFee);
                        break;
                    }
                case 5:
                    {
                        Grade grade = new Grade().createGrade();
                        add(grade);
                        break;
                    }
                case 6:
                    {
                        Room room = new Room().createRoom();
                        add(room);
                        break;
                    }
            }
            Console.WriteLine("Add succesful!!!");
        }

        // view list

        private void ViewListStudent()
        {
            Console.WriteLine("List of students: ");
            foreach (Student student in students)
            {
                student.display();
            }
        }
        private void ViewListTeacher()
        {
            Console.WriteLine("List of teachers");

            foreach (Teacher teacher in teachers)
            {
                teacher.display();
            }
        }
        private void ViewListGrade()
        {
            Console.WriteLine("List of Grades");

            foreach (Grade grade in grades)
            {
                grade.display();
            }
        }
        private void ViewListRoom()
        {
            Console.WriteLine("List of rooms");
            foreach (Room room in rooms)
            {
                room.display();
            }
        }
        private void ViewListSubject()
        {
            Console.WriteLine("List of subject");
            foreach (Subject subject in subjects)
            {
                subject.display();
            }
        }
        private void ViewListSchoolFee()
        {
            Console.WriteLine("List of school fee");
            foreach (SchoolFee schoolFee in schoolFees)
            {
                schoolFee.display();
            }
        }

        // Check exist ID
        private bool checkIdStudent(int id)
        {
            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkIdTeacher(int id)
        {
            foreach (Teacher teacher in teachers)
            {
                if (teacher.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkIdRoom(int id)
        {
            foreach (Room room in rooms)
            {
                if (room.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkIdGrade(int id)
        {
            foreach (Grade grade in grades)
            {
                if (grade.id == id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkIdSubject(int id)
        {
            foreach (Subject subject in subjects)
            {
                if (subject.id == id)
                {
                    return true;
                }
            }
            return false;
        }
        // find by id

        private void findStudent(int id)
        {
            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    student.display();
                }
            }
        }
        private void findTeacher(int id)
        {
            foreach (Teacher teacher in teachers)
            {
                if (teacher.ID == id)
                {
                    teacher.display();
                }
            }
        }

        private void findSubject(int id)
        {
            foreach (Subject subject in subjects)
            {
                if (subject.id == id)
                {
                    subject.display();
                }
            }
        }

        private void findRoom(int id)
        {
            foreach (Room room in rooms)
            {
                if (room.id == id)
                {
                    room.display();
                }
            }
        }
        // find by id
        private void findSchoolFeeOfAstudent(int id)
        {
            foreach (SchoolFee schoolFee in schoolFees)
            {
                if (schoolFee.idStudent == id)
                {
                    schoolFee.display();
                }
            }
        }
        private void findGradeOfAstudent(int id)
        {
            foreach (Grade grade in grades)
            {
                if (grade.idStudent == id)
                {
                    grade.display();
                }
            }
        }


        public void controlView()
        {
            Console.WriteLine("Please enter your choice: ");
            int option = int.Parse(Console.ReadLine());
            if (option == 7)
            {
                return;
            }
            switch (option)
            {
                case 1:
                    {
                        ViewListStudent();
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        ViewListTeacher();
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        ViewListSubject();
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        ViewListSchoolFee();
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        ViewListGrade();
                        Console.ReadKey();
                        break;
                    }
                case 6:
                    {
                        ViewListRoom();
                        Console.ReadKey();
                        break;
                    }
            }
        }
        public void controlFind()
        {
            Console.WriteLine("Please enter your option: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter ID:");
            int id = int.Parse(Console.ReadLine());
            bool exit = false;
            switch (option)
            {
                case 1:
                case 4:
                case 5:
                    {
                        exit = checkIdStudent(id);
                        break;
                    }
                case 2:
                    {
                        exit = checkIdTeacher(id);
                        break;
                    }
                case 3:
                    {
                        exit = checkIdSubject(id);
                        break;
                    }
                case 6:
                    {
                        exit = checkIdRoom(id);
                        break;
                    }
            }
            if (!exit)
            {
                Console.WriteLine("ID not found");
                return;
            }
            switch (option)
            {
                case 1:
                    {
                        findStudent(id);
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        findTeacher(id);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        findSubject(id);
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        findSchoolFeeOfAstudent(id);
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        findGradeOfAstudent(id);
                        Console.ReadKey();
                        break;
                    }
                case 6:
                    {
                        findRoom(id);
                        Console.ReadKey();
                        break;
                    }
            }
        }

        private void updateStudent()
        {
            Console.WriteLine("Update Student");
            Console.WriteLine("option 1: update id");
            Console.WriteLine("option 2: update name");
            Console.WriteLine("option 3: update gpa");
            Console.WriteLine("option 4: update phone number");
            Console.WriteLine("option 5: update age");
            Console.WriteLine("option 6: quit");

            Console.WriteLine("option: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("id: ");
            int id = int.Parse(Console.ReadLine());
            if (checkIdStudent(id) == false)
            {
                Console.WriteLine("id not exit");
            }
            else
            {
                for (int i = 0; i < students.Count(); i++)
                {
                    if (students[i].ID == id)
                    {
                        switch (option)
                        {
                            case 1:
                                {
                                    students[i] = students[i].updateId(students[i]);
                                    break;
                                }
                            case 2:
                                {
                                    students[i] = students[i].updateName(students[i]);
                                    break;
                                }
                            case 3:
                                {
                                    students[i] = students[i].updateGpa(students[i]);
                                    break;
                                }
                            case 4:
                                {
                                    students[i] = students[i].updatePhoneNumber(students[i]);
                                    break;
                                }
                            case 5:
                                {
                                    students[i] = students[i].updateAge(students[i]);
                                    break;
                                }
                        }
                    }
                }
            }
        }
        private void updateTeacher()
        {
            Console.WriteLine("update teacher");
            Console.WriteLine("option 1: update id");
            Console.WriteLine("option 2: update name");
            Console.WriteLine("option 3: update salary");
            Console.WriteLine("option 4: update phone number");
            Console.WriteLine("option 5: update age");
            Console.WriteLine("option 6: quit");
            Console.WriteLine("option: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("id: ");
            int id = int.Parse(Console.ReadLine());
            if (checkIdTeacher(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < teachers.Count(); i++)
                {
                    if (teachers[i].ID == id)
                    {
                        switch (option)
                        {
                            case 1:
                                {
                                    teachers[i] = teachers[i].updateId(teachers[i]);
                                    break;
                                }
                            case 2:
                                {
                                    teachers[i] = teachers[i].updateName(teachers[i]);
                                    break;
                                }
                            case 3:
                                {
                                    teachers[i] = teachers[i].updateSalary(teachers[i]);
                                    break;
                                }
                            case 4:
                                {
                                    teachers[i] = teachers[i].updatePhoneNumber(teachers[i]);
                                    break;
                                }
                            case 5:
                                {
                                    teachers[i] = teachers[i].updateAge(teachers[i]);
                                    break;
                                }
                        }
                    }
                }
            }
        }
        private void updateSubject()
        {
            Console.WriteLine("update Subject");
            Console.WriteLine("option 1: update id");
            Console.WriteLine("option 2: update room");
            Console.WriteLine("option 3: update teacher");

            Console.WriteLine("option: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("id: ");
            int id = int.Parse(Console.ReadLine());
            if (checkIdSubject(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < subjects.Count; i++)
                {
                    if (subjects[i].id == id)
                    {
                        switch (option)
                        {
                            case 1:
                                {
                                    subjects[i] = subjects[i].updateIdSubject(subjects[i]);
                                    break;
                                }
                            case 2:
                                {
                                    subjects[i] = subjects[i].updateIdRoom(subjects[i]);
                                    break;
                                }
                            case 3:
                                {
                                    subjects[i] = subjects[i].updateIdTeacher(subjects[i]);
                                    break;
                                }
                        }
                    }
                }
            }
        }
        private void updateGrade()
        {
            Console.WriteLine("update Grade");
            Console.WriteLine("id: ");
            int id = int.Parse(Console.ReadLine());
            if (checkIdGrade(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                for (int i = 0; i < grades.Count; i++)
                {
                    if (grades[i].id == id)
                    {
                        grades[i] = grades[i].updateGpa(grades[i]);
                    }
                }
            }
        }
        private void updateRoom()
        {
            Console.WriteLine("update Grade");
            Console.WriteLine("id: ");
            int id = int.Parse(Console.ReadLine());
            if (checkIdRoom(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {

            }

        }

        public void ControllUpdate()
        {
            Console.WriteLine("Please enter your option: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        updateStudent();
                        break;
                    }
                case 2:
                    {
                        updateTeacher();
                        break;
                    }
                case 3:
                    {
                        updateSubject();
                        break;
                    }
                case 4:
                    {
                        updateGrade();
                        break;
                    }
                case 5:
                    {
                        updateRoom();
                        break;
                    }
            }
        }



        private void removeStudent()
        {
            Console.Write("enter id student: ");
            int id = int.Parse((Console.ReadLine()));
            if (checkIdStudent(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                Student studentSave = students[0];

                foreach (Student student in students)
                {
                    if (student.ID == id)
                    {
                        studentSave = student;
                    }
                }

                students.Remove(studentSave);
                Console.WriteLine("Delete succesful");
            }


        }
        private void removeTeacher()
        {
            Console.Write("enter id Teacher: ");
            int id = int.Parse((Console.ReadLine()));
            if (checkIdTeacher(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                Teacher teacherSave = teachers[0];

                foreach (Teacher teacher in teachers)
                {
                    if (teacher.ID == id)
                    {
                        teacherSave = teacher;
                    }
                }

                teachers.Remove(teacherSave);

                Console.WriteLine("Delete succesful");
            }

        }


        private void removeSubject()
        {
            Console.Write("enter id subjct: ");
            int id = int.Parse((Console.ReadLine()));
            if (checkIdSubject(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                Subject subjectSave = subjects[0];

                foreach (Subject subject in subjects)
                {
                    if (subject.id == id)
                    {
                        subjectSave = subject;
                    }
                }

                subjects.Remove(subjectSave);

                Console.WriteLine("Delete succesful");
            }

        }


        private void removeRoom()
        {
            Console.Write("enter id room: ");
            int id = int.Parse((Console.ReadLine()));
            if (checkIdRoom(id) == false)
            {
                Console.WriteLine("id not exit");
                Console.ReadKey();
            }
            else
            {
                Room roomSave = rooms[0];

                foreach (Room room in rooms)
                {
                    if (room.id == id)
                    {
                        roomSave = room;
                    }
                }

                rooms.Remove(roomSave);

                Console.WriteLine("Delete succesful");
            }

        }


        private void removeGrade()
        {
            Console.Write("enter id Grade: ");
            int id = int.Parse((Console.ReadLine()));
            if (checkIdGrade(id) == false)
            {
                Console.WriteLine("id not exit");
                return;
            }

            Grade gradeSave = grades[0];

            foreach (Grade grade in grades)
            {
                if (grade.id == id)
                {
                    gradeSave = grade;
                }
            }

            grades.Remove(gradeSave);

            Console.WriteLine("Delete succesful");
        }


        public void controlDelete()
        {
            Console.WriteLine("Please enter your choice: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        removeStudent();
                        break;
                    }
                case 2:
                    {
                        removeTeacher();
                        break;
                    }
                case 3:
                    {
                        removeSubject();
                        break;
                    }
                case 4:
                    {
                        removeGrade();
                        break;
                    }
                case 5:
                    {
                        removeRoom();
                        break;
                    }
            }
        }

        public void MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. View");
            Console.WriteLine("2. Create");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Find");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
        }

        public void MenuView()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. View list of student");
            Console.WriteLine("2. View list of teacher");
            Console.WriteLine("3. View list of subject");
            Console.WriteLine("4. View list of schoolfee");
            Console.WriteLine("5. View list of grade");
            Console.WriteLine("6. View list of room");
            Console.WriteLine("7. Exit" +
                "");
        }
        public void MenuAdd()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add teacher");
            Console.WriteLine("3. Add subject");
            Console.WriteLine("4. Add schoolfee");
            Console.WriteLine("5. Add grade");
            Console.WriteLine("6. Add room");
            Console.WriteLine("7. Exit");
        }
        public void MenuUpdate()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Update student");
            Console.WriteLine("2. Update teacher");
            Console.WriteLine("3. Update subject");
            Console.WriteLine("4. Update grade");
            Console.WriteLine("5. Update room");
            Console.WriteLine("6. Exit");
        }
        public void MenuDelete()
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Delete student");
            Console.WriteLine("2. Delete teacher");
            Console.WriteLine("3. Delete subject");
            Console.WriteLine("4. Delete schoolfee");
            Console.WriteLine("5. Delete grade");
            Console.WriteLine("6. Delete room");
            Console.WriteLine("7. Exit");
        }
        public void MenuFind()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Find student");
            Console.WriteLine("2. Find teacher");
            Console.WriteLine("3. Find subject");
            Console.WriteLine("4. Find student's schoolfee");
            Console.WriteLine("5. Find student's grade ");
            Console.WriteLine("6. Find room");
            Console.WriteLine("7. Exit");
        }

    }
}
