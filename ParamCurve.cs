using System;
using System.Collections.Generic;
using ParametricEquations;

namespace ParametricCurveEquation
{
    public class ParametricCurve
    {
        public double Xt;
        public double Yt;
        public double Zt;
        List<Point> Points;

        public ParametricCurve(double xt, double yt, double zt)
        {
            Xt = xt;
            Yt = yt;
            Zt = zt;
            Points = new List<Point>();
        }
        public void GeneratePoints(int amout)
        {
            Point originPoint = new Point(0, 0, 0);
            List<Point> points = new List<Point>();
            points.Add(originPoint);
            points.Remove(originPoint);
            for (int i = 0; i < amout; i++)
            {
                double t = i;
                // double computedXt = i * Math.Cos(i);
                // double computedYt = i * Math.Sin(i);
                Point computedPoint = ComputedPoint(t, t, t);
                points.Add(computedPoint);
            }
            Points = points;
        }
        public Point ComputedPoint(double xt, double yt, double zt)
        {
            double computedXt = (150 - 10 * Math.Sin(60 * xt * 0.01)) * Math.Cos(xt * 0.01);
            double computedYt = (150 - 10 * Math.Sin(60 * yt * 0.01)) * Math.Sin(yt * 0.01);
            double computedZt = 10 * Math.Cos(60 * zt * 0.01);
            Point computedPoint = new Point(computedXt, computedYt, computedZt);
            return computedPoint;
        }
        public string GeneratedPointsToString()
        {
            string strg = "";

            foreach (Point point in Points)
            {
                strg += "\n" + "{" + point.X.ToString() + "," + point.Y.ToString() + "," + point.Z.ToString() + "}";
            }
            return strg;
        }


        public string GeneratedPointsToCSV()
        {
            string CSV = "";

            foreach (Point point in Points)
            {
                CSV += "\n" + point.X.ToString() + "," + point.Y.ToString() + "," + point.Z.ToString();
            }
            return CSV;
        }
    }
}