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
        private Player playing;


        public Game(Player player1, Player player2)
        {
            Board = new GameBoard();
            players.Add(player1);
            players.Add(player2);
        }

        public void StartGame()
        {
            GameState state = GameState.WinnerNotFound;

            // initialize starting player
            startingPlayer();
            playing = (whosTurn == WhosTurn.Player1) ? players[0] : players[1];

            // allow for players to take turns till winner/draw state is reached
            while (state == GameState.WinnerNotFound)
            {
                // get game state
                state = Board.gamestate(playing.Symbol);
                
                // Render Game board
                RenderGame();

                // Alternate Player turns
                whosTurn = (whosTurn == WhosTurn.Player1) ? WhosTurn.Player2 : WhosTurn.Player1;
                playing = (whosTurn == WhosTurn.Player1) ? players[0] : players[1];

            }

            DrawOrWin(state);

        }

        private void startingPlayer()
        {
            var random = new Random();
            if (random.Next(2) + 1 > 1)
                whosTurn = WhosTurn.Player1;
            else
                whosTurn = WhosTurn.Player2;
        }

        private void RenderGame()
        {
            var grid = Board.GetGrid();
            Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
            Console.WriteLine($"---+----+----");
            Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
            Console.WriteLine($"---+----+----");
            Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
        }

        private void DrawOrWin(GameState state)
        {
            if(state == GameState.WinnerFound)
            {
                Console.WriteLine($"The winner of this game is {playing.PlayerName}");
            }
            else
            {
                Console.WriteLine("Game Ended as a Draw");
            }
        }
    }
}
