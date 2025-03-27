using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    internal class Student
    {
        public string Name { get;  set; }
        public string Id { get;  set; }
        public int Age { get;  set; }
        public double Gpa { get;  set; }

        public Student(string name, string id, int age, double gpa)
        {
            Name = name;
            Id = id;
            Age = age;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"Student Info:\nName: {Name}\nAge: {Age}\nID: {Id}\nGPA: {Gpa}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student s)
                return this.Id == s.Id;
            return false;
        }
    }
}