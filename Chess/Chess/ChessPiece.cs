using System.Linq;

namespace Chess
{
    /// <summary>
    /// Class for chess piece
    /// </summary>
    class ChessPiece
    {
        public char HorizontalCoordinate { get; }
        public int VerticalCoordinate { get; }
        /// <summary>
        /// No arguments constructor
        /// </summary>
        public ChessPiece()
        {
            HorizontalCoordinate = 'a';
            VerticalCoordinate = 1;
        }
        /// <summary>
        /// Takes 2 parameters for coordinates and usese them if they are valid
        /// </summary>
        /// <param name="horizontalCoordinate">Char propertie for future piece</param>
        /// <param name="verticalCoordinate">Int propertie for future piece</param>
        public ChessPiece(char horizontalCoordinate, int verticalCoordinate)
        {
            if (ValidateCoordinates(horizontalCoordinate, verticalCoordinate))
            {
                HorizontalCoordinate = horizontalCoordinate;
                VerticalCoordinate = verticalCoordinate;
            }
            else throw new InvalidChessCoordinatesException();
        }
        /// <summary>
        /// Overrides ToString()
        /// </summary>
        /// <returns>String with all info</returns>
        public override string ToString()
        {
            return "Position : " + HorizontalCoordinate + " " + VerticalCoordinate + "\n";
        }
        /// <summary>
        /// Coordinates must be in range 1-8 and a-h. Throws custom exception if they not.
        /// </summary>
        /// <param name="horizontalCoordinate">Char coordinate<param>
        /// <param name="verticalCoordinate">Int coordinate</param>
        /// <returns>True if everything is correct</returns>
        private bool ValidateCoordinates(char horizontalCoordinate, int verticalCoordinate)
        {
            return Enumerable.Range(97, 8).Contains(horizontalCoordinate)
                && Enumerable.Range(1, 8).Contains(verticalCoordinate);
        }
    }
}