namespace cw_1
{
    class Program
    {
        static void Main()
        {
            Point A = new Point(0, 0);
            Point B = new Point(2, 4);
            Point C = new Point(4, 0);
            Point A1 = new Point(1, 0);
            Point B1 = new Point(3, 4);
            Point C1 = new Point(5, 99);
            Triangle[] ArrayOfTriangles = new Triangle[3] { new Triangle(A, B, C), new Triangle(B, A, C), new Triangle(A1, B1, C) };
            TrianglesComparer trianglesComparer = new TrianglesComparer(ArrayOfTriangles);
            trianglesComparer.isThereEqualTriangles();
        }
    }
}
