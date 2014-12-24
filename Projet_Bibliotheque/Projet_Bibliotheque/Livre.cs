using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class Livre
    {
       private List<string> TypeGenre = new List<string> { "Action", "Aventure", "ScienceFiction", "Fantastique", "Roman", "Policier", "Horreur", "Drame", "BD", "Poeme", "Historique", "Biographie", "Conte" };
    
        protected String Auteur { get; set; }
        protected int Nb_ISBN { get; set; }
        
        Livre()
        {
            Auteur = "Inconnu";
            Nb_ISBN = 0;
            TypeGenre.Add("Inconnu");
        }

    }
}
