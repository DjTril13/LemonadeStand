using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Player
    {
        public Inventory inventory;
        private string name;
        private int budget;
        private int weeklyProfits;
        


        public Player()
        {}

       RecipeChoice()
        { }

   
        internal void CheckWallet()
        {
            if (cashOnHand <= 0)
            {
                UserInterface.ExitGameMessage();
                Environment.Exit(0);
            }
            else
            {return;}
        } 
    }
}
    