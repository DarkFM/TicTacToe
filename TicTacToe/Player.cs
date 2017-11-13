using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Creates a new Player
    /// </summary>
    class Player
    {
        private int PlayerSelection;
        private string playerName;
        private char symbol;

        public Player(string Name, char symbol)
        {
            PlayerName = Name;
            this.Symbol = symbol;
        }

        public char Symbol { get => symbol; private set => symbol = value; }
        public string PlayerName { get { return playerName; } private set { playerName = value; } } // same as above with different syntax

        /// <summary>
        /// Allows player to make a play
        /// </summary>
        /// <returns>PLayer Board Selection</returns>
        public int MakePlay()
        {
            bool isvalidInput;
            do
            {
                Console.Write($"It is {PlayerName}'s turn. Your symbol is {symbol}. Make a board selection:  ");
                var userInput = Console.ReadLine();
                isvalidInput = int.TryParse(userInput, out PlayerSelection);
                if (!isvalidInput)
                {
                    Console.WriteLine("Please enter a valid number input between 1 - 9");
                }
                if(PlayerSelection > 9 || PlayerSelection < 1)
                {
                    Console.WriteLine("Please Enter a number Between 1 - 9");
                    isvalidInput = false;
                }
            } while (!isvalidInput);

            return PlayerSelection - 1;
        }
    }
}
