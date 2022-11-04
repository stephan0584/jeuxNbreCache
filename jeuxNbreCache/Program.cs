/**
 * jeux du nombre caché
 * auteur:
 * date:
 */
 using System;

namespace jeuxNbreCache
{
    class Program
    {
        //ajout d'un commentaire
        static void Main(string[] args)
        {
            int valeur=0,essai=0,nbre=1;
            bool correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("entrez un nombre:   ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                    
                }
                catch
                {
                    Console.WriteLine("erreur de saisie, recommencez");
                }
                
            }
            Console.Clear();
            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai:    ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("erreur de saisie, recommencez");
                }
            }
            while (essai != valeur)
            {
               if (essai > valeur)
                {
                    Console.WriteLine("Trop grand");
                }
                else
                {
                    Console.WriteLine("Trop petit");
                }
                correct = false;
                while (!correct)
                {
                    try
                    {

                        Console.Write("Entrez un essai:    ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                        nbre++;
                    }
                    catch
                    {
                        Console.WriteLine("erreur de saisie, recommencez");
                    }
                }
            }
            Console.WriteLine("Vous avez trouvé la valeur en "+nbre+"  fois");
            Console.ReadLine();

        }
    }
}
