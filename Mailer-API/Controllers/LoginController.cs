﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mailer_API.Models;
using Mailer_API.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mailer_API.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IUserTableRepository _context;

        public LoginController(IUserTableRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public bool Get([FromBody] UserTable user)
        {
            return _context.doLogin(user);
        }
    }
}
