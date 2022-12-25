using ServiceLayer.Constants;
using ServiceLayer.Enums;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceLayer.Service
{
    internal class Account : IAccount
    {
        public Roles AccountService(int rollİd)
        {
            rollİd = 1;
            return (Roles)rollİd;
        }

        public bool Login(string email, string password)
        {
            if (email == " test@code.edu.az " && password == " test12345") 
            {
                return true;
            }
            return false;
        }
    }
}
