using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessPiece
    {
        public char HorizontalCoordinate { get; }
        public int VerticalCoordinate { get; }
        public ChessPiece()
        {
            HorizontalCoordinate = 'a';
            VerticalCoordinate = 1;
        }
        public ChessPiece(char horizontalCoordinate, int verticalCoordinate)
        {
            if (ValidateCoordinates(horizontalCoordinate, verticalCoordinate))
            {
                HorizontalCoordinate = horizontalCoordinate;
                VerticalCoordinate = verticalCoordinate;
            }
            else throw new InvalidChessCoordinatesException();
        }
        public override string ToString()
        {
            return "Position : " + HorizontalCoordinate + " " + VerticalCoordinate+"\n";
        }
        private bool ValidateCoordinates(char horizontalCoordinate, int verticalCoordinate)
        {

            return horizontalCoordinate.ToString().CompareTo("I") < 0
                && Enumerable.Range(1, 8).Contains(verticalCoordinate);
        }
    }
}
