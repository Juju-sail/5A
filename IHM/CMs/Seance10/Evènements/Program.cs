
ConsoleObservable o = new ConsoleObservable();

// Abonnement de l'obervateur à l'objet observable.
o.Observateurs.Add(new MajusculesObservateur());
o.Observateurs.Add(new SansEspacesObservateur(new MajusculesObservateur()));

o.Demarre();

class MajusculesObservateur : IConsoleObservateur
{
    public void NouvelleLigne(string texte)
    {
        Console.WriteLine(texte.ToUpper());
    }
}

class SansEspacesObservateur : IConsoleObservateur
{
    private readonly IConsoleObservateur _observateur;

    public SansEspacesObservateur(IConsoleObservateur observateur)
    {
        _observateur = observateur;
    }

    public void NouvelleLigne(string texte)
    {
        _observateur.NouvelleLigne(texte.Replace(" ", ""));
    }
}


#region ConsoleObservable / IConsoleObservateur

class ConsoleObservable
{
    private readonly List<IConsoleObservateur> _observateurs;

    public ConsoleObservable()
    {
        _observateurs = new List<IConsoleObservateur>();
    }

    public List<IConsoleObservateur> Observateurs
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
                foreach (IConsoleObservateur o in _observateurs)
                {
                    o.NouvelleLigne(texte);
                }
            }
        }
    }
}

interface IConsoleObservateur
{
    void NouvelleLigne(string texte);
}

#endregion