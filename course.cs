using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    internal class Course
    {
        public string Name { get; set; }
        public int Hour { get; set; }

        public Course(string name, int hour)
        {
            Name = name;
            Hour = hour;
        }

        public override string ToString()
        {
            return $"Course: {Name}, Hours: {Hour}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Course c)
                return this.Name == c.Name && this.Hour == c.Hour;
            return false;
        }


    }

}
