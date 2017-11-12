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

        // get game state
        public GameState gamestate(char symbol)
        {
            if (squareGrid[0] == symbol && squareGrid[3] == symbol && squareGrid[6] == symbol ||
                 squareGrid[1] == symbol && squareGrid[4] == symbol && squareGrid[7] == symbol ||
                 squareGrid[2] == symbol && squareGrid[5] == symbol && squareGrid[8] == symbol ||
                 squareGrid[3] == symbol && squareGrid[4] == symbol && squareGrid[5] == symbol ||
                 squareGrid[0] == symbol && squareGrid[1] == symbol && squareGrid[2] == symbol ||
                 squareGrid[6] == symbol && squareGrid[7] == symbol && squareGrid[8] == symbol ||
                 squareGrid[0] == symbol && squareGrid[4] == symbol && squareGrid[8] == symbol ||
                 squareGrid[2] == symbol && squareGrid[4] == symbol && squareGrid[7] == symbol)
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

        public bool MakePlay(char square, int boardPosition)
        {
            // check if valid position to play in
            if (!Char.IsWhiteSpace(squareGrid[boardPosition]))
            {
                squareGrid[boardPosition] = square;
                return true;
            }

            return false;
        }

        public char[] GetGrid()
        {
            return squareGrid;
        }
    }
}
