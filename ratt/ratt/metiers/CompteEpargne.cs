using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers
{
    class CompteEpargne : Compte
    {
        //les attributs
        private double Taux;
        private bool close=false;
        private bool decouverte = false;
        private List<Compte> com = new List<Compte>();


        //les methodes
        Compte co;
        //com.add(co);
        public CompteEpargne(int index,double taux) : base(index)
        {
            this.Taux = taux;
        }

        public void settaux(double taux)
        {
            this.Taux = taux;
        }


        public double gettaux()
        {
            return this.Taux;
        }



        public void cloturer()
        {
            if(co.getSolde()<100)
            {
                this.close = true;
            }
        }




        public void decouvert()
        {
            if (co.getSolde() < 0)
            {
                this.decouverte = true;
            }
        }


    }
}
