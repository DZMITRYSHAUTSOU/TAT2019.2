using System;

namespace Chess
{
    /// <summary>
    /// Custom exception for wrong input case 
    /// </summary>
    class InvalidChessCoordinatesException : Exception
    {
        public override string Message => "Wrong coordinates. Your coordinates must be in range 1-8 and a-h!";
    }
}
