using System;
using MathDuel;

class Program
{
    static void Main()
    {
        Model modelo = new Model();
        Controller contr = new Controller(modelo);
        IView view = new ConsoleView();

        view.ShowMainMenu();  
        contr.Run();      

    }
}
