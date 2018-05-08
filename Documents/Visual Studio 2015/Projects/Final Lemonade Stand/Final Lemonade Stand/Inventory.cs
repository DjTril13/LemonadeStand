using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Inventory
    {
        public  Items lemon;
        public  Items ice;
        public  Items sugar; 


        public Inventory()
        {
        }



        void NextDayInventory()
        { }
        //    lemonsInventroy.quantity - // lemons in recipe 
        //    iceInventory.quantity - // ice used in recipe       // even if we dont use all the lemons used in that days recipe we still consider them 'waste' and cannon use the next day
        //    sugarInventory.quantity - // sugar used in recipe 
        //} // after one day, this inventory is our new start inventory
    }
}
