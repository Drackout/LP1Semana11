using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            //player list
            List<Player> playerList = new List<Player>() {"P1", "P2"};


            //controller
            Controller controller = new Controller(playerList);

            View newView = new View(controller);




        }
    }
}
