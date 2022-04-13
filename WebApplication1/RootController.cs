using System.Linq;
using DataAccess;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class RootController : Controller
    {
        [HttpGet("/")]
        public IActionResult Person()
        {
            using var db = new ApplicationContext();
            AddPerson(db);
            return View("Index");
        }

        private static void AddPerson(ApplicationContext db)
        {
            if (!db.Persons.Any() && !db.Posts.Any())
            {
                var ar = ApplicationContext.CreatedTable();
                var posts = new Post {Name = "Programmer", Salary = 10000};
                var posts1 = new Post {Name = "Student", Salary = 2700};
                ar[0].Post = posts;
                ar[1].Post = posts1;
                ar[2].Post = posts;
                db.Posts.Add(posts);
                db.Persons.AddRange(ar[0], ar[1], ar[2]);
                db.SaveChanges();
            }
        }
    }
}