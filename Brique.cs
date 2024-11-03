using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Tp2
{
    internal class Brique : Forme
    {
        protected double largeur;
        protected double longueur;
        protected double hauteur;

        public Brique(Point3D centre, double l, double L, double h) : base(centre)
        {
            largeur = l;
            longueur = L;
            hauteur = h;
        }

        public override double CalculerSurface()
        {
            return 2 * (largeur * longueur + largeur * hauteur + longueur * hauteur);
        }

        public override double CalculerVolume()
        {
            return largeur * hauteur * longueur;
        }

        public override string ToString()
        {
            return $"[Brique\ncentre de gravité : {centreGravite}\nlargeur : {largeur}\nlongueur : {longueur}\nhauteur : {hauteur}\n]";
        }
    }
}
