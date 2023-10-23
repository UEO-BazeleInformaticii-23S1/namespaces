//using NamespacesExamples.TwoD;
//using NamespacesExamples.ThreeD;

namespace NamespacesExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoD.Point p2D = new TwoD.Point();
            p2D.X = 100;
            p2D.Y = 200;

            ThreeD.Point p3D = new ThreeD.Point();
            p3D.X = 100;
            p3D.Y = 200;
            p3D.Z = 300;

            Console.WriteLine("Hello, World!");
        }
    }
}