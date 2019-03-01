using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    public class MailTableRepository : IMailTableRepository
    {
        private readonly dbContext _context;

        public MailTableRepository(dbContext context)
        {
            this._context = context;
        }

        public void changeMailStatus(int mail_id)
        {
            MailTable mailTable = new MailTable() { mail_ID = mail_id, mail_status = "read" };
            _context.mail_table.Attach(mailTable);
            _context.Entry(mailTable).Property(x => x.mail_status).IsModified = true;
            _context.SaveChanges();

        }

        public void createmail(MailTable mailTable)
        {
            _context.mail_table.Add(mailTable);
            _context.SaveChanges();
        }

        public void deleteReceivedMail(int mail_id)
        {
            MailTable mailTable = new MailTable() { mail_ID = mail_id, receiver_delete_status = "true" };
            _context.mail_table.Attach(mailTable);
            _context.Entry(mailTable).Property(x => x.receiver_delete_status).IsModified = true;
            _context.SaveChanges();
        }

        public void deleteSentmail(int mail_id)
        {
            MailTable mailTable = new MailTable() { mail_ID = mail_id, sender_delete_status = "true" };
            _context.mail_table.Attach(mailTable);
            _context.Entry(mailTable).Property(x => x.sender_delete_status).IsModified = true;
            _context.SaveChanges();
        }

        public void deleteTrashMail(int mail_id)
        {
            var delete_obj = _context.mail_table.SingleOrDefault(m => m.mail_ID == mail_id && (m.receiver_delete_status == "true" || m.sender_delete_status == "true"));
            _context.mail_table.Remove(delete_obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<MailTable> getAllReceivedMails(string username)
        {
            return _context.mail_table.Where(x => (x.receiver_delete_status == "false") && (x.mail_to_1 == username || x.mail_to_2 == username || x.mail_to_3 == username || x.mail_to_4 == username || x.mail_to_5 == username));
        }

        public IEnumerable<MailTable> getAllSentMails(string username)
        {
            return _context.mail_table.Where(x => (x.receiver_delete_status == "false") && (x.mail_from == username)).ToList();
        }

        public IEnumerable<MailTable> getImportantMail(string username)
        {
             return _context.mail_table.Where(x => (x.mail_to_1 == username || x.mail_to_2 == username || x.mail_to_3 == username || x.mail_to_4 == username || x.mail_to_5 == username) && x.is_important == 1);
            
        }

        public IEnumerable<MailTable> getStarredMail(string username)
        {
            return _context.mail_table.Where(x => (x.mail_to_1 == username || x.mail_to_2 == username || x.mail_to_3 == username || x.mail_to_4 == username || x.mail_to_5 == username) && x.is_starred == 1);
        }

        public IEnumerable<MailTable> getTrashMail(string username)
        {
            return _context.mail_table.Where(x => (x.receiver_delete_status == "true" || x.sender_delete_status == "true") && (x.mail_to_1 == username || x.mail_to_2 == username || x.mail_to_3 == username || x.mail_to_4 == username || x.mail_to_5 == username));
        }

        public MailTable openMailByClicking(long mail_id)
        {
            return _context.mail_table.SingleOrDefault(m => m.mail_ID == mail_id);
        }
    }
}
