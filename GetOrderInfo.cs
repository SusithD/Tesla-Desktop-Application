using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porches
{
    class GetOrderInfo
    {
        static string Model;

        public static string model
        {
            get
            {
                return Model;
            }

            set
            {
                Model = value;
            }
        }
    }
}
