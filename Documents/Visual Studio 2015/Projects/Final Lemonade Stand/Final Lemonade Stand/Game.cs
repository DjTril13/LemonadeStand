using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lemonade_Stand
{
    class Game
    {
       public static void RunGame()
        {
            Console.WriteLine("Would you like to play my Lemonade Stand? Press ENTER to play.");
            Console.ReadLine();
            Forcast CityForcast = new Forcast("Milwaukee");
            CityForcast.CheckWeather();
            Console.WriteLine(CityForcast.Temp);
            Console.ReadLine();
        }
    }
}