using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace DataAccess.Models
{
    public interface IPersonRepository
    {
        Task<List<Person>>  AddPerson(Person person);

        Task<List<Person>> DeletePerson(Guid id);

        Task<List<Person>> InsertPerson(Person person);
        Task<Person[]> ToArrayAsinc();
    }
}