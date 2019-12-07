using System;
using System.Collections.Generic;

namespace cw_1
{
    /// <summary>
    /// Class for Triangle objects
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// List of points
        /// </summary>
        public List<Point> top { get; }
        /// <summary>
        /// List of distances between tops
        /// </summary>
        public List<double> sides { get; }
        /// <summary>
        /// Constructor with Array param
        /// </summary>
        /// <param name="ArrayOfPoints">Contains tops of triangle</param>
        public Triangle(Point[] ArrayOfPoints)
        {
            top.AddRange(ArrayOfPoints);
            CalculateSides(ArrayOfPoints);
        }
        /// <summary>
        /// Constructor with 3 points param
        /// </summary>
        /// <param name="A">1st top</param>
        /// <param name="B">2nd top</param>
        /// <param name="C">3d top</param>
        public Triangle(Point A, Point B, Point C)
        {
            top.AddRange(new Point[] { A, B, C });
            CalculateSides(new Point[] { A, B, C });
        }
        /// <summary>
        /// Calculates sides of this triangle
        /// </summary>
        /// <param name="ArrayOfPoints">3 points of triangle</param>
        private void CalculateSides(Point[] ArrayOfPoints)
        {
            for (int i = 0; i < 3; i++)
            {
                sides.Add(ArrayOfPoints[i].CalculateDistance(ArrayOfPoints[(i + 1) % 3]));
            }
            sides.Sort();
        }
        /// <summary>
        /// Displays sides of triangle
        /// </summary>
        public void DisplaySides()
        {
            foreach (var c in sides)
            {
                Console.WriteLine(c);
            }
        }
        /// <summary>
        /// Override method equals 
        /// </summary>
        /// <param name="obj">2nd triangle for comparing</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Triangle buffer = (Triangle)obj;

            for (int i = 0; i < 3; i++)
            {
                if (Math.Abs(sides[i] - buffer.sides[i]) >= Double.Epsilon)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
