using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagementSystems
{
    internal class Program
    {
        //Static variables for student information
        static int studentId;
        static string studentName;

        //Static variables for grades
        static int gradeFirst;
        static int gradeSecond;
        static int gradeTotal;


        // Console application entry point
        public static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            if (students.Any(s => s.Id == id))
            {
                Console.WriteLine("Student with this ID already exists.");
                return;
            }

            students.Add(new Student(id, name));
            Console.WriteLine("Student added successfully.");
        }

        public static void AddGrades()
        {
            Console.Write("Enter Student ID to add grades: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            Console.Write("Enter Subject Name: ");
            string subject = Console.ReadLine();

            Console.Write("Enter Grade: ");
            if (!int.TryParse(Console.ReadLine(), out int grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade! Enter a number between 0 and 100.");
                return;
            }

            student.AddGrade(subject, grade);
            Console.WriteLine("Grade added successfully.");
        }

        public static void DisplayStudentAverages()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Average Grade: {student.GetAverageGrade()}");
            }
        }

        public static void DisplayStudentRecords()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                foreach (var grade in student.Grades)
                {
                    Console.WriteLine($"  Subject: {grade.Key}, Grade: {grade.Value}");
                }
                Console.WriteLine($"  Average: {student.GetAverageGrade()}");
            }
        }

        static List<Student> students = new List<Student>();

        public static void TurnBase()
        {
            Console.WriteLine("Welcome to Student Grade Management Systems");
            Console.WriteLine("1-Add a student.");
            Console.WriteLine("2-Add a student's grades.");
            Console.WriteLine("3-Display all student averages.");
            Console.WriteLine("4-Display student records with their grades.");
            Console.WriteLine("5-Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddGrades();
                    break;
                case "3":
                    DisplayStudentAverages();
                    break;
                case "4":
                    DisplayStudentRecords();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
            TurnBase();
        }


        static void Main(string[] args)
        {
            TurnBase();

            Console.ReadLine();
        }
    }
}
