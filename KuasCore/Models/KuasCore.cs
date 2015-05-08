using System;

namespace KuasCore.Models
{
    public class MyCore
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return "KuasCore: CourseID = " + Id + ", CourseName = " + Name + ", CourseDescription = " + Description + ".";
        }

        public int CourseDescription { get; set; }

        public string CourseName { get; set; }

        public string CourseID { get; set; }
    }
}
