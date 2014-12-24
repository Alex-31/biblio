using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bibliotheque
{
    class Media
    {
        /// <Propriété>
        public int _identifiant { get; set; }
        public int _nbStock { get; set; }
        public string _titre { get; set; }
        /// <Méthode>
        public void AjoutLivre(string titre);
        public void AjoutCD(string titre);


        /// <Function>
        
        bool Emprunt(int identifiant)
        {

            return true;  // pour l'instant vide juste pour que sa compile
        }

        bool Supprimmer(int identifiant)
        {

            return true; // pour l'instant vide juste pour que sa compile
        }
    }
}
