/// <summary>
/// Project Name: TetrisGUI
/// File Name: SaveGame.cs
/// Written by: Charley Bein and Ben Tipton
/// Date: 2019-03-19
/// Description: Object to be saved to save files
/// </summary>
using System;

namespace TetrisGUI
{
    [Serializable]
    public class SaveGame
    {
        public bool playerOne;
        public int[,] gameBoard = new int[GameManager.height + 2, GameManager.width + 2];
        public int numRows;
        public int numCols;
    }
}
