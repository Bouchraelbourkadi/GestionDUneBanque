using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers
{
    class CompteCourant : Compte
    {
        private double Decouverte;

        public CompteCourant(int index, double decouverte) : base(index)
        {
            this.Decouverte = decouverte;
        }

        public void setDecouverte(double decouverte)
        {
            this.Decouverte = decouverte;
        }

        public double getDecouverte()
        {
            return this.Decouverte;
        }

    }
}
