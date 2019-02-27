using System;
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
    public class CreateMailController : Controller
    {

        private readonly IMailTableRepository _context;

        public CreateMailController(IMailTableRepository context)
        {
            _context = context;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]MailTable mailTable)
        {
            _context.createmail(mailTable);
        }
    }
}

