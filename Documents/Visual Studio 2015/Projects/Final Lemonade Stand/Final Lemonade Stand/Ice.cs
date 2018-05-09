using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Ice : Items
    {
        public Ice()
        {
            name = "Ice";
            price = .25;
            quantity = Quantity; // set the uppercase
        }
    }
}
