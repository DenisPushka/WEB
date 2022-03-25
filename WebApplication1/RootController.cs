using System.Linq;
using DataAccess;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class RootController : Controller
    {
        public IActionResult Person()
        {
            using var db = new ApplicationContext();
            var posts = new Post {Name = "Student",Salary = 2700};
            var person = new Person
            {
                Age = 19,
                Name = "Denis",
                Post = posts
            };
            db.Posts.Add(posts);
            db.Persons.Add(person);
            db.SaveChanges();
            // if (!persons.Any())
            // {
            //     persons = db.CreatedTable();
            //     foreach (var human in persons)
            //         db.Persons.Add(human);
            //     db.SaveChanges();
            // }

            return View("Person");
        }
    }
}