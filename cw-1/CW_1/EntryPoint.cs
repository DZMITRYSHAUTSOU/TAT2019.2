namespace CW_1
{
    /// <summary>
    /// Main class
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        static void Main()
        {
            Point A = new Point(0, 0);
            Point B = new Point(2, 4);
            Point C = new Point(4, 0);
            Point A1 = new Point(1, 0);
            Point B1 = new Point(3, 4);
            Point C1 = new Point(5, 99);
            bool result=false;
            Triangle[] ArrayOfTriangles = new Triangle[3] {new Triangle(A, B, C), new Triangle(B, A, C), new Triangle(A1, B1, C)};
            for (int i = 0; i < ArrayOfTriangles.Length; i++)
            {
                ArrayOfTriangles[i].DisplaySides();
                for (int j = i+1; j < ArrayOfTriangles.Length; j++)
                {
                    if (ArrayOfTriangles[i].Equals(ArrayOfTriangles[j]))
                    {
                        result = true;
                        break;
                    }
                }
            }
        }
    }
}
