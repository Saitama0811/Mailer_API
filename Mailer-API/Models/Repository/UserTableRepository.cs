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
            throw new NotImplementedException();
        }

        public bool doLogin(string username, string password)
        {
            var user_name = _context.user_table.SingleOrDefault(m => m.username == username && m.password == password);

            if (user_name == null)
                return false;

            return true;
        }

        public void doLogOut()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTable> getAllUsers()
        {
            return _context.user_table.ToList();
        }

        public void registerUser(UserTable userTable)
        {
            
        }

        public void UpdatePassword()
        {
            throw new NotImplementedException();
        }
    }
}
