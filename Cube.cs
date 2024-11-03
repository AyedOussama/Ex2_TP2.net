using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Tp2
{
    // sealed signifie qu'on ne peut pas hériter de cette classe
    internal sealed class Cube : Brique
    {
        public Cube(Point3D centre, double cote) : base(centre, cote, cote, cote) { }

        public override string ToString()
        {
            return $"[Cube\ncentre de gravité : {centreGravite}\ncôté : {largeur}\n]";
        }
    }
}
