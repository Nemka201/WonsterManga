using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;

namespace WonsterManga.ServiceDefaults.InternalServices
{
    internal interface IAuthJWT
    {
        public string BuildToken(User user);

    }
}
