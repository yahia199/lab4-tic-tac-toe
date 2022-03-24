﻿

using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Toc_Toe.Classes
{
    public class Board
    {
       
        public string[,] GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

       
		public void DisplayBoard()
        {
            // Output the board to the console
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    Console.Write(GameBoard[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
