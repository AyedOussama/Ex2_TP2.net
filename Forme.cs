using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Tp2
{
    internal abstract class Forme
    {
        protected Point3D centreGravite; // protected permet que le variable  soit accessible aux classes dérivées

        public Forme(Point3D centre)
        {
            centreGravite = centre;
        }

        public void Bouger(double x, double y, double z)
        {
            centreGravite.X += x;
            centreGravite.Y += y;
            centreGravite.Z += z;
        }

        public abstract double CalculerSurface();
        public abstract double CalculerVolume();
    }
}
