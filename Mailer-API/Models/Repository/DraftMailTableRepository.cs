using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    public class DraftMailTableRepository : IDraftMailTableRepository
    {
        private dbContext _context;

        public DraftMailTableRepository(dbContext context)
        {
            this._context = context;
        }

        public void deletedraftmail(int draft_mail_id)
        {
            var delete_obj = _context.draft_mail_table.SingleOrDefault(m => m.draft_mail_ID == draft_mail_id);
            _context.draft_mail_table.Remove(delete_obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            
        }

        public DraftMailTable editDraftMail(int draft_mail_id)
        {
            return _context.draft_mail_table.SingleOrDefault(x => x.draft_mail_ID == draft_mail_id);
        }

        public IEnumerable<DraftMailTable> getAllDraftMails(string username)
        {
            return _context.draft_mail_table.Where(x => x.mail_from == username);
        }

        public void savedraftmail(DraftMailTable draftMailTable)
        {
            _context.draft_mail_table.Add(draftMailTable);
            _context.SaveChanges();
        }
    }
}
