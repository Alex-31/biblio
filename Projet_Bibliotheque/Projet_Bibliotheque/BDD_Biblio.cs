namespace Projet_Bibliotheque
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BDD_Biblio : DbContext
    {
        public BDD_Biblio()
            : base("name=BDD_Biblio")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
