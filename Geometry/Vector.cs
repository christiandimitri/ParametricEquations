

using System;

namespace ParametricEquations
{
    public class Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector(Vector vector)
        {
            X = vector.X;
            Y = vector.Y;
            Z = vector.Z;
        }

        public static Vector UnitX => new Vector(1, 0, 0);
        public static Vector UnitY => new Vector(0, 1, 0);
        public static Vector UnitZ => new Vector(0, 0, 1);

        public void Multiply(double number)
        {
            X *= number;
            Y *= number;
            Z *= number;
        }

        public void Divide(double number)
        {
            X /= number;
            Y /= number;
            Z /= number;
        }
        public void Substract(Vector vector)
        {
            X -= vector.X;
            Y -= vector.Y;
            Z -= vector.Z;
        }
        public void Add(Vector vector)
        {
            X += vector.X;
            Y += vector.Y;
            Z += vector.Z;
        }
        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);
        public void Unitize()
        {
            double length = Length;
            X /= length;
            Y /= length;
            Z /= length;
        }
        public Vector Unit()
        {
            double length = Length;
            return new Vector(X / length, Y / length, Z / length);
        }

    }
}