using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class Livre : Media
    {
        /// <Propriété>
        private List<string> _typeGenre = new List<string> { "Action", "Aventure", "ScienceFiction", "Fantastique", "Roman", "Policier", "Horreur", "Drame", "BD", "Poeme", "Historique", "Biographie", "Conte", "Fiction" };
        private List<string> _auteur = new List<string>();
        
        public string _nb_ISBN { get; set; }
        

        /// <Constructeur par defaut>
        Livre()
        {
            _auteur.Add("Inconnu");
            _nb_ISBN = "";
            _typeGenre.Add("Inconnu");
        }

        Livre(string unAuteur, string unGenre, string unNbISBN)
        {
            _auteur.Add(unAuteur);
            _typeGenre.Add(unGenre);
            _nb_ISBN = unNbISBN; // C'est juste un string à ne pas s'occuper par la suite et non un int
        }

    }
}
