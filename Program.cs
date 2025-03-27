namespace Student_Registration_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrationSystem system = new RegistrationSystem();

            Student student1 = new Student("kareem badr", "b001", 20, 3.5);
            Student student2 = new Student("reema mazen", "r002", 21, 3.2);
            Student student3 = new Student("Omar", "o003", 19, 2.8);

            Course course1 = new Course("Math", 3);
            Course course2 = new Course("Physics", 4);
            Course course3 = new Course("Programming", 5);

            system.AddStudentCourse(student1, course1);
            system.AddStudentCourse(student1, course2);
            system.AddStudentCourse(student2, course1);
            system.AddStudentCourse(student3, course3);

            system.AddStudentCourse(student1, course1);

            Console.WriteLine("\n--- Student Courses ---");
            system.PrintStudentCourses("b001"); 
            system.PrintStudentCourses("r002"); 
            system.PrintStudentCourses("o003"); 
            system.PrintStudentCourses("S999"); 

            Console.WriteLine("\n--- Course Students ---");
            system.PrintCourseStudents("Math");
            system.PrintCourseStudents("Physics");
            system.PrintCourseStudents("Programming");

            Console.WriteLine("\n--- Removing Student from Course ---");
            system.RemoveStudentFromCourse("b001", "Math"); 
            system.PrintStudentCourses("b001"); 

            system.RemoveStudentFromCourse("b001", "History");

            Console.WriteLine("\n--- Final Course Lists ---");
            system.PrintCourseStudents("Math");
            system.PrintCourseStudents("Physics");
            system.PrintCourseStudents("Programming");


        }
    }
}
