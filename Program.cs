using System;

namespace FindNumber
{
    class Program
    {
         private static void Main(string[] args)
        {

             int coup = 0;
             Run(coup);
        }
        static void Run(int coup)
        {
            
            Console.WriteLine("Le jeu commence ! choisie une nombre");
            int val = new Random().Next(0, 100);
            EntryUser(val, coup);
        }
        static void EntryUser(int val,int coup)
        {
            string saisi = Console.ReadLine();
            int nbuser;
            if (int.TryParse(saisi, out nbuser))
            {
                if (nbuser > 100)
                {
                    Console.WriteLine("Le nombre entré ne doit pas depasser 100");
                    EntryUser(val, coup);
                }
                else if (nbuser < 0)
                {
                    Console.WriteLine("Le nombre entré ne doit pas plus bas que 0");
                    EntryUser(val, coup);
                }
                Verif(nbuser, val, coup);
            }
            else
            {
                Console.WriteLine("La conversion est impossible");
                EntryUser(val, coup);
            }
        }

        static void Verif(int nbuser, int val,int coup)
        {
            if (val == nbuser)
            {
                coup++;
                Console.WriteLine("Vous avez trouvé en "+ coup+ " coups ! \nVoulez vous rejouer ? (O/N)");
                string choix = Console.ReadLine();

                if (choix == "O" || choix == "Y" || choix == "y" || choix == "o")
                {
                    Console.WriteLine("------------------------");
                    coup = 0;
                    Run(coup);
                }
                else if (choix == "N" || choix == "n")
                {
                    Environment.Exit(0);
                }

            }
            else
            {
                if (nbuser > val)
                {
                    Console.WriteLine("Trop grand");
                    coup++;
                    EntryUser(val, coup);
                }
                else if (nbuser < val)
                {
                    coup++;
                    Console.WriteLine("Trop petit");
                    EntryUser(val, coup);
                }
            }
        }
    }
}
