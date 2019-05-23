using System;
using System.IO;
using ParametricCurveEquation;

namespace ParametricEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Torus srf = new Torus();
            srf.ComputeTorus(10, 10);
            File.WriteAllText("testPoint.csv", srf.TestPointsToCSV());
            GenerateCurve();

        }
        static void GenerateCurve()
        {
            Point pt = new Point(0, 0, 0);
            ParametricCurve curve = new ParametricCurve(0, 0, 0);
            curve.GeneratePoints(100);
            File.WriteAllText("GeneratedPoints.csv", curve.GeneratedPointsToCSV());
        }

    }
}
