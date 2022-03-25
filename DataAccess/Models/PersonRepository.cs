using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationContext _db;

        public PersonRepository(ApplicationContext applicationContext)
        {
            _db = applicationContext;
        }
        
        public async Task<List<Person>> AddPerson(Person person)
        {
            _db.Persons.Add(person);
            await _db.SaveChangesAsync();
           return await _db.Persons.ToListAsync();
        }

        public async Task<List<Person>> DeletePerson(Guid id)
        {
            foreach (var person in _db.Persons)
            {
                if (person.Id == id)
                {
                    _db.Persons.Remove(person);
                    await _db.SaveChangesAsync();
                    break;
                } // + создавать новый тип массив и их коливечество
            }
            
            return await _db.Persons.ToListAsync();
        }

        public async Task<List<Person>> InsertPerson(Person person)
        {
            foreach (var p in _db.Persons)
            {
                if (p.Id == person.Id)
                {
                    p.Age = person.Age;
                    p.Name = person.Name;
                    p.IsMale = person.IsMale;
                    p.IsWeird = person.IsWeird;
                    await _db.SaveChangesAsync();
                    break;
                }
            }

            return await _db.Persons.ToListAsync();
        }
    }
}