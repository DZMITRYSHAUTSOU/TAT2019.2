using System;

namespace Chess
{
    /// <summary>
    /// Program's Entry Point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ChessPiece piece1 = new ChessPiece('b', 2);
                ChessPiece piece2 = new ChessPiece('a', 5);
                PositionAnalyzer analyzer = new PositionAnalyzer(piece1, piece2);
                analyzer.Analyze();
            }
            catch (InvalidChessCoordinatesException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception, message : \n " + e.Message);
            }
        }
    }
}