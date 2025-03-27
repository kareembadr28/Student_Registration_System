using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    internal class RegistrationSystem
    {
        private static Dictionary<string, HashSet<Course>> studentCourses = new Dictionary<string, HashSet<Course>>();
        private static Dictionary<string, HashSet<Student>> courseStudents = new Dictionary<string, HashSet<Student>>();

        public void AddStudentCourse(Student s, Course c)
        {
            if (!studentCourses.ContainsKey(s.Id))
                studentCourses[s.Id] = new HashSet<Course>();

            if (!studentCourses[s.Id].Add(c))
                Console.WriteLine("You have registered this course before!!!!");

            if (!courseStudents.ContainsKey(c.Name))
                courseStudents[c.Name] = new HashSet<Student>();

            if (!courseStudents[c.Name].Add(s))
                Console.WriteLine("This student registered in this course before!");
        }

        public void PrintStudentCourses(string studentId)
        {
            if (studentCourses.ContainsKey(studentId))
            {
                Console.WriteLine($"courses for student with id {studentId}:");
                foreach (var course in studentCourses[studentId])
                    Console.WriteLine(course);
            }
            else
            {
                Console.WriteLine("student was not found!!!");
            }
        }

        public void RemoveStudentFromCourse(string studentId, string courseName)
        {
            if (studentCourses.ContainsKey(studentId) && studentCourses[studentId].Any(c => c.Name == courseName))
            {
                Course courseToRemove = studentCourses[studentId].First(c => c.Name == courseName);
                studentCourses[studentId].Remove(courseToRemove);
                courseStudents[courseName].Remove(courseStudents[courseName].First(s => s.Id == studentId));
                Console.WriteLine($"student {studentId} has been removed from course {courseName}");
            }
            else
            {
                Console.WriteLine("Student is not registered in this course");
            }
        }

        public void PrintCourseStudents(string courseName)
        {
            if (courseStudents.ContainsKey(courseName))
            {
                Console.WriteLine($"students in {courseName} is :");
                foreach (var student in courseStudents[courseName])
                    Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("there is no student in this course");
            }
        }
    }

}
