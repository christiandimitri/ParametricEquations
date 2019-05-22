using System;
using System.IO;

namespace ParametricSurfaceEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SurfaceEquation srf = new SurfaceEquation();
            srf.GeneratePoints(6);
            Console.WriteLine(srf.TPointsToString());

            File.WriteAllText("TPoints.csv", srf.TPointsToCSV());
            File.WriteAllText("SPoints.csv", srf.SPointsToCSV());

        }


    }
}
