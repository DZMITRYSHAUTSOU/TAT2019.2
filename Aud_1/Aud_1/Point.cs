using System;

namespace CW_1
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
        /// Default constructor without params, sets X and Y field to 0
        /// </summary>
        public Point()
        {
            x = 0;
            y = 0;
        }
        /// <summary>
        /// This method counts distance between this point and point from params
        /// </summary>
        /// <param name="point">2nd point for counting distance </param>
        /// <returns></returns>
        public double CalculateDistance(Point point)
        {
            return Math.Pow(Math.Pow(point.x-this.x,2)+ Math.Pow(point.y - this.y, 2), 0.5);
        }
    }
}
