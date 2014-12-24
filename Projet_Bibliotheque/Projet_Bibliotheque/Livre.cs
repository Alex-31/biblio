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
        public int _nb_ISBN { get; set; }
        

        /// <Constructeur par defaut>
        Livre()
        {
            _auteur.Add("Inconnu");
            _nb_ISBN = 0;
            _typeGenre.Add("Inconnu");
        }

        Livre(string auteur, string genre)
        {
            _auteur.Add(auteur);
            _typeGenre.Add(genre);
            _nb_ISBN = _nb_ISBN + 1;
        }

    }
}
