using System.Collections.Generic;

namespace cw_1
{
    /// <summary>
    /// Class for comparing triangles
    /// </summary>
    class TrianglesComparer
    {
        public List<Triangle> TrianglesArray { get; }
        /// <summary>
        /// Constructor tha sets TrianglesArray propertie
        /// </summary>
        /// <param name="trianglesArray">Array of triangles</param>
        public TrianglesComparer(Triangle[] trianglesArray)
        {
            TrianglesArray.AddRange(trianglesArray);
        }

        public bool isThereEqualTriangles()
        {
            for (int i = 0; i < TrianglesArray.Count; i++)
            {
                TrianglesArray[i].DisplaySides();
                for (int j = i + 1; j < TrianglesArray.Count; j++)
                {
                    if (TrianglesArray[i].Equals(TrianglesArray[j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
