
ConsoleObservable o = new ConsoleObservable();

// Abonnement de l'observateur à l'objet observable.

// o.Observateurs.Add(Majuscules);

// Ou bien :
o.Abonne(texte => // En C#, on appelle cela une expression lambda
                            // En général, une fonction en ligne (inline)
{
    Console.WriteLine(texte.ToUpper());
});

o.Abonne(SansEspaces(texte =>
{
    Console.WriteLine(texte.ToUpper());
}));

o.Demarre();

static void Majuscules(string texte)
{
    Console.WriteLine(texte.ToUpper());
}

// Un peu de programmation fonctionnelle : des fonctions qui créent d'autres fonctions
static ConsoleObservateur SansEspaces(ConsoleObservateur observateur)
{
    return texte =>
    {
        observateur(texte.Replace(" ", ""));
    };
}

#region ConsoleObservable / IConsoleObservateur

class ConsoleObservable
{
    private ConsoleObservateur? _observateur;

    public void Abonne(ConsoleObservateur o)
    {
        // Combine deux fonctions : la fonction résultante appelle successivement ses deux composantes. 

        _observateur = _observateur + o;
    }

    public void Demarre()
    {
        for (;;) // while (true)
        {
            string? texte = Console.ReadLine();
            if (texte != null)
            {
                if (_observateur != null) _observateur(texte);
            }
        }
    }
}

// Délégué = pointeur de fonction
// ConsoleObservateur représente une méthode void(string)
delegate void ConsoleObservateur(string texte);

#endregion