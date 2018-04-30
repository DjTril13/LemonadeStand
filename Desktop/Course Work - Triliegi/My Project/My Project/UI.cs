using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project
{
    class UI
    {
        List<string> promptList;
        public int promptNumber;
        public int userResponse;
        
         
    public UI(promptNumber)   // constructor
        {
            promptList = new List<string>();
            promptList.Add("Welcome to RPSLS! How many players do you have. Type '1' or '2'.");
            promptList.Add("It's ***** turn. Please enter the number corresponding to your choice : 0. 'Rock', 1. 'Paper', 2. 'Siccors', 3. 'Lizzard', 4. 'Spock");
            promptList.Add("Player *** has won this round");
            promptList.Add("Congradulations Player *** has won the game! Do you want to play again?");            
            userResponse = Convert.ToInt32(Console.ReadLine());
            return userResponse;
        }


        // Create list of prompts in array, and call them thru the game with one function. Make sure to include a way to plug in the NAME OF PLAYER into the planner prmpts
        
        //Methods    }
}
