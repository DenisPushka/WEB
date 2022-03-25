using System;

namespace Domain.Models
{
    public class Programmer : Entity//Person,
    {
        public int CountProject { get; set; }
        public Level Level { get; set; }
    }

    public enum Level
    {
        Junior,
        Middle,
        Senior
    }
}