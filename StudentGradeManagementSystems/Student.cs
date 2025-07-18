using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagementSystems
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Grades = new Dictionary<string, int>();
        }

        public void AddGrade(string subject, int grade)
        {
            Grades[subject] = grade; // Ders notu ekle veya güncelle
        }

        public double GetAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;
            return Grades.Values.Average();
        }
    }
}
