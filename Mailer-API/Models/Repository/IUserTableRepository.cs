using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    interface IUserTableRepository : IDisposable
    {
        IEnumerable<UserTable> getAllUsers();
        void UpdatePassword();
        bool doLogin(string username, string password);
        void registerUser(UserTable userTable);
        void doLogOut();
    }
}
