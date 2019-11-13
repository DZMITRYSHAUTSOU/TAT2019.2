using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ChessPiece piece1 = new ChessPiece('a', 1);
                ChessPiece piece2 = new ChessPiece('d', 7);
                PositionAnalyzer analyzer = new PositionAnalyzer(piece1, piece2);
            }
            catch(InvalidChessCoordinatesException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception, message : \n "+e.Message);
            }
        }
    }
}
