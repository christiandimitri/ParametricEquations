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

        public void TorusClass(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Point tPoint = ComputeTpoint(i);
                Point SPoint = ComputeSpoint(i);
                PointsT.Add(tPoint);
                PointsS.Add(SPoint);
            }

        }

        public Point ComputeTpoint(double tVariable)
        {
            double t = tVariable;
            double sConstant = Math.PI;
            double computeXt = 3 * Math.Cos(t) + Math.Cos(t) * Math.Cos(sConstant);
            double computeYt = 3 * Math.Sin(t) + Math.Sin(t) * Math.Cos(sConstant);
            double computeZt = Math.Sin(sConstant);
            Point pointT = new Point(computeXt, computeYt, computeZt);
            return pointT;


        }
        // public void ComputeTpoints(int amount)
        // {
        //     double constantS = Math.PI;
        //     for (int t = 0; t < amount; t++)
        //     {
        //         double xt = 3 * Math.Cos(t) + Math.Cos(t) * Math.Cos(constantS);
        //         double yt = 3 * Math.Sin(t) + Math.Sin(t) * Math.Cos(constantS);
        //         double zt = Math.Sin(constantS);
        //         Point pointT = new Point(xt, yt, zt);
        //         PointsT.Add(pointT);
        //     }
        // }


        // public void ComputeSpoints(int amount)
        // {
        //     double constantT = Math.PI;
        //     for (int s = 0; s < amount; s++)
        //     {
        //         double xs = 3 * Math.Cos(constantT) + Math.Cos(constantT) * Math.Cos(s);
        //         double ys = 3 * Math.Sin(constantT) + Math.Sin(constantT) * Math.Cos(s);
        //         double zs = Math.Sin(s);
        //         Point pointS = new Point(xs, ys, zs);
        //         PointsS.Add(pointS);
        //     }
        // }



        public Point ComputeSpoint(double sVariable)
        {
            double s = sVariable;
            double tConstant = Math.PI;
            double computeXs = 3 * Math.Cos(tConstant) + Math.Cos(tConstant) * Math.Cos(s);
            double computeYs = 3 * Math.Sin(tConstant) + Math.Sin(tConstant) * Math.Cos(s);
            double computeZs = Math.Sin(s);
            Point pointS = new Point(computeXs, computeYs, computeZs);
            return pointS;
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