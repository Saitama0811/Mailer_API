using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    public interface IDraftMailTableRepository : IDisposable
    {
        IEnumerable<DraftMailTable> getAllDraftMails(string username);
        DraftMailTable editDraftMail(int draft_mail_id);
        void savedraftmail(DraftMailTable draftMailTable);
        void deletedraftmail(int draft_mail_id);
    }
}
