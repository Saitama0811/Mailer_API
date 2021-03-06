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
    public class SearchController : Controller
    {
        private readonly IMailTableRepository _context;

        public SearchController(IMailTableRepository context)
        {
            _context = context;
        }

        
    [HttpPost]
        public IEnumerable<MailTable> Post([FromBody]customSearchObj obj)
        {
            return _context.searchMail(obj).ToList();
            
        }

        [HttpGet("{mail_id}")]
        public MailTable GetMail([FromRoute] long mail_id)
        {
            return _context.openSearchMailByClicking(mail_id);
        }
    }

   
}
