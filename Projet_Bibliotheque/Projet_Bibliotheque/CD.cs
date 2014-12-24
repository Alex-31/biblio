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
        protected List<string> _artiste = new List<string>();
        protected List<string> _styleMusic = new List<string> { "Rock", "Classique", "Blues", "Pop", "Jazz", "Variété", "Folk", "Reggae", "PopRock", "Electro", "Techno", "Rap", "Country", "Soul", "MusicFilm", "Enfant" };

        /// <Construteur par defaut>
        CD()
        {
            _artiste.Add("Inconnu");
            _styleMusic.Add("Inconnu");
        }

        CD(string artiste, string styleMusic)
        {
            _artiste.Add(artiste);
            _styleMusic.Add(styleMusic);
        }

    }
}
