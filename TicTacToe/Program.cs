using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var Game1 = new Game(new Player("Clinton", 'X'), new Player("Jessy", 'O'));

            Game1.StartGame();

            Console.ReadLine();
        }
    }
}
