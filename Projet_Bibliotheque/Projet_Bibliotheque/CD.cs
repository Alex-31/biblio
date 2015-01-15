using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class CD: Media
    {
        /// <Propriété>
        protected string _artiste;
        protected string _styleMusic ;

        /// <Construteur par defaut>
        CD()
        {
            _artiste = "Inconnu";
            _styleMusic = "Inconnu";
        }

        CD(string artiste, string styleMusic)
        {
            _artiste = artiste;
            _styleMusic = styleMusic;
        }

    }
}
