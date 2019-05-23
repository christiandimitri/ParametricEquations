using System;
using System.Collections.Generic;

namespace ParametricEquations
{
    public class Torus
    {
        public double Xt;
        public double Yt;
        public double Zt;
        List<Point> TestList;

        public Torus()
        {
            TestList = new List<Point>();
        }

        public void ComputeTorus(int Ucount, int Vcount)
        {
            for (int i = 0; i < Ucount; i++)
            {

                for (int j = 0; j < Vcount; j++)
                {
                    Point point = ComputePoint((double)i / Ucount, (double)j / Vcount);
                    TestList.Add(point);
                }

            }

        }

        public Point ComputePoint(double t, double s)
        {
            t *= 2 * Math.PI;
            s *= 2 * Math.PI;
            double computeX = 3 * Math.Cos(t) + Math.Cos(t) * Math.Cos(s);
            double computeY = 3 * Math.Sin(t) + Math.Sin(t) * Math.Cos(s);
            double computeZ = Math.Sin(s);
            Point computedPoint = new Point(computeX, computeY, computeZ);
            return computedPoint;
        }

        public string TestPointsToCSV()
        {
            string CSV = "";
            foreach (Point point in TestList)
            {
                CSV += "\n" + point.PointToCSV();
            }
            return CSV;
        }


    }
}