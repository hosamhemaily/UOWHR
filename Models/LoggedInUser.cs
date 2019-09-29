using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static class LoggedInUser
    {
        public static Guid Id { get; set; }
        public static string Token { get; set; }
        public static string FullName { get; set; }
        public static DateTime Expiry { get; set; }
        public static string Avatar { get; set; }

        

    }
}
