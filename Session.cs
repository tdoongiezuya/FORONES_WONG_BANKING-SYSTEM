using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WONG_BANKING
{
    public static class Session
    {
        public static Customer CurrentCustomer { get; set; }
        public static string UserLevel { get; set; }

        public static void clearSession()
        {
            UserLevel = "";
            CurrentCustomer = null;
        }
    }
}
