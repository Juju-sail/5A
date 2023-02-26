
ConsoleObservable o = new ConsoleObservable();

// Abonnement de l'observateur à l'objet observable.

// o.Observateurs.Add(Majuscules);

// Ou bien :
o.Observateurs.Add(texte => // En C#, on appelle cela une expression lambda
                            // En général, une fonction en ligne (inline)
{
    Console.WriteLine(texte.ToUpper());
});

o.Observateurs.Add(SansEspaces(texte =>
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
    private readonly List<ConsoleObservateur> _observateurs;

    public ConsoleObservable()
    {
        _observateurs = new List<ConsoleObservateur>();
    }

    public List<ConsoleObservateur> Observateurs
    {
        get { return _observateurs; }
    }

    public void Demarre()
    {
        for (;;) // while (true)
        {
            string? texte = Console.ReadLine();
            if (texte != null)
            {
                foreach (ConsoleObservateur o in _observateurs)
                {
                    o(texte);
                }
            }
        }
    }
}

// Délégué = pointeur de fonction
// ConsoleObservateur représente une méthode void(string)
delegate void ConsoleObservateur(string texte);

#endregion