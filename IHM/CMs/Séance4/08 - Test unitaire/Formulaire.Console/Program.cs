using Formulaire;

ConsoleView view = new ConsoleView();
ContactViewModel c = new ContactViewModel(view);

// Simule l'édition du formulaire :
c.Nom = "Picasso";
c.Prenom = "Pablo";

// Simule la validation du formulaire :
c.Valider();
if (view.Message == "Bonjour Pablo Picasso")
{
    Console.WriteLine("Popup OK");
}

c.NouvelleVue();

Console.ReadKey();


class ConsoleView : IView
{
    private string _message;

    public string Message
    {
        get { return _message; }
    }

    public void Affiche(ContactViewModel c)
    {
        Console.WriteLine("Nouvelle fenêtre");
    }

    public void Popup(string message)
    {
        _message = message;
        Console.WriteLine(message);
    }
}