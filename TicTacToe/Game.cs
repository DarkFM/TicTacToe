using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private List<Player> players;
        private WhosTurn whosTurn;
        private GameBoard Board;

        public Game(Player player1, Player player2)
        {
            Board = new GameBoard();
            players.Add(player1);
            players.Add(player2);
        }

        public void StartGame()
        {
            while (Board.gamestate == GameState.WinnerNotFound)
            {

            }
        }
    }
}
