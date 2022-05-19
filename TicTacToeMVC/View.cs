using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    class View
    {
        private Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
        }
            
        //Draw board

        //Show unavailable options

        //Menu
        public int MainMenu()
        {
            Console.WriteLine("- - Options - -");
            Console.WriteLine("1 - op1");
            Console.WriteLine("2 - op2");
            Console.WriteLine("3 - op3");
            Console.WriteLine("0 - Exit Game");

            return 0;
        }

        public void InvalidOption()
        {
            Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

    }
}
