using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt.metiers 
{
    class Client_physique : Client
    {
        //attributs
        int cin;
        String nom;
        string prenom;
        DateTime date_naiss;
        String lieu_naiss;
        String adresse;
        String mail;
        int GSM;


        //methodes

       public Client_physique(int newcin, String newnom, string newprenom,
            DateTime newdate_naiss, String newlieu_naiss, String newadresse, String newmail, int newGSM)
        {
            this.cin = newcin;
            this.adresse = newadresse;
            this.date_naiss = newdate_naiss;
            this.lieu_naiss = newlieu_naiss;
            this.mail = newmail;
            this.nom = newnom;
            this.prenom = newprenom;
            this.GSM = newGSM;
         
        }


        }

    
}
