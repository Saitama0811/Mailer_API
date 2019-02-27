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
    public class StarredMailController : Controller
    {
        private readonly IMailTableRepository _context;

        public StarredMailController(IMailTableRepository context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<MailTable> Get([FromBody]UserTable user)
        {
            return _context.getStarredMail(user.username).ToList();

        }

        [HttpGet("{mail_id}")]
        public MailTable GetMail([FromRoute] long mail_id)
        {
            return _context.openMailByClicking(mail_id);
        }
        
    }
}
