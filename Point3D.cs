using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Tp2
{
    internal class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"[Point3D x:{X} , y:{Y}, z:{Z}]";
        }

        public bool Equals(Point3D other)
        {
            if (other == null) return false;
            return X == other.X && Y == other.Y && Z == other.Z;
        }
    }
}
