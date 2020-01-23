using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers
{
    class Operations
    {
        //les attributs
        private int num;
        private int idcompte;
        private DateTime dateOpertaion;
        private string typeOperation;
        private double montant;
        private List<Compte> com= new List<Compte>();
        Random aleatoire = new Random(6);




        //les methodes

            public Operations(int id,string type)
        {
            num = aleatoire.Next();
            dateOpertaion = DateTime.Now;
            idcompte = id;
            typeOperation = type;
        }



     


        //versement
        public void verser(double mt,Compte com,int id)
        {
            foreach(Compte c in this.com)
            {
                if (c.getnum() == id)
                {
                    c.setSolde(c.getSolde() + mt);
                }
            }
           
        }

        //virement
        public void virmer(double mt, int code)
        {
      

        }
        //paiement par carte
        //paiement par internet
        //retrait d'argent
        public void retrait(double mt)
        {
            //c.setSolde(c.getSolde() - mt);
        }


        public int getid()
        {
            return this.idcompte;
        }


        public DateTime getdate()
        {
            return this.dateOpertaion;
        }




        public string getTYPE()
        {
            return this.typeOperation;
        }

    }
}
