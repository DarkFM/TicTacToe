﻿using System;
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
            playerName = Name;
            this.symbol = symbol;
        }

        /// <summary>
        /// Allows player to make a play
        /// </summary>
        /// <returns>PLayer Board Selection</returns>
        public int MakePlay()
        {
            bool isvalidInput = false;
            do
            {
                Console.Write($"It is {playerName}'s turn. Make a board selection:  ");
                isvalidInput = int.TryParse(Console.ReadLine(), out PlayerSelection);
                if (!isvalidInput)
                {
                    Console.WriteLine("Please enter a valid number input between 1 - 9");
                }
            } while (!isvalidInput);

            return PlayerSelection;
        }
    }
}