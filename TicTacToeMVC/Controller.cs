using System.Collections.Generic;


namespace TicTacToeMVC
{
    public class Controller
    {
        private List<Player> playerList;
        private View view; 
            
        public Controller(List<Player> playerList)
        {
            this.playerList = playerList;
        }

        public void Run(View view)
        {
            int intput;

            do
            {

                input = view.MainMenu(playerOrder);

                switch (input)
                {
                    case 0:
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while(intput != 0);
        }


    }
}
