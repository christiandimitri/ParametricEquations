using System;
using System.Collections.Generic;

namespace ParametricSurfaceEquation
{
    public class Point

    {
        public double X;
        public double Y;
        public double Z;

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public string PointToString()
        {
            return "Point" + "{" + X + "," + Y + "," + Z + "}";
        }
        public string PointToCSV()
        {
            return X + "," + Y + "," + Z;
        }
    }
}