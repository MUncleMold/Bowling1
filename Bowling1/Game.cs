using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Bowling1
{
    public class Game
    {
        public Frame[] game = new Frame[12] { new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame(), new Frame() };
        //public Game() { game[9] = new LastFrame(); }
        int num = 0;
        
        public int score()
        {
            int score = 0;
            for (int i = 0; i <= num; i++)
            {
                if (game[i].rolls[0].isStrike)
                {
                    if (game[i + 1].rolls[0].isStrike) { score += game[i].score + game[i + 1].score + game[i + 2].rolls[0].pins1; }

                    else
                    {
                        score += (game[i].score + game[i + 1].score);
                    }
                }
                else if (game[i].isSpare) { score += (game[i].score + game[i + 1].rolls[0].pins1); }
                else { score += (game[i].score); }
            }
            return score;
        }

        public void addThrow(int pins)
        {
            if (num < 11)
            {
                if (game[num].isClosed)
                {
                    
                    num++;
                }
                
                game[num].addThrow(pins);
            
            }
        }



    }
}
