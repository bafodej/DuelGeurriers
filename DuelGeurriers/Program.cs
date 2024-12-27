using DuelGeurriers;
using static DuelGeurriers.Guerrier;




Console.WriteLine("-----------------------------");
Console.WriteLine("--  Bienvenue dans l'arène --");
Console.WriteLine("--  des guerriers          --");   // Affichage d'acceuil
Console.WriteLine("-----------------------------");

MenuChoix1();


static void MenuChoix1() {



 Console.WriteLine("//////////////////////////////");
 Console.WriteLine("/// Choix du 1er combatant ///");               // affichage choix du 1er combatant
 Console.WriteLine("//////////////////////////////");
 
 Console.WriteLine("-Entrez (1) pour choisir lancelot le combatant de type Guerrier");
 Console.WriteLine("-Entrez (2) pour choisir Legolas le combatant de type Elfe");
 Console.WriteLine("-Entrez (3) pour choisir Gimli   le combatant de type Nain");

   

      static void duel(  )                           // fonction duel 
    {
        Guerrier perso1 = new Guerrier("", 1, 0);
        Guerrier perso2 = new Guerrier("", 1, 0);
        Random deLancer = new Random();
        int premierAttaquant = deLancer.Next(1, 20);
        do
        {
            if (premierAttaquant > 10)
            {
                perso1.AfficherInfos();
                perso2.AfficherInfos();

                perso1.Attaquer();
                perso2.SubirDegat();

                perso2.Attaquer();
                perso1.SubirDegat();
            }
            else if (premierAttaquant < 10)
            {
                perso2.AfficherInfos();
                perso1.AfficherInfos();

                perso2.Attaquer();
                perso1.SubirDegat();

                perso1.Attaquer();
                perso2.SubirDegat();

            }
        } while (perso2.PointDeVie != 0 || perso1.PointDeVie != 0);


        /*Guerrier guerrier1 = new Guerrier("", 0, 0);*/
        int choix1 = int.Parse(Console.ReadLine());                                               // création du 1 er guerrier 
        switch (choix1)
        {
            case 1:
                Guerrier Guerrrier_1 = new Guerrier("", 1, 0);
                if (choix1 == 1)
                {
                    Console.WriteLine("Entrez le nom de votre guerrier");
                    perso1.Nom = Console.ReadLine();
                    Console.WriteLine("Entrez le nombre de point de vie de votre guerrier");
                    perso1.PointDeVie = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entrez le nombre d'attaques de votre guerrier");
                    perso1.PointDeVie = int.Parse(Console.ReadLine());


                }
                break;
            case 2:
                Nain Nain_2 = new Nain("", 1, 0, true);
                if (choix1 == 2)
                {
                    Console.WriteLine("Entrez le nom de  votre nain");
                    perso1.Nom = Console.ReadLine();
                    Console.WriteLine("Entrez le nombre de point de vie de  votre nain");
                    perso1.PointDeVie = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entrez le nombre d'attaques de  votre nain");
                    perso1.PointDeVie = int.Parse(Console.ReadLine());

                }
                break;
            case 3:
                Elfe Elfe_2 = new Elfe("", 1, 1);
                if (choix1 == 3)
                {
                    Console.WriteLine("Entrez le nom  de votre elfe");
                    perso1.Nom = Console.ReadLine();
                    Console.WriteLine("Entrez le nombre de point de vie  de votre elf");
                    perso1.PointDeVie = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entrez le nombre d'attaques  de votre elfe");
                    perso1.PointDeVie = int.Parse(Console.ReadLine());


                }
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                break;
        }
        Console.Clear();


        static void MenuChoix2()
        {



            Console.WriteLine("///////////////////////////////");
            Console.WriteLine("// Choix du second combatant //");
            Console.WriteLine("///////////////////////////////");

            Console.WriteLine("-Entrez (1) pour choisir lancelot le combatant de type Guerrier");
            Console.WriteLine("-Entrez (2) pour choisir Legolas le combatant de type Elfe");
            Console.WriteLine("-Entrez (3) pour choisir Gimli   le combatant de type Nain");


            Guerrier perso2 = new Guerrier("", 0, 0);
            int choix2 = int.Parse(Console.ReadLine());                                                // Création du 2nd guérrier 
            switch (choix2)
            {
                case 1:
                    Guerrier Guerrrier_1 = new Guerrier("", 1, 0);
                    if (choix2 == 1)
                    {
                        Console.WriteLine("Entrez le nom de votre guerrier");
                        perso2.Nom = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de point de vie de votre guerrier");
                        perso2.PointDeVie = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entrez le nombre d'attaques de votre guerrier");
                        perso2.PointDeVie = int.Parse(Console.ReadLine());


                    }
                    break;
                case 2:
                    Nain Nain_2 = new Nain("", 1, 0, true);
                    if (choix2 == 2)
                    {
                        Console.WriteLine("Entrez le nom de  votre nain");
                        perso2.Nom = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de point de vie de  votre nain");
                        perso2.PointDeVie = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entrez le nombre d'attaques de  votre nain");
                        perso2.PointDeVie = int.Parse(Console.ReadLine());

                    }
                    break;
                case 3:
                    Elfe Elfe_2 = new Elfe("", 1, 1);
                    if (choix2 == 3)
                    {
                        Console.WriteLine("Entrez le nom  de votre elfe");
                        perso2.Nom = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de point de vie  de votre elf");
                        perso2.PointDeVie = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entrez le nombre d'attaques  de votre elfe");
                        perso2.PointDeVie = int.Parse(Console.ReadLine());


                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            Console.Clear();

        }
        MenuChoix2();

        Console.Clear();
    }
    

    












/*Guerrier lancelot = new Guerrier("Lancelot", 35, 3);

Guerrier galahad = new Guerrier("Galahad", 30, 4);

Nain gimli = new Nain("Gimli", 40, 2, true);

Elfe legolas = new Elfe("Legolas", 25, 5);*/



/*
legolas.SubirDegat();
lancelot.SubirDegat();
gimli.SubirDegat();*/


