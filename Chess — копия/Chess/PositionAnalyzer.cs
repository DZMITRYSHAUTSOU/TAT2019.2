using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class PositionAnalyzer
    {
        List<ChessPiece> Pieces { get; } = new List<ChessPiece>();
        List<string> Colors { get; } = new List<string>();
        public PositionAnalyzer() { }
        bool isOnHorizontal;
        bool isOnVertical;
        bool isOnDiagonal;
        public PositionAnalyzer(ChessPiece first, ChessPiece second)
        {
            Pieces.Add(first);
            Pieces.Add(second);
            Analyze();
        }
        public void Analyze()
        {
            if (Pieces.Count == 2)
            {
                for(int i=0;i<2;i++)
                {
                    Colors.Add(GetColor(Pieces[i]));
                }
                SetRelativePositionData();
                Summarize();
            }
        }
        private void SetRelativePositionData()
        {
            isOnHorizontal = Pieces[0].HorizontalCoordinate == Pieces[1].HorizontalCoordinate;
            isOnVertical = Pieces[0].VerticalCoordinate == Pieces[1].VerticalCoordinate;
            isOnDiagonal = Math.Abs(Pieces[1].HorizontalCoordinate-Pieces[0].HorizontalCoordinate)==
                Math.Abs(Pieces[1].VerticalCoordinate - Pieces[0].VerticalCoordinate);
        }
        public string GetColor(ChessPiece piece)
        {
            return piece.HorizontalCoordinate % 2 == piece.VerticalCoordinate % 2 ? "Black" : "white";
        }
        private void Summarize()
        {
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("Piece " + i.ToString() + "\n" + Pieces[i].ToString() + "Color : " + Colors[i] + "\n");
            }
            Console.WriteLine("Relative position : \n Horizontal : " + isOnHorizontal
                + "\n Vertical : " + isOnVertical +
                "\n Diagonal : " + isOnDiagonal);
        }
    }
}
