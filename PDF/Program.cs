using PDF;
using System;

namespace PDF
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instanciation d'un poule Ginger
            Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);

            // Affichage de cette poule
            ginger.Afficher();
        }
    }
}
