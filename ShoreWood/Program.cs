using System;
using System.Collections.Generic;

namespace HeroesVsMonster
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance //
            
            
            DeAleatoire de = new DeAleatoire();

            BigText.Titre(); // titre du jeu en gros
            Console.WriteLine("Bonjour voulez vous demarrer un combat contre les monstre?"); 
            Console.WriteLine("Tappez - Oui / Non");
            string play;
            play = Console.ReadLine().ToUpper();
            
            while (play != "OUI" && play != "NON")
            {
                Console.WriteLine("Veuilez tappez - 'Oui' ou 'Non'");
                play = Console.ReadLine().ToUpper();
            }

            while (play == "OUI")
            {
                Console.WriteLine("Pour faire une partie appuyer sur une touche ");
                Console.ReadKey();
                // choix de l'hero
                Console.WriteLine("Choisir un hero: \n0; Humain \n1; Nain");
                int Choix;
                while (!int.TryParse(Console.ReadLine(), out Choix))
                {
                    Console.WriteLine("Erreur!! Veuillez choisir un hero en entrant un chiffre (0 ou 1)");
                    Console.WriteLine("Choisir un hero: \n0; Humain \n1; Nain");
                }
                Console.WriteLine();
                Humain h = new Humain();
                Nain n = new Nain();
                Heroes[] choixHero = new Heroes[2];
                choixHero[0] = h;
                choixHero[1] = n;

                Monsters[] personages = new Monsters[de.DeAle20()];
                //liste des monstres
                List<string> monsList = MonsterGenerate.GenerateMonster(personages);
                Console.WriteLine("Voici les monstres que vous devez affronter");
                //affichage de la liste des monstres
                foreach (string item in monsList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n=====================================START=============================================");
                
                Caracteristique.CrstqHero(choixHero[Choix]); //affichage des caracteristique de l'hero
                Caracteristique.CrstqMonstre(personages); //affichage des caracteristique des monstres
                Console.Clear();
                // affichage du combat currant
                for (int i = 0; i < personages.Length; i++)
                {
                    Console.WriteLine("Combat " + (i + 1));
                    Console.WriteLine("---------------");
                    Console.WriteLine("Heros: " + choixHero[Choix].GetType().Name); 
                    Console.WriteLine("Monstre: " + personages[i].GetType().Name);  
                    Console.WriteLine($"\n{choixHero[Choix].GetType().Name} - Endurance: {choixHero[Choix].End} Force: {choixHero[Choix].For} Points de vie: {choixHero[Choix].Pv} ");
                    Console.WriteLine($"{personages[i].GetType().Name} - Endurance: {personages[i].End} Force: {personages[i].For} Points de vie: {personages[i].Pv} ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("appuyer sur une touche pour continuer!!");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("---------------------------Le combat commence-----------------------------------");
                    while (!personages[i].Mort() && !choixHero[Choix].Mort())
                    { // combat courrant 
                        Console.WriteLine("appuyer sur une touche pour frapper!!");
                        Console.ReadKey();
                        choixHero[Choix].Frappe(personages[i]); // hero frappe monstre
                        Console.WriteLine(choixHero[Choix].GetType().Name + " a frapper " + personages[i].GetType().Name);
                        personages[i].Frappe(choixHero[Choix]); // monstre frappe hero
                        Console.WriteLine(personages[i].GetType().Name + " a frapper " + choixHero[Choix].GetType().Name);
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        // affichage des caracteristique avec pv reduit a chaque coup
                        Console.WriteLine($"{choixHero[Choix].GetType().Name} - Endurance: {choixHero[Choix].End} Force: {choixHero[Choix].For} Points de vie: {choixHero[Choix].Pv} "); 
                        Console.WriteLine($"{personages[i].GetType().Name} - Endurance: {personages[i].End} Force: {personages[i].For} Points de vie: {personages[i].Pv}");
                        Console.WriteLine("===========");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    if (!choixHero[Choix].Mort())
                    {
                        choixHero[Choix].Pv = choixHero[Choix].PvMax;
                        // cast // hero vole si le monstre est tué
                        choixHero[Choix].Voler(personages[i]);
                        Console.WriteLine("L'hero as eliminer le monstre");
                        if (i < personages.Length)
                        {
                            Console.WriteLine("Appuyer sur une touche pour affronter le prochain monstre");
                        }
                        
                    }
                    else if (choixHero[Choix].Mort())
                    {

                        i = personages.Length;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                int TotMort = 0;
                // compter les nombre de monstres tué
                for (int i = 0; i < personages.Length; i++)
                {
                    if (personages[i].Pv <= 0)
                    {
                        TotMort += 1;
                    }
                }
                //resultat des combat 
                if (TotMort == personages.Length)
                {
                    Console.WriteLine("Felicitations, votre hero a tué tous les monstres. Voilà le resultat des monstres vaincus et la richesse accumulee:");
                }
                else if (choixHero[Choix].Mort())
                {
                    Console.WriteLine("Votre hero est mort!!\n\nVoici les resultats:");
                }
                Console.WriteLine($"\nVous avez tué {TotMort} monstre!  ");
                if (TotMort > 0)
                {
                    Console.WriteLine("\nLes monstres morts sont les suivants:");
                }
                for (int i = 0; i < personages.Length; i++)
                {
                    if (personages[i].Pv <= 0)
                    {
                        Console.WriteLine("- " + personages[i].GetType().Name);
                    }
                }
                // point reçu en forme de cuir et or
                Console.WriteLine("  \nVous avez récuperé: ");
                foreach (var item in choixHero[Choix].Sac)
                {
                    Console.WriteLine($"  {item.Key} : {item.Value}");
                }
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();

                if (TotMort == personages.Length)
                {
                    BigText.Winner(); // text grand en cas de gagne
                }
                else if (TotMort < personages.Length)
                {
                    BigText.GameOver(); // text grand en cas de perte 
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Si vous souhaitez refaire un combat tapper 'Oui', sinon tapper autre chose que 'oui'");
                play = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            Console.WriteLine("============================ Combat terminé =================================");
        }
    }
}