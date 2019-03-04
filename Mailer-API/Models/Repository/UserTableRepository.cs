using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    public class UserTableRepository : IUserTableRepository
    {
        private dbContext _context;

        public UserTableRepository(dbContext context)
        {
            this._context = context;
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public bool doLogin(UserTable user)
        {
            var user_name = _context.user_table.SingleOrDefault(m => m.username == user.username && m.password == user.password);

            if (user_name == null)
                return false;

            return true;
        }

        public void registerUser(UserTable userTable)
        {
            var user_name = _context.user_table.SingleOrDefault(m => m.username == userTable.username || m.phone_number == userTable.phone_number);
            if (user_name == null)
            {
                _context.user_table.Add(userTable);
                _context.SaveChanges();
            }
        }

        public void UpdatePassword()
        {
            // throw new NotImplementedException();
        }
    }
}
