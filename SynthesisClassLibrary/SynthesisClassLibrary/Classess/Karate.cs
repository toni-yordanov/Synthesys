using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisClassLibrary.Classess
{
	public class Karate : Sport
	{

        public override string ToString()
        {
            return "Karate";
        }

        public override int GetWiner(int score1, int score2)
        {
            if(score1 > 9 && score2 > 9)
            {
                if(score1 > score2)
                {
                    return 1;
                }
                return 2;
            }
            if(score1 > score2)
            {
                return 1;
            }
            return 2;
        }
    }
}
