using System.Collections.Generic;

namespace Domain.Models
{
    public class Post : Entity
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<Person> Persons { get; set; }
    }
}