using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Post> Posts { get; set; }
        

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        
        public List<Person> CreatedTable() =>
            new()
            {
                new Person {Age = 19,Name = "Denis"},
                // new Person(2,"Alex",21,true,true),
                // new Person(3,"Grisha", 19)
            };

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Testing;Username=postgres;Password=ogr84Bqk3");
        }
    }
}