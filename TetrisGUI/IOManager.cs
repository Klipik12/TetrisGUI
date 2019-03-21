///<summary>
/// Written by: Charley Bein, Ben Tipton
/// File Summary: Class of static methods to take input and display output
/// </summary>
using System;

namespace TetrisGUI
{
    class IOManager
    {
        /// <summary>
        /// Pass the selected column number from the GUI to the game manager
        /// </summary>
        /// <param name="col">Selected column number</param>
        /// <param name="game">The game manager in use</param>
        /// <param name="playerOne">The currently active player (true = player 1, false = player 2)</param>
        /// <returns>Game State (-1 = full row, 0 = neutral, 1 = player 1 wins, 2 = player 2 wins)</returns>
        public static int NewMove(int col, GameManager game, bool playerOne)
        {
            if (playerOne)
            {
                return game.AddToken(col, 1);
            } else
            {
                return game.AddToken(col, 2);
            }
        }
    }
}
