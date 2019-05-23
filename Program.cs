using System;
using System.IO;
using ParametricCurveEquation;

namespace ParametricEquations
{
    class Program
    {
        /// This is the main method of the software.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create the torus surface
            Torus torus = new Torus(Plane.PlaneXZ, 100,15);
            torus.Plane.Origin = new Point(6.657, 2.654, 8.67);
            Vector v = new Vector(1, 0, 0);
            v=Vector.UnitX;
            Plane pln = Plane.PlaneXY;
            torus.ComputeTorus(10, 10);
            v.Multiply(100);
            double length=v.Length;
            File.WriteAllText("Out/testPoint.csv", torus.TestPointsToCSV());
            GenerateCurve();

        }
        static void GenerateCurve()
        {
            Point pt = new Point(0, 0, 0);
            ParametricCurve curve = new ParametricCurve(0, 0, 0);
            curve.GeneratePoints(100);
            File.WriteAllText("Out/GeneratedPoints.csv", curve.GeneratedPointsToCSV());
        }

    }
}
