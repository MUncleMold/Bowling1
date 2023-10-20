using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.addThrow(5);
            game.addThrow(4);
            Console.WriteLine(game.score());
        }


    }
}
