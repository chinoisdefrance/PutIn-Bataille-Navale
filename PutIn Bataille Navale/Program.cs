using System;

namespace PutIn_Bataille_Navale
{
    class Program
    {


        static void Main(string[] args)
        {
            bool Satouche = false;

            int changement = 0;
            switch (changement)
            {
                case 0:
                    #region Putin
                    int choixBateauxPutin = 1;



                    for (int i = 0; i < 5; i++)
                    {


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
                case 1:
                    
                    int[,] grille = new int[10,10];





                    break;
                default:
                    break;
            }
        }
    }
}
