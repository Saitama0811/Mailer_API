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
    public class DraftMailController : Controller
    {
        private readonly IDraftMailTableRepository _context;

        public DraftMailController(IDraftMailTableRepository context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpPost]
        public IEnumerable<DraftMailTable> Get([FromBody]UserTable user)
        {
            return _context.getAllDraftMails(user.username).ToList();

        }

        [HttpGet("{mail_id}")]
        public DraftMailTable GetMail([FromRoute] int mail_id)
        {
            return _context.editDraftMail(mail_id);
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            _context.deletedraftmail(id);
            return Ok("deleted");
        }

        
    }
}
