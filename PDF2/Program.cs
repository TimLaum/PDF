using System;
using PDF;
namespace PDF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
            Poulailler poula = new Poulailler("poula",ginger,12);
            Poule caramel = new Poule("Caramel", "gauloise",1.2,Taille.M);
            poula.AjouterPoule(caramel);
            poula.SupprimerPoule(2);
            poula.AfficherPoules();
            poula.AfficherPoulailler();
            poula.CalculTauxPonte(7);
        }
    }
}
