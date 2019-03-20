///<summary>
/// Written by: Charley Bein, Ben Tipton
/// File Summary: Manager for all primary game logic
/// (General info in Program.cs)
/// </summary>

using System;
using System.Collections.Generic;

namespace TetrisGUI
{
    class GameManager
    {
        //public static int height = 6;
        //public static int width = 7;
        public static int height;
        public static int width;
        public int winstate = 0;
        public LinkedList<Token[]> rowlist = new LinkedList<Token[]>();

        // When manager is initialized, create an empty game board with edges of color -1
        //public GameManager()
        //{
        //    int i = 0;
            
        //    Token[] edgeArr = { new Token(-1), new Token(-1), new Token(-1), new Token(-1), new Token(-1), new Token(-1), new Token(-1), new Token(-1), new Token(-1) };
        //    do
        //    {
        //        Token[] inArr = { new Token(-1), new Token(), new Token(), new Token(), new Token(), new Token(), new Token(), new Token(), new Token(-1) };
        //        rowlist.AddLast(inArr);
        //        i++;
        //    } while (i < height);
        //    rowlist.AddFirst(edgeArr);
        //    rowlist.AddLast(edgeArr);
        //}
        public GameManager(int h, int w)
        {
            height = h;
            width = w;

            for (int i = 0; i < height + 2; i++)
            {
                Token[] tokens = new Token[width + 2];
                if (i == 0 || i == height + 1)
                {
                    for (int j = 0; j < width + 2; j++)
                    {
                        tokens[j] = new Token(-1);
                    }
                }
                else
                {
                    for (int j = 0; j < width + 2; j++)
                    {
                        if (j == 0 || j == width + 1)
                        {
                            tokens[j] = new Token(-1);
                        }
                        else
                        {
                            tokens[j] = new Token();
                        }
                    }
                }
                rowlist.AddLast(tokens);
            }
        }
        
        // When called, add a token of the appropriate color at the first available spot in the given position, and carry out logic
        public int AddToken(int position, int color)
        {
            LinkedListNode<Token[]> firstRow = rowlist.First;
            LinkedListNode<Token[]> rowNode;
            do
            {
                // Call the recursive function to find the available row
                rowNode = AddWrapper(position, ref firstRow, color);
                
                if (rowNode == null)
                {
                    // If the row is full, prompt the user to select another
                    return -1;
                }
            } while (rowNode == null);
            // Set the position of the token, and its color
            Token[] row = rowNode.Value;
            Token token = row[position];
            token.SetPos(rowNode, position);
            token.SetColor(color);
            // Check the colors of the tokens in each direction, to see if there are enough to win
            token.CheckNeighbors();

            // If there is enough of the same color in any of the straight lines accross the token, return the color as the winner
            if (token.CheckTot())
            {
                return color;
            }

            // If there is no winner, check if the bottom row is filled, and if so, delete it
            if (CheckFilled())
            {
                DeleteRow();
            }

            // Return a neutral game state
            return 0;


        }

        // Recursively check each row in the position from the bottom up until an available one is found, and return that
        private LinkedListNode<Token[]> AddWrapper(int position, ref LinkedListNode<Token[]> row, int pColor)
        {
            LinkedListNode<Token[]> next = row.Next;
            if(row.Equals(row.List.First)) { return AddWrapper(position, ref next, pColor); }
            else if(row.Equals(row.List.Last)) { return null; }
            else if(row.Value[position].GetColor() != 0)
            {
                return AddWrapper(position, ref next, pColor);
            }
            else
            { 
                return row;
            }
        }

        // Pass an array of the game board to the IO manager to be drawn
        public int[,] ToDraw()
        {
            int[,] colorArray = new int[height + 2,width + 2];
            int i = 0;
            foreach(Token[] t in rowlist)
            {
                for(int j = 0; j < width; j++)
                {
                    colorArray[i, j] = t[j].GetColor();
                }
                i++;
            }
            return colorArray;
            //IOManager.Draw(colorArray);

        }


        // Check each token in the first row to see if it is filled, and return that answer
        private bool CheckFilled()
        {
            bool filled = true;
            foreach(Token token in rowlist.First.Next.Value)
            {
                if(token.GetColor() == 0) { filled = false; }
            }
            return filled;
        }

        // Delete the bottom game row, and add a new one to the top to keep the size consistent
        private void DeleteRow()
        {
            LinkedListNode<Token[]> firstRow = rowlist.First.Next;
            Token[] inArr = { new Token(-1), new Token(), new Token(), new Token(), new Token(), new Token(), new Token(), new Token(), new Token(-1) };
            rowlist.Remove(firstRow);
            rowlist.AddBefore(rowlist.Last, inArr);
        }
    }
}
