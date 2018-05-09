using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Sugar : Items
    {
        public Sugar()
        {
            name = "Sugar";
            price = 1.00;
            quantity = Quantity; // set the uppercase
        }
    }
}
