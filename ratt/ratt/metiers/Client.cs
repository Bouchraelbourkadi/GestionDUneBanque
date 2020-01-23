using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers
{
    class Client
    {
        //les attributs
        int idclient;
        private string situation = "vivre";
        private List<Client_physique> cp = new List<Client_physique>();
        private List<Client_morale> cm = new List<Client_morale>();
        Random aleatoire = new Random(3);
        Client_physique cp1;
        Client_morale cm1;


        public Client()
        {

        }
        //creation d'un client physique 

        public Client(int cin, String nom,string prenom,DateTime date_naiss,String lieu_naiss,String adresse,
        String mail,int GSM)
        {
            cp1 = new Client_physique(cin, nom, prenom, date_naiss, lieu_naiss, adresse, mail, GSM);
            cp.Add(cp1);
            this.idclient = aleatoire.Next();
            
        }


        //creation d'un client morale

        public Client(int newnum, String newraisonSocial, DateTime newdateCreation)
        {
            cm1 = new Client_morale(newnum, newraisonSocial, newdateCreation);
            cm.Add(cm1);
            this.idclient = aleatoire.Next();
         
        }



        public int getnum()
        {
            return this.idclient;
        }

    }
}
