using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchitecture.WebUI.Controllers;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UsersController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            var user = new User
            {
                UserId = Guid.NewGuid()
            };
            return new [] { user };
        }
    }
}