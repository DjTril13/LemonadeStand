using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Items
    {
        public string name;
        protected double price;
        public int quantity;

        public Items()
        {
            quantity = Quantity;
        }

        //public string Name
        //{ get { return name; } }

        //public double Price
        //{ get { return price; } }

        public int Quantity
        { get { return quantity; } set { price = value; } }


    }
}