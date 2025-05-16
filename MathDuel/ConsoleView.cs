using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel
{
    public class ConsoleView: IView
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("=== Math Duel ===");
            Console.WriteLine("Answer the math problems correctly!");
            Console.WriteLine("You can make up to 3 mistakes.");
            Console.WriteLine();
        }

        public void ShowCorrectAnswer() =>
            Console.WriteLine("Correct!\n");

        public void ShowWrongAnswer(int corrAns) =>
            Console.WriteLine($"Wrong! The correct answer was {corrAns}.\n");
        
        public void ShowGameOver(int score) =>
            Console.WriteLine($"Game over! Your final score is: {score}");

        public string AskQuestionInput(string question)
        {
            Console.Write("Question: " + question + " ");
            return Console.ReadLine();
        }
    }
}