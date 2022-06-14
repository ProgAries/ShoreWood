using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Caracteristique
    {
        public static void CrstqHero(Heroes hero)
        {
            Console.WriteLine();
            Console.WriteLine("===================Voici les caracteristiques de votre hero======================");
            Console.WriteLine($"\n{hero.GetType().Name} - Endurance: {hero.End} Force: {hero.For} Points de vie: {hero.Pv} ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("\nAppuyer sur une touche pour continuer");
            Console.ReadKey();
        }

        public static void CrstqMonstre(Monsters[] personages)
        {
            Console.WriteLine("\n================Voici les caracteristiques des monstres à affronter======================");
            for (int i = 0; i < personages.Length; i++)
            {
                Console.WriteLine($"\n{personages[i].GetType().Name} - Endurance: {personages[i].End} Force: {personages[i].For} Points de vie: {personages[i].Pv},\n < il possede {personages[i].Cuir} cuir et {personages[i].Or} or >");
            }
            Console.WriteLine("\nAppuyer sur une touche pour continuer");
            Console.ReadKey();
        }
    }
}
