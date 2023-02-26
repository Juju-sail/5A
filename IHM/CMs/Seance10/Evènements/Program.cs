
ConsoleObservable o = new ConsoleObservable(new SansEspacesObservateur(new MajusculesObservateur()));
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
    private readonly IConsoleObservateur _observateur;

    public ConsoleObservable(IConsoleObservateur observateur)
    {
        _observateur = observateur;
    }

    public void Demarre()
    {
        for (;;) // while (true)
        {
            string? texte = Console.ReadLine();
            if (texte != null)
            {
                _observateur.NouvelleLigne(texte);
            }
        }
    }
}

interface IConsoleObservateur
{
    void NouvelleLigne(string texte);
}

#endregion