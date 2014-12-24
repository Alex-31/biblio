using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class Bibliotheque
    {
        public Media _genre { get; set; }

        Media listerBiblio();
        Media RechercherLivre(string titre, int id, string genre);
        Media RechercherCD(string titre, int id, string styleMusic);
        Media IncepterElement(int id);

    }
}
