using System;
using System.Collections.Generic;

namespace Chess
{
    /// <summary>
    /// Class for analyzing relative position for 2 pieces
    /// </summary>
    class PositionAnalyzer
    {
        List<ChessPiece> Pieces { get; } = new List<ChessPiece>();
        List<string> Colors { get; } = new List<string>();
        bool isOnHorizontal;
        bool isOnVertical;
        bool isOnDiagonal;
        /// <summary>
        /// This constructor takes 2 ChessPiece objects as parameters
        /// </summary>
        /// <param name="first">First Piece</param>
        /// <param name="second">Second Piece</param>
        public PositionAnalyzer(ChessPiece first, ChessPiece second)
        {
            Pieces.Add(first);
            Pieces.Add(second);
        }
        /// <summary>
        /// This method calls GetColor(), SetRelativePosition() and Summarize();
        /// </summary>
        public void Analyze()
        {
            if (Pieces.Count == 2)
            {
                foreach(ChessPiece piece in Pieces)
                {
                    Colors.Add(GetColor(piece));
                }
                SetRelativePositionData();
                Summarize();
            }
        }
        /// <summary>
        /// This method works with Pieces List (2 elements) to get info about relative position
        /// </summary>
        private void SetRelativePositionData()
        {
            isOnHorizontal = Pieces[0].HorizontalCoordinate == Pieces[1].HorizontalCoordinate;
            isOnVertical = Pieces[0].VerticalCoordinate == Pieces[1].VerticalCoordinate;
            isOnDiagonal = Math.Abs(Pieces[1].HorizontalCoordinate - Pieces[0].HorizontalCoordinate) ==
                Math.Abs(Pieces[1].VerticalCoordinate - Pieces[0].VerticalCoordinate);
        }
        /// <summary>
        /// Takes piece and returns it's cell color
        /// </summary>
        /// <param name="piece">ChessPiece parameter to process</param>
        /// <returns>Black or White cell</returns>
        public string GetColor(ChessPiece piece)
        {
            return piece.HorizontalCoordinate % 2 == piece.VerticalCoordinate % 2 ? "Black" : "white";
        }
        /// <summary>
        /// Writes to console all the info about pieces and their relative position.
        /// Im using for loop because method uses indices for both Piece and Color lists
        /// </summary>
        public void Summarize()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Piece " + i.ToString() + "\n" + Pieces[i].ToString() + "Cell Color : " + Colors[i] + "\n");
            }
            Console.WriteLine("Relative position : \n On Horizontal : " + isOnHorizontal
                + "\n On Vertical : " + isOnVertical +
                "\n On Diagonal : " + isOnDiagonal);
        }
    }
}
