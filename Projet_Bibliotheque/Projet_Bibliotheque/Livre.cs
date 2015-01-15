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
        private string _typeGenre ;
        private string _auteur;
        
        public string _nb_ISBN { get; set; }
        

        /// <Constructeur par defaut>
        Livre()
        {
            _auteur = "Inconnu";
            _nb_ISBN = "";
            _typeGenre = "Inconnu";
        }

        Livre(string unAuteur, string unGenre, string unNbISBN)
        {
            _auteur = unAuteur;
            _typeGenre = unGenre;
            _nb_ISBN = unNbISBN; // C'est juste un string à ne pas s'occuper par la suite et non un int
        }

    }
}
