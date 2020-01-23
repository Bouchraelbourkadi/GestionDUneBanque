using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers
{
    class Compte
    {

        //les attributs
        private int num_co;
        private DateTime dateOuverture;
        protected double Solde;
        List<Client> c = new List<Client>();
        List<Operations> opera = new List<Operations>();
        List<Compte> comptes = new List<Compte>();


       public Compte()
        {

        }
        //les methodes
       public Compte(int idex)//constructeur
        {
            this.num_co = idex;
            this.Solde = 0.00;
            this.dateOuverture = DateTime.Now;
        

        }



      
        


        public int getnum()
        {
            return this.num_co;
        }

        public void setSolde( double solde)
        {
            this.Solde = solde;
        }

        public double getSolde()
        {
            return this.Solde;
        }

    }
}
