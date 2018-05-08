using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Customer
    {
        int hasAnOpinionOnWether;   // inc. odds of making a purchase w/ inc. weather
        int hasAnOpinionOnPrice;    // inc. odds of making a purchase w/ dec. price
        int demand;                    //hasAnOpinionOnPrice + hasAnOpinionOnWether  
        int amountPurchased;
    }
}
