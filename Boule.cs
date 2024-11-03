using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Tp2
{
    internal class Boule : Forme
    {
        private double rayon;
        private const double PI = 3.14;

        public Boule(Point3D centre, double r) : base(centre)
        {
            rayon = r;
        }

        public override double CalculerSurface()
        {
            return 4 * PI * rayon * rayon;
        }

        public override double CalculerVolume()
        {
            return (4.0 / 3.0) * PI * rayon * rayon * rayon;
        }

        public override string ToString()
        {
            return $"[Boule\ncentre de gravité : {centreGravite}\nrayon : {rayon}\n]";
        }

        public bool Equals(Boule other)
        {
            if (other == null) return false;
            return centreGravite.Equals(other.centreGravite) && rayon == other.rayon;
        }

    }
}
