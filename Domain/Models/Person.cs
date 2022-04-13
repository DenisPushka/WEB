using System;

namespace Domain.Models
{
    public class Person : Entity
    {
        // public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public bool IsWeird { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}