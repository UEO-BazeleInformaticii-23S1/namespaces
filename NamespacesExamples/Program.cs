using twoD = NamespacesExamples.TwoD;
using threeD = ThreeDLibrary;

namespace NamespacesExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            twoD::Point p2D = new twoD::Point();
            p2D.X = 100;
            p2D.Y = 200;

            threeD.Point p3D = new threeD.Point();
            p3D.X = 100;
            p3D.Y = 200;
            p3D.Z = 300;

            Console.WriteLine("Hello, World!");
        }
    }
}