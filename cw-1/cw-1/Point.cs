using System;

namespace cw_1
{
    /// <summary>
    /// Class for Point objects
    /// </summary>
    class Point
    {
        public double x;
        public double y;
        /// <summary>
        /// Takes 2 params for X and Y
        /// </summary>
        /// <param name="x">value for X field</param>
        /// <param name="y">value for Y field</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// This method counts distance between this point and point from params
        /// </summary>
        /// <param name="point">2nd point for counting distance </param>
        /// <returns></returns>
        public double CalculateDistance(Point secondPoint)
        {
            return Math.Pow(Math.Pow(secondPoint.x - x, 2) + Math.Pow(secondPoint.y - y, 2), 0.5);
        }
    }
}
