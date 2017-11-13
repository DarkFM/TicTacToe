using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameBoard
    {
        //private GameState gamestate;
        private char[] squareGrid;

        // constructor
        public GameBoard()
        {
            squareGrid = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        }

        /// <summary>
        /// Gets thr current game state
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns>An enumerable indicating the current state of the game</returns>
        public GameState gamestate(char symbol)
        {
            if (squareGrid[0] == symbol && squareGrid[3] == symbol && squareGrid[6] == symbol ||
                 squareGrid[1] == symbol && squareGrid[4] == symbol && squareGrid[7] == symbol ||
                 squareGrid[2] == symbol && squareGrid[5] == symbol && squareGrid[8] == symbol ||
                 squareGrid[3] == symbol && squareGrid[4] == symbol && squareGrid[5] == symbol ||
                 squareGrid[0] == symbol && squareGrid[1] == symbol && squareGrid[2] == symbol ||
                 squareGrid[6] == symbol && squareGrid[7] == symbol && squareGrid[8] == symbol ||
                 squareGrid[0] == symbol && squareGrid[4] == symbol && squareGrid[8] == symbol ||
                 squareGrid[2] == symbol && squareGrid[4] == symbol && squareGrid[6] == symbol)
            {
                return GameState.WinnerFound;
            }
            else
            {
                // Check if Board is Not Full
                for (int i = 0; i < squareGrid.Length; i++)
                {
                    if (Char.IsWhiteSpace(squareGrid[i]))
                    {
                        return GameState.WinnerNotFound;
                    }
                }

                return GameState.BoardFull;
            }

        }

        /// <summary>
        /// Allows player to make a play on the board
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="boardPosition"></param>
        /// <returns>Returns whether the play was valid or not</returns>
        public bool MakePlay(char symbol, int boardPosition)
        {
            // comupute only if valid play
            if (Char.IsWhiteSpace(squareGrid[boardPosition]))
            {
                squareGrid[boardPosition] = symbol;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns the current grid to the caller
        /// </summary>
        /// <returns></returns>
        public char[] GetGrid()
        {
            return squareGrid;
        }
    }
}
