using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratt
{
    class Program
    {
        static void Main(string[] args)
        {

            //mes attributs
            int choi;
            List<metiers.Client> clients= new List<metiers.Client>();
            List<metiers.Compte> co = new List<metiers.Compte>();
            List<metiers.Operations> ope = new List<metiers.Operations>();
            metiers.Compte comptes;
            metiers.Operations op;


            //pour un client physique
            int cin;
            String nom;
            string prenom;
            DateTime date_naiss;
            String lieu_naiss;
            String adresse;
            String mail;
            int GSM;
            string choixcompte;

            //pour un client morale
            int num;
            String raisonSocilal;
            DateTime dateCreation;





            Console.WriteLine("*****************BIENVENUE*******************");
            Console.WriteLine("1/ Nouveau Compte           ***           2/se connecter a mon compte");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.WriteLine("etes vous une entreprise? O/N");
                    string ch= Console.ReadLine();
                    switch (ch)
                    {
                        case "O":
                            Console.Write("L'IDENTIFIANT D'ENTREPRISE : ");
                            num = int.Parse(Console.ReadLine());
                            Console.Write("RAISON SOCIALE : ");
                            raisonSocilal=Console.ReadLine();
                            Console.Write("DATE DE CREATION : ");
                            dateCreation = DateTime.Parse(Console.ReadLine());
                            Console.Write("voulez vous un compte courant ou epargne?");
                            choixcompte = Console.ReadLine();

                            metiers.Client cl2 = new metiers.Client(num, raisonSocilal, dateCreation);
                            clients.Add(cl2);

                            ///creation d'un nouveau compte
                            comptes = new metiers.Compte(cl2.getnum());
                            co.Add(comptes);
                            /**********l'affichage***************************/
                            Console.Clear();
                            Console.WriteLine("****************** Bonjour COMPTE CREE AVEC SUCCEE *****************");
                            foreach (metiers.Compte c in co)
                            {
                                if (c.getnum() == cl2.getnum())
                                {
                                    Console.WriteLine("code = " + c.getnum() );
                                    Console.WriteLine("Solde = " + c.getSolde());
                                }
                            }

                            Console.WriteLine("1/ QUITTER          **       2/MENU PRINCIPALE");
                            int choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    //Console.Out();
                                    break;
                                case 2:
                                    //cleaner la console et afficher le 
                                    Console.Clear();
                                    Console.WriteLine("********************** MENU PRINCIPALE ********************");
                                    Console.WriteLine("1- VERSEMENT ");
                                    Console.WriteLine("2- VIREMENT ");
                                    Console.WriteLine("3- RETRAIT D'ARGENT ");
                                    Console.WriteLine("4- CONSULTER MON SOLDE ");
                                    Console.WriteLine("5- Mon Compte ");
                                    Console.WriteLine("6- MES OPERATIONS BANCAIRES ");
                                    Console.WriteLine("7- QUITTER ");
                                    Console.WriteLine();
                                    do
                                    {
                                        Console.Write("Veuillez saisir votre choix:  ");
                                        choi = int.Parse(Console.ReadLine());
                                        switch (choi)
                                        {
                                            case 1:
                                                Console.Write("combien voulez vous verser:  ");
                                                int versement = int.Parse(Console.ReadLine());
                                                op = new metiers.Operations(comptes.getnum(), "versement");
                                                ope.Add(op);
                                                op.verser(versement, comptes, cl2.getnum());
                                                /*****************VERSER********************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        c.setSolde(c.getSolde() + versement);
                                                    }
                                                }
                                                /*****************************************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                                    }
                                                }
                                                Console.WriteLine();
                                                break;


                                            case 3:
                                                Console.Write("combien voulez vous tirer:  ");
                                                int retrait = int.Parse(Console.ReadLine());
                                                op = new metiers.Operations(comptes.getnum(), "retrait d'argent");
                                                ope.Add(op);
                                                op.verser(retrait, comptes, cl2.getnum());
                                                /*****************retrait d'argent********************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        c.setSolde(c.getSolde() - retrait);
                                                    }
                                                }
                                                /*****************************************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                                    }
                                                }
                                                Console.WriteLine();
                                                break;



                                            /*********************virement******************************/

                                            case 2:
                                                Console.Write("a qui voulez vous transformer l'argent veuillez taper son code:  ");
                                                int virmer = int.Parse(Console.ReadLine());
                                                Console.Write("combien de solde voulez vous virmer:  ");
                                                int solde = int.Parse(Console.ReadLine());


                                                op = new metiers.Operations(comptes.getnum(), "Virement");
                                                ope.Add(op);
                                                op.verser(virmer, comptes, cl2.getnum());


                                                /*****************virement d'argent********************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == virmer)
                                                    {
                                                        c.setSolde(c.getSolde() + solde);
                                                    }
                                                }
                                                /*******************apres chaque virement un retrait d'argent **********************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        c.setSolde(c.getSolde() - solde);
                                                    }
                                                }

                                                /*************************************************/
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                                    }
                                                }
                                                Console.WriteLine();
                                                break;

                                            case 5:
                                                Console.WriteLine("L'IDENTIFIANT D'ENTREPRISE : "+num);
                                                Console.WriteLine("RAISON SOCIALE : "+raisonSocilal);
                                                Console.WriteLine("DATE DE CREATION : "+dateCreation);
                                                Console.WriteLine();
                                                break;



                                            case 4:
                                                foreach (metiers.Compte c in co)
                                                {
                                                    if (c.getnum() == cl2.getnum())
                                                    {
                                                        Console.WriteLine("Votre solde est: = " + c.getSolde());
                                                    }
                                                }
                                                Console.WriteLine();
                                                break;



                                            case 6:
                                                Console.WriteLine("******************* LES OPERATIONS QUE VOUS AVEZ EFFECTUEES ******************* ");
                                                foreach (metiers.Operations o in ope)
                                                {
                                                    if (o.getid() == cl2.getnum())
                                                    {
                                                        Console.WriteLine(o.getTYPE() + "   le" + o.getdate());
                                                    }
                                                }
                                                Console.WriteLine();
                                                break;
                                        }

                                        
                                    } while (choi != 7);


                                    break;
                            }
                            break;




                        case "N":
                            Console.Write("CIN : ");
                            cin = int.Parse(Console.ReadLine());
                            Console.Write("NOM : ");
                            nom= Console.ReadLine();
                            Console.Write("PRENOM : ");
                            prenom= Console.ReadLine();
                            Console.Write("DATE DE NAISSANCE : ");
                            date_naiss = DateTime.Parse(Console.ReadLine());
                            Console.Write("LIEU DE NAISSANCE : ");
                            lieu_naiss= Console.ReadLine();
                            Console.Write("ADRESSE : ");
                            adresse= Console.ReadLine();
                            Console.Write("E-MAIL : ");
                            mail= Console.ReadLine();
                            Console.Write("GSM : ");
                            GSM = int.Parse(Console.ReadLine());
                           // Console.Write("voulez vous un compte courant ou epargne?");
                            //choixcompte = Console.ReadLine();

                            metiers.Client cl1 = new metiers.Client(cin, nom, prenom, date_naiss, lieu_naiss, adresse, mail, GSM);
                            clients.Add(cl1);
                            foreach(metiers.Client cl in clients)
                            {
                                Console.WriteLine(cl.getnum());

                            }
                            comptes = new metiers.Compte(cl1.getnum());
                            co.Add(comptes);

                            /**********l'affichage***************************/
                            foreach (metiers.Compte c in co)
                            {
                                if (c.getnum() == cl1.getnum())
                                {
                                    Console.WriteLine( "code = " + c.getnum() + "   Solde = " + c.getSolde());
                                }
                            }


                            /***************** MENU PRINCIPALE****************************/

                            //cleaner la console et afficher le 
                            Console.Clear();
                            Console.WriteLine("********************** MENU PRINCIPALE ********************");
                            Console.WriteLine("1- VERSEMENT ");
                            Console.WriteLine("2- VIREMENT ");
                            Console.WriteLine("3- RETRAIT D'ARGENT ");
                            Console.WriteLine("4- CONSULTER MON SOLDE ");
                            Console.WriteLine("5- Mon Compte ");
                            Console.WriteLine("6- MES OPERATIONS BANCAIRES ");
                            Console.WriteLine("7- QUITTER ");
                            Console.WriteLine();
                            do
                            {
                                Console.Write("Veuillez saisir votre choix:  ");
                                choi = int.Parse(Console.ReadLine());
                                switch (choi)
                                {
                                    case 1:
                                        Console.Write("combien voulez vous verser:  ");
                                        int versement = int.Parse(Console.ReadLine());
                                        op = new metiers.Operations(comptes.getnum(), "versement");
                                        ope.Add(op);
                                        op.verser(versement, comptes, cl1.getnum());
                                        /*****************VERSER********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                c.setSolde(c.getSolde() + versement);
                                            }
                                        }
                                        /*****************************************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;


                                    case 3:
                                        Console.Write("combien voulez vous tirer:  ");
                                        int retrait = int.Parse(Console.ReadLine());
                                        op = new metiers.Operations(comptes.getnum(), "retrait d'argent");
                                        ope.Add(op);
                                        op.verser(retrait, comptes, cl1.getnum());
                                        /*****************retrait d'argent********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                c.setSolde(c.getSolde() - retrait);
                                            }
                                        }
                                        /*****************************************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;



                                    /*********************virement******************************/

                                    case 2:
                                        Console.Write("a qui voulez vous transformer l'argent veuillez taper son code:  ");
                                        int virmer = int.Parse(Console.ReadLine());
                                        Console.Write("combien de solde voulez vous virmer:  ");
                                        int solde = int.Parse(Console.ReadLine());


                                        op = new metiers.Operations(comptes.getnum(), "Virement");
                                        ope.Add(op);
                                        op.verser(virmer, comptes, cl1.getnum());


                                        /*****************virement d'argent********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == virmer)
                                            {
                                                c.setSolde(c.getSolde() + solde);
                                            }
                                        }
                                        /*******************apres chaque virement un retrait d'argent **********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                c.setSolde(c.getSolde() - solde);
                                            }
                                        }

                                        /*************************************************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;

                                    case 5:
                                        Console.WriteLine("NOM: "+nom);
                                        Console.WriteLine("PRENOM :"+prenom);
                                        Console.WriteLine("CIN : "+cin);
                                        Console.WriteLine("ADRESSE :"+adresse);
                                        Console.WriteLine("E-MAIL :"+mail);
                                        Console.WriteLine("GSM :"+GSM);
                                        break;



                                    case 4:
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cl1.getnum())
                                            {
                                                Console.WriteLine("Votre solde est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;



                                    case 6:
                                        Console.WriteLine("******************* LES OPERATIONS QUE VOUS AVEZ EFFECTUEES ******************* ");
                                        foreach (metiers.Operations o in ope)
                                        {
                                            if (o.getid() == cl1.getnum())
                                            {
                                                Console.WriteLine(o.getTYPE() + "   le" + o.getdate());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;
                                }


                            } while (choi != 7);


                            /**********************************************************/
                            break;
                    }


                    break;



                case 2:
                    Console.Write("VOTRE CODE DU COMPTE : ");
                    int cd= int.Parse(Console.ReadLine());
                    Console.Write("LE NOM DE L'ENTREPRISE OU VOTRE NOM PERSONNELLE : ");
                    string name = Console.ReadLine();

                    /*****************verification si ce compte existe **********************/
                    foreach (metiers.Compte compt in co)
                    {
                        if (compt.getnum() == cd)
                        {
                            Console.Clear();

                            //l'affichage du menu des operations

                            Console.WriteLine("********************** MENU PRINCIPALE ********************");
                            Console.WriteLine("1- VERSEMENT ");
                            Console.WriteLine("2- VIREMENT ");
                            Console.WriteLine("3- RETRAIT D'ARGENT ");
                            Console.WriteLine("4- CONSULTER MON SOLDE ");
                            Console.WriteLine("5- Mon Compte ");
                            Console.WriteLine("6- MES OPERATIONS BANCAIRES ");
                            Console.WriteLine("7- QUITTER ");
                            Console.WriteLine();
                            do
                            {
                                Console.Write("Veuillez saisir votre choix:  ");
                                choi = int.Parse(Console.ReadLine());
                                switch (choi)
                                {
                                    case 1:
                                        Console.Write("combien voulez vous verser:  ");
                                        int versement = int.Parse(Console.ReadLine());
                                        op = new metiers.Operations(cd, "versement");
                                        ope.Add(op);
                                        /*****************VERSER********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                c.setSolde(c.getSolde() + versement);
                                            }
                                        }
                                        /*****************************************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;


                                    case 3:
                                        Console.Write("combien voulez vous tirer:  ");
                                        int retrait = int.Parse(Console.ReadLine());
                                        op = new metiers.Operations(cd, "retrait d'argent");
                                        ope.Add(op);



                                        /*****************retrait d'argent********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                c.setSolde(c.getSolde() - retrait);
                                            }
                                        }
                                        /*****************************************/



                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;



                                    /*********************virement******************************/

                                    case 2:
                                        Console.Write("a qui voulez vous transformer l'argent veuillez taper son code:  ");
                                        int virmer = int.Parse(Console.ReadLine());
                                        Console.Write("combien de solde voulez vous virmer:  ");
                                        int solde = int.Parse(Console.ReadLine());


                                        op = new metiers.Operations(cd, "Virement");
                                        ope.Add(op);

                                        /*****************virement d'argent********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == virmer)
                                            {
                                                c.setSolde(c.getSolde() + solde);
                                            }
                                        }


                                        /*******************apres chaque virement un retrait d'argent **********************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                c.setSolde(c.getSolde() - solde);
                                            }
                                        }

                                        /*************************************************/
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                Console.WriteLine("Votre solde maintenant est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;

                                    case 5:
                                        //soit les infos d'une entreprise soit d'un personne
                                        break;



                                    case 4:
                                        foreach (metiers.Compte c in co)
                                        {
                                            if (c.getnum() == cd)
                                            {
                                                Console.WriteLine("Votre solde est: = " + c.getSolde());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;



                                    case 6:
                                        Console.WriteLine("******************* LES OPERATIONS QUE VOUS AVEZ EFFECTUEES ******************* ");
                                        foreach (metiers.Operations o in ope)
                                        {
                                            if (o.getid() == cd)
                                            {
                                                Console.WriteLine(o.getTYPE() + "   le" + o.getdate());
                                            }
                                        }
                                        Console.WriteLine();
                                        break;
                                }


                            } while (choi != 7);
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Compte introuvable");
                        }
                    }
                    /***********************************************************************/
                  




                    break;
                default:
                    Console.WriteLine("choix erroné");
                    break;
            }
            Console.ReadLine();
        }
      
    }
}
