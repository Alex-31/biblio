using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class media
    {
        /// <Propriété>
        public int Identifiant { get; set; }
        public int NbStock { get; set; }
        public string Titre { get; set; }
        /// <Méthode>
        public void AjoutLivre(string titre);
        public void AjoutCD(string titre);
    }
}
