using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Formulaire
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AnnuaireContext _bd;

        public App()
        {
            // Configure une connexion à la BD SQL Server de développement
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                    Integrated Security=True;
                    Database=Annuaire")
                .Options;

            _bd = new AnnuaireContext(options);
            _bd.Database.EnsureCreated(); // Crée la BD si inexistante.
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // En XAML on avait l'attribut : StartupUri="MainWindow.xaml"
            // Equivalent C# :
            //
            // MainWindow win = new MainWindow();
            // win.Show();

            MainWindow win = new MainWindow();
            win.DataContext = new MainViewModel(_bd); // Définit l'objet partagé avec XAML
            win.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _bd.SaveChanges();

            base.OnExit(e);
        }
    }
}
