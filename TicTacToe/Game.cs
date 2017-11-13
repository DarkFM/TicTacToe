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
            players = new List<Player>
            {
                player1,
                player2
            };
        }

        public void StartGame()
        {
            GameState state = GameState.WinnerNotFound;

            // initialize starting player
            StartingPlayer();
            playing = (whosTurn == WhosTurn.Player1) ? players[0] : players[1];

            // allow for players to take turns till winner/draw state is reached
            while (true)
            {
                // Render Game board
                RenderGame();

                // Player takes a turn on the board
                while (!Board.MakePlay(playing.Symbol, playing.MakePlay()));
                Console.WriteLine("*****************************\n");
                
                // get game state and break on winner/draw state
                state = Board.gamestate(playing.Symbol);
                if (state != GameState.WinnerNotFound)
                {
                    break;
                }
                else
                {
                    // Alternate Player turns
                    whosTurn = (whosTurn == WhosTurn.Player1) ? WhosTurn.Player2 : WhosTurn.Player1;
                    playing = (whosTurn == WhosTurn.Player1) ? players[0] : players[1];
                }

            }

            DrawOrWin(state);

        }

        private void StartingPlayer()
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
            Console.WriteLine($" {grid[0]} | {grid[1]} | {grid[2]}");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {grid[3]} | {grid[4]} | {grid[5]}");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {grid[6]} | {grid[7]} | {grid[8]}");
        }

        private void DrawOrWin(GameState state)
        {
            RenderGame();
            if(state == GameState.WinnerFound)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The winner of this game is {playing.PlayerName}!!! Congrats");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Ended as a Draw");
            }
        }
    }
}
