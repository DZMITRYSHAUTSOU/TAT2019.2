using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class InvalidChessCoordinatesException : Exception
    {
        public override string Message => "Wrong coordinates. Your coordinates must be in range 1-8 and a-h!";
    }
}
