namespace Domain.Models
{
    public interface IHuman
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public bool IsWeird { get; set; }
    }
}