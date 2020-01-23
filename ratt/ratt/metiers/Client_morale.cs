using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers 
{
    class Client_morale : Client
    {
        //attributs
        int num;
        String raisonSocial;
        DateTime dateCreation;

        //methodes
       public Client_morale(int newnum,String newraisonSocial,DateTime newdateCreation)
        {
            this.num = newnum;
            this.raisonSocial = newraisonSocial;
            this.dateCreation = newdateCreation;
        }


        //getters and setters

        public string getraisonSoc()
        {
            return this.raisonSocial;
        }


        public DateTime getdateCre()
        {
            return this.dateCreation;
        }


        public void setraisonSoc(String raisonS)
        {
             this.raisonSocial=raisonS;
        }

        public  void setdateCre(DateTime date)
        {
             this.dateCreation=date;
        }




    }
}
