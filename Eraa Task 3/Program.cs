using System.Xml.Linq;

namespace Eraa_Task_3
{
    class Student
    {


        public int studentId;
        public string name;
        public int age;

        List<Course> Courses = new List<Course>();

        public Student(int studentId, string name, int age)
        {
            this.studentId = studentId;
            this.name = name;
            this.age = age;
        }
        public bool Enroll(Course course)
        {
            
            Courses.Add(course);
            return true;
        }
        public string PrintDetails()
        {
            string CoursesName = "";
            for (int i = 0; i < Courses.Count; i++)
            {
                CoursesName += Courses[i].title;
            }
            return null;
        }
    }

    class Instructor
    {
        public int instructorId;
        public string name;
        public string specialization;

        public Instructor(int instructorId, string name, string specialization)
        {
            this.instructorId = instructorId;
            this.name = name;
            this.specialization = specialization;
        }
        public string PrintDetails()
        {
            return  null;
        }
    }

    class Course
    {
        public int courseId;
        public string coursesName;
        public string title;
        public Instructor instructor;

        public Course(int courseId, string title, Instructor instructor)
        {
            this.courseId = courseId;
            this.title = title;
            this.instructor = instructor;
        }
        public string PrintDetails()
        {
            return null;
        }
    }
    class School
    {
        public List<Student> Students = new List<Student>();
        public List<Course> Courses = new List<Course>();
        public List<Instructor> Instructors = new List<Instructor>();

        public bool AddStudent(Student student)
        {
            Students.Add(student);
            return true;
        }
        public bool AddCourse(Course course)
        {
           
            Courses.Add(course);
            return true;
        }
        public bool AddInstructor(Instructor instructor)
        {
            
            Instructors.Add(instructor);
            return true;
        }
        public Student FindStudent(int studentId)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].studentId == studentId)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public Student FindStudent(string name)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].name == name)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public Course FindCourse(int courseId)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].courseId == courseId)
                {
                    return Courses[i];
                }
            }
            return null;
        }
        public Instructor FindInstructor(int instructorId)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].instructorId == instructorId)
                {
                    return Instructors[i];
                }
            }
            return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            School s = new School();
            int number;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructure");
                Console.WriteLine("3. Add Corse");
                Console.WriteLine("4. Entrol Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("1. Show All Courses");
                Console.WriteLine("1. Show All Instructure");
                Console.WriteLine("1. Find the student by id or name");
                Console.WriteLine("1. Find the Courses by id or name");
                Console.WriteLine("10. Exit");

                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.Write("Enter Student ID");
                        int StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student Name");
                        string StudentName = Console.ReadLine();
                        Console.Write("Enter Student Age");
                        int StudentAge = Convert.ToInt32(Console.ReadLine());

                        Student newStudent = new Student(StudentId, StudentName, StudentAge);
                        s.AddStudent(newStudent);
                        break;
                    case 2:
                        Console.Write("Enter Instructor ID");
                        int InstructorId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Instructor Name");
                        string InstructorName = Console.ReadLine();
                        Console.Write("Enter Specialization");
                        string InstructorSpec = Console.ReadLine();

                        Instructor newInstructor = new Instructor(InstructorId, InstructorName, InstructorSpec);
                        s.AddInstructor(newInstructor);
                        break;
                    case 3:
                        Console.Write("Enter Course ID");
                        int CourseId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course Title");
                        string CourseTitle = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter Student ID: ");
                        int EntroStudentlId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course ID: ");
                        int EntrolCourseId = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        for (int i = 0; i < s.Students.Count; i++)
                        {
                            Console.WriteLine(s.Students[i].PrintDetails());
                        }
                        break;
                    case 6:
                        for (int i = 0; i < s.Courses.Count; i++)
                        {
                            Console.WriteLine(s.Courses[i].PrintDetails());
                        }
                        break;
                    case 7:
                        for (int i = 0; i < s.Instructors.Count; i++)
                        {
                            Console.WriteLine(s.Instructors[i].PrintDetails());
                        }
                        break;
                    case 8:
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine();
                        break;
                    case 10:
                        break;
                }
            } while (number != 10);
        }
    }
}
