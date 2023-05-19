using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDF;

namespace PDF2
{
    class Poulailler
    {
        public string nomPoulailler;
        public List<Poule> lesPoules = new List<Poule>() ;
        public int nbPoule;
        public int capaMax;

        public Poulailler(string nPoulailler,Poule poules,int capacite)
        {
            nomPoulailler = nPoulailler;
            lesPoules.Add(poules);
            capaMax = capacite;
            nbPoule = 1;
        }

        public void AfficherPoulailler()
        {
            Console.WriteLine($"Nom de poulailler : {nomPoulailler} | capacité : {capaMax} | nombre de poules : {nbPoule}");
            AfficherPoules();
        }
        public void AfficherPoules()
        {
            int count = 0;
            foreach(Poule poulet in lesPoules) {
                count += 1;
                
                Console.Write($"{count}) ");
                poulet.Afficher();
            }
                Console.WriteLine();
        }


        public void AjouterPoule(Poule poulet)
        {
            
            lesPoules.Add(poulet);
            nbPoule += 1;

        }

        public void SupprimerPoule(int ligne)
        {
            AfficherPoules();
            int count = 0;
            foreach(Poule poulet in lesPoules.ToList())
            {
                count += 1;
                if(count == ligne)
                {
                    lesPoules.Remove(poulet);
                }
            }
        }
        public void CalculTauxPonte(int Ponte)
        {
            int n = nbPoule;
            int result = (Ponte / n)*100;
            Console.WriteLine($"Ce poulailler a un taux de ponte de {result}%");
        }
    }
}
