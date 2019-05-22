using System;
using System.Collections.Generic;

namespace ParametricSurfaceEquation
{
    public class SurfaceEquation
    {
        public double Xt;
        public double Yt;
        public double Zt;
        List<Point> PointsT;
        List<Point> PointsS;

        public SurfaceEquation()
        {
            PointsS = new List<Point>();
            PointsT = new List<Point>();
        }
        public void GeneratePoints(int amount)
        {
            double constantS = Math.PI;
            for (int t = 0; t < amount; t++)
            {
                double xt = 3 * Math.Cos(t) + Math.Cos(t) * Math.Cos(constantS);
                double yt = 3 * Math.Sin(t) + Math.Sin(t) * Math.Cos(constantS);
                double zt = Math.Sin(constantS);
                Point pointT = new Point(xt, yt, zt);
                PointsT.Add(pointT);
            }
            for (int s = 0; s < amount; s++)
            {
                double xs = 3 * Math.Cos(constantS) + Math.Cos(constantS) * Math.Cos(s);
                double ys = 3 * Math.Sin(constantS) + Math.Sin(constantS) * Math.Cos(s);
                double zs = Math.Sin(s);
                Point pointS = new Point(xs, ys, zs);
                PointsS.Add(pointS);
            }
        }
        public string TPointsToString()
        {
            string CSV = "";
            foreach (Point point in PointsT)
            {
                CSV += "\n" + point.PointToCSV();
            }
            return CSV;
        }

        public string TPointsToCSV()
        {
            string CSV = "";
            foreach (Point point in PointsT)
            {
                CSV += "\n" + point.PointToCSV();
            }
            return CSV;


        }
        public string SPointsToCSV()
        {
            string CSV = "";
            foreach (Point point in PointsS)
            {
                CSV += "\n" + point.PointToCSV();
            }
            return CSV;
        }
    }
}