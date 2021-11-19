using System;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Persons.Commands.CreatePerson;
using CleanArchitecture.Application.Persons.Queries;
using CleanArchitecture.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class PersonsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<PaginatedList<PersonDto>>> Get([FromQuery] GetPersonsWithPaginationQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreatePersonCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}