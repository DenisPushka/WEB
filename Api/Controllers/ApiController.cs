using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController, Route("api/v1/auth")]
    public class ApiController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public ApiController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // [HttpGet]
        // public async Task<Person[]> Get() =>
        //    Task.FromResult<IActionResult>(Ok(await _personRepository.ToArrayAsinc()));

        // [HttpGet("SortForNameDenis")]
        // public async Task<IActionResult> SortForNameDenis() => Ok(SortName());

        [HttpPost("addPerson")]
        public async Task<List<Person>> AddPerson([FromBody] Person person)
        {
            // автомапер
            // var p = new Person
            // {
            //     Id = person.Id,
            // };

            return await _personRepository.AddPerson(person);
        }

        [HttpPost("insertPerson")]
        public async Task<List<Person>> InsertPerson([FromBody]Person person)
        {
            return await _personRepository.InsertPerson(person);
        }

        [HttpPost("deletePerson")]
        public async Task<List<Person>> DeletePerson([FromBody] Guid id)
        {
            return await _personRepository.DeletePerson(id);
        }

        // public List<Person> SortName()
        // {
        //     return _applicationContext.Persons.Where(person => person.Name == "Denis").ToList();
        // }

        [HttpGet("signup")]
        public async Task<IActionResult> SignupAndLogin() => Ok();
    }
}