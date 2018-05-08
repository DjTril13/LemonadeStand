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
        public double price;
        public int quantity;

        //Items(string name, double price, int quantity)
        //{
        //    this.name = name;
        //    this.price = price;
        //    this.quantity = quantity;
        //}
        //public Items lemon = new Items("Lemon", .50, 99);
        //public Items ice = new Items("Ice", 1.00, 99);
        //public Items sugar = new Items("Sugar", .50, 99);

        public void DisplayProductInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(quantity);
        }


    }
}