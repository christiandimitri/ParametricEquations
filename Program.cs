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
            srf.ComputeTpoint(0);
            srf.ComputeSpoint(0);
            srf.TorusClass(6);
            Console.WriteLine(srf.TPointsToString());

            File.WriteAllText("TPoints.csv", srf.TPointsToCSV());
            File.WriteAllText("SPoints.csv", srf.SPointsToCSV());

        }


    }
}
