using System;
using System.Collections.Generic;

namespace ParametricEquations
{
    public class Plane
    {
        public Vector Xaxis;

        public Vector Yaxis;

        public Vector Zaxis;
        public Point Origin;

        public Plane(Point origin, Vector xAxis, Vector yAxis, Vector zAxis)
        {
            Origin = origin;
            Xaxis = xAxis;
            Yaxis = yAxis;
            Zaxis = zAxis;

        }

        public static Plane PlaneXY => new Plane(Point.Origin, Vector.UnitX, Vector.UnitY, Vector.UnitZ);
        public static Plane PlaneXZ => new Plane(Point.Origin, Vector.UnitX, Vector.UnitZ, Vector.UnitY);
        public static Plane PlaneYZ => new Plane(Point.Origin, Vector.UnitY, Vector.UnitZ, Vector.UnitX);


    }
}