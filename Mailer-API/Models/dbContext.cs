using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models
{
    public class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }

        public DbSet<Models.MailTable> mail_table { get; set; }
        public DbSet<Models.DraftMailTable> draft_mail_table { get; set; }
        public DbSet<Models.UserTable> user_table { get; set; }

    }
}
