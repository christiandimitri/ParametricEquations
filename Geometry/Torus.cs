using System;
using System.Collections.Generic;

namespace ParametricEquations
{
    public class Torus
    {

        public double Radius1;
        public double Radius2;

        public Plane Plane;

        public double Area => 4 * Math.PI * Math.PI * Radius1 * Radius2;
        public double Volume => 2 * Math.PI * Math.PI * Radius1 * Radius2 * Radius2;
        List<Point> TestList;

        public Torus(Plane plane, double radius1, double radius2)
        {
            Plane = plane;
            Radius1 = radius1;
            Radius2 = radius2;
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
            double computeX = (Radius1 + Radius2 * Math.Cos(t)) * Math.Cos(s);
            double computeY = (Radius1 + Radius2 * Math.Cos(t)) * Math.Sin(s);
            double computeZ = Radius2 * Math.Sin(t);


            Vector vector1 = new Vector(Plane.Xaxis);
            vector1.Multiply(computeX);
            Vector vector2 = new Vector(Plane.Yaxis);
            vector2.Multiply(computeY);
            Vector vector3 = new Vector(Plane.Zaxis);
            vector3.Multiply(computeZ);
            vector1.Add(vector2);
            vector1.Add(vector3);
            Point computedPoint = new Point(Plane.Origin.X, Plane.Origin.Y, Plane.Origin.Z);
            computedPoint.Add(vector1);
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