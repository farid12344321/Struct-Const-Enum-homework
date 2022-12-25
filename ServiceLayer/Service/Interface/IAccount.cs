using ServiceLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interface
{
    internal interface IAccount
    {
        Roles AccountService(int rollİd);
        bool Login(string email, string password);

    }
}
