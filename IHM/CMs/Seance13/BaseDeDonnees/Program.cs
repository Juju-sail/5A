
// Tutoriel Entity Framework
// https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli

// Package NuGet : Microsoft.EntityFrameworkCore.SqlServer
// https://learn.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

#region Programme principal (méthode Main)

// Configure une connexion à la BD SQL Server de développement
DbContextOptions options = new DbContextOptionsBuilder()
    .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                    Integrated Security=True;
                    Database=Annuaire")
    .Options;

AnnuaireContext bd = new AnnuaireContext(options);
bd.Database.EnsureCreated(); // Crée la BD si inexistante.

Contact vg = new Contact();
vg.Nom = "Van";
vg.Prenom = "Gogh";

bd.Contacts.Add(vg);

bd.SaveChanges();

// Affiche la requête SQL de sélection.
IQueryable<Contact> requete = bd.Contacts;
Console.WriteLine(requete.ToQueryString());

foreach (Contact c in requete)
{
    Console.WriteLine($"{c.Id,5} {c.Nom,-30} {c.Prenom}");
}

#endregion

#region Types (classes, interfaces...)

class AnnuaireContext : DbContext // Provient de Entity Framework (mappeur objet-relationnel de .NET)
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

class Contact
{
    // En C#, on appelle cette syntaxe [..] un 'attribut'
    // En Java, on a l'équivalent avec les 'annotations' @..

    [Key] // Dénote la clé primaire
    public int Id { get; set; }

    public string Nom { get; set; } = "";

    // Equivaut à :
    //
    // private string _nom = "";
    // 
    // public string Nom
    // {
    //     get { return _nom; }
    //     set { _nom = null; }
    // }

    public string Prenom { get; set; } = "";
}

#endregion