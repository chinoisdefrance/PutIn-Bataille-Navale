using System;

namespace PutIn_Bataille_Navale
{
    class Program
    {


        static void Main(string[] args)
        {
            
            int changement = 1;
            //permet de changer l'état du jeu
            switch (changement)
            {
                //initialisation des joueurs -> choix bateaux pour chaque joueur
                case 0:
                    #region Putin
                    int choixBateauxPutin = 1;
                                       
                    for (int i = 0; i < 5; i++)
                    {

                        //tant que le joueur n'a pas choisi les 5 navires proposés, alors la demande s'effectue en boucle
                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Player 1 : PUTIN. Veuillez choisir parmis les navires suivant : 1.Mother Russia  2.Vodka 3.Rasputin  4.Tank  5.Ours ");



                            string reponsesPUTIN = Console.ReadLine();

                            int.TryParse(reponsesPUTIN, out choixBateauxPutin);

                            switch (choixBateauxPutin)
                            {
                                case 1:
                                    Console.WriteLine("Mother Russia");
                                    break;
                                case 2:
                                    Console.WriteLine("Vodka");
                                    break;
                                case 3:
                                    Console.WriteLine("Rasputin");
                                    break;
                                case 4:
                                    Console.WriteLine("Tank");
                                    break;
                                case 5:
                                    Console.WriteLine("Ours");
                                    break;
                                default:
                                    Console.WriteLine("Veuillez choisir un navire proposé svp");
                                    break;
                            }
                        }
                        while (choixBateauxPutin <= 0 || choixBateauxPutin > 5);
                    }
                    Console.WriteLine($"Vous avez choisi les bateaux : {choixBateauxPutin} pour PUTIN");

                    #endregion
                    #region TRUMP 
                    //idem
                    int choixBateauxTRUMP = 1;



                    for (int i = 0; i < 5; i++)
                    {


                        do
                        {

                            Console.Clear();
                            Console.WriteLine("Player 2 : TRUMP. Veuillez choisir parmis les navires suivant : 1.USA  2.Le de Gaulle mais moins bien    3.Obésité  4.USS autoBronzant  5.Implants Capillaires ");



                            string reponsesTRUMP = Console.ReadLine();

                            int.TryParse(reponsesTRUMP, out choixBateauxTRUMP);

                            switch (choixBateauxTRUMP)
                            {
                                case 1:
                                    Console.WriteLine("USA");
                                    break;
                                case 2:
                                    Console.WriteLine("Briques");
                                    break;
                                case 3:
                                    Console.WriteLine("Obésité");
                                    break;
                                case 4:
                                    Console.WriteLine("Diabète");
                                    break;
                                case 5:
                                    Console.WriteLine("Implants Capillaires");
                                    break;
                                default:
                                    Console.WriteLine("Veuillez choisir un navire proposé svp");
                                    break;
                            }
                        }
                        while (choixBateauxTRUMP <= 0 || choixBateauxTRUMP > 5);
                    }
                    Console.WriteLine($"Vous avez choisi les bateaux : {choixBateauxTRUMP} pour TRUMP");

                    #endregion


                    break;

                 //où on tire
                case 1:

                    //liste des joueurs
                    Joueur[] listeJoueurs = new Joueur[2];
                    listeJoueurs[0] = new Joueur("Putin");
                    listeJoueurs[1] = new Joueur("Trump");

                    for (int i = 0; i < 2; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("Player " + (i + 1) + " : " + listeJoueurs[i].nom);
                        //affichage tableau
                        for (int j = 0; j < 10; j++)
                        {
                            for (int k = 0; k < 10; k++)
                            {

                                Console.Write(listeJoueurs[i].tir[j, k]);


                            }
                            Console.WriteLine();
                        }

                        //demande des positions verticales et horizontales des deux joueurs
                        int posHori;
                        int posVerti;

                        Console.WriteLine("Veuillez insérer une position horizontale : ");

                        string position = Console.ReadLine();
                        int.TryParse(position, out posHori);

                        Console.WriteLine("Veuillez insérer une position verticale : ");

                        string position2 = Console.ReadLine();
                        int.TryParse(position2, out posVerti);
                        Console.WriteLine(listeJoueurs[i].tir[posHori - 1, posVerti - 1]);
                        //si touché ou pas
                        if (listeJoueurs[i].tir[posHori - 1, posVerti - 1] == 0)
                        {
                            Console.WriteLine("RATÉ PAUVRE CON DE COMMUNISTE/CAPITALISTE !!!");
                        }
                        else
                        {
                            Console.WriteLine("TOUCHÉ, SALAUD !!!");
                        }

                        Console.ReadKey();
                                               
                    }


                    break;
                default:
                    break;
            }
        }
    }
    //classe joueur permet d'initialiser les différentes grilles et la liste des joueurs
    class Joueur
    {
        public Joueur(string n)
        {

            Random rnd = new Random();

            nom = n;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tir[i, j] = rnd.Next(0, 2);
                }
            }
        }

        public string nom;

        public int[,] placement = new int[10, 10];

        public int[,] tir = new int[10, 10];


    }
}
