using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel
{
    public class Controller
    {
        Random rand;
        int score;
        int wrongAnswers;

        IView view = new ConsoleView();

        public Controller(Model modelo)
        {
            rand = modelo.getRandValue();
            score = modelo.getScore();
            wrongAnswers = modelo.getWrongAnswers();
        }

        public void Run()
        {
            while (wrongAnswers < 3)
            {
                int a = rand.Next(1, 11);     // 1 to 10
                int b = rand.Next(1, 11);
                int operation = rand.Next(3); // 0: +, 1: -, 2: *

                int correctAnswer;
                string question;

                if (operation == 0)
                {
                    correctAnswer = a + b;
                    question = $"{a} + {b} = ?";
                }
                else if (operation == 1)
                {
                    correctAnswer = a - b;
                    question = $"{a} - {b} = ?";
                }
                else
                {
                    correctAnswer = a * b;
                    question = $"{a} * {b} = ?";
                }

                
                string input = view.AskQuestionInput(question);

                int playerAnswer = int.Parse(input);

                if (playerAnswer == correctAnswer)
                {
                    view.ShowCorrectAnswer();
                    score++;
                }
                else
                {
                    view.ShowWrongAnswer(correctAnswer);
                    wrongAnswers++;
                }
            }
            view.ShowGameOver(score);
        }
    }
}


