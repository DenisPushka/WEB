using System;

namespace Domain.Models
{
    public class Student : Entity// ,Person
    {
        public int Course { get; set; }
        public string NameUniversity { get; set; }
        public string Speciality { get; set; }
    }
}