using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mailer_API.Models.Repository
{
    public interface IUserTableRepository : IDisposable
    {
        void UpdatePassword();
        bool doLogin(UserTable user);
        void registerUser(UserTable userTable);
    }
}
