using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GameBoard
{
    class Board
    {
        private Button[,] gameBoard = new Button[8, 8];
        public Board()
        {
            InitBoard(gameBoard);
        }

        public Button[,] GameBoard { get => gameBoard; set => gameBoard = value; }

        public void InitBoard(Button[,] board)
        {
            bool isBlack = false;
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    Button btn = new Button();
                    btn.Height = 50;
                    btn.Width = 50;
                    btn.Padding = new Thickness(0);
                    // The width and height of the placement 
                    btn.Margin = new Thickness(btn.Width * (x * 2 - (board.GetLength(0) - 1)), btn.Height * (y - board.GetLength(1) / 2) * 2, 0, 0);
                    btn.Background = (isBlack ? Brushes.Black : Brushes.White);
                    isBlack = !isBlack;

                    board[x, y] = btn;
                }
                isBlack = !isBlack;
            }
        }
    }
}
