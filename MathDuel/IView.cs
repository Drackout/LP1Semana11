using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel
{
    public interface IView
    {
        public void ShowMainMenu(){}
        public void ShowCorrectAnswer(){}
        public void ShowWrongAnswer(int corrAns){}
        public void ShowGameOver(int score){}

        public abstract string AskQuestionInput(string question);
        
    }
}