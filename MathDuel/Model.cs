using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel
{
    public class Model
    {
        private Random rand = new Random();
        private int score = 0;
        private int wrongAnswers =0 ;
        /*
        public int score {get;private set;}
        public int wrongAnswers {get;private set;}   
        */
        
        public Random getRandValue()=>rand;
        public int getScore()=>score;
        public int getWrongAnswers()=>wrongAnswers;
    }
}