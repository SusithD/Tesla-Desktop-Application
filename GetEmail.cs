using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porches
{
    class GetEmail
    {
        static string Email;
        
        public static string email
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }
    }
}
