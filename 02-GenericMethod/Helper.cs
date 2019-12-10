using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericMethod
{
    enum SystemMembers
    {
        Admin,
        Developer,
        Customer
    }
    class Helper
    {
        public static bool SendMail<T>(SystemMembers member, T data)
        {
            bool result = false;
            switch (member)
            {
                case SystemMembers.Admin:
                    result = new Mail<string>() { From = "ozamandans@bilgeadam.com", To = "furkantas@mail.com", Data = "string data" }.Send();
                    break;
                case SystemMembers.Developer:
                    result = new Mail<Exception>() { From = "ozamandans@bilgeadam.com", To = "furkantas@mail.com", Data = new Exception("IsNullOrEmpty") }.Send();
                    break;
                case SystemMembers.Customer:
                    result = new Mail<Invoice>() { From = "ozamandans@bilgeadam.com", To = "furkantas@mail.com", Data = new Invoice()}.Send();
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    class Invoice
    {

    }
}
