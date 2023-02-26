using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire
{
    public class AnnuaireContext : DbContext // Provient de Entity Framework (mappeur objet-relationnel de .NET)
    {
        public AnnuaireContext(DbContextOptions options) // options : configuration de la BD
            : base(options) // Héritage de constructeur
        {
            // Héritage de constructeur en Java : super(options);
        }

        // Déclaration des tables.

        public DbSet<Contact> Contacts => Set<Contact>();

        // Equivaut à :
        //
        // public DbSet<Contact> Contacts
        // {
        //     get
        //     {
        //         return Set<Contact>(); // Méthode héritée de DbContext.
        //     }
        // }
    }
}
