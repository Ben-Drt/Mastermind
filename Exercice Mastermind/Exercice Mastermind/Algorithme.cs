using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);

        }
        // cette fonction permet ? l'ordinateur de choissier une combinaison de 4 chiffres //
        static void ChoixCombi(out int[] combi){
            combi = new int[4];
            for(int i= 0;i <= 3; i++) {
                Random rnd = new Random();
                //int Valeur = rnd.Next(1, 7);
                combi[i] = rnd.Next(1, 7);
            
            }

        }

        static void Afficher(int[] combi) {
            for(int i = 0; i <=3; i++) {
                Console.Write(Combi[i]);
            }
        }
    }

}