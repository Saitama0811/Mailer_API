using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    public interface IMailTableRepository : IDisposable
    {
        IEnumerable<MailTable> getAllReceivedMails(string username);
        IEnumerable<MailTable> getAllSentMails(string username);
        IEnumerable<MailTable> getStarredMail(string username);
        IEnumerable<MailTable> getImportantMail(string username);
        void deleteSentmail(int mail_id);
        void deleteReceivedMail(int mail_id);
        IEnumerable<MailTable> getTrashMail(string username);
        void createmail(MailTable mailTable);
        void changeMailStatus(int mail_id);
        MailTable openMailByClicking(long mail_id);
        void deleteTrashMail(int mail_id);
        IEnumerable<MailTable> searchMail(MailTable mailTable);
    }
}
