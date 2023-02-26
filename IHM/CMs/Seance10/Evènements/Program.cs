
ConsoleObservable o = new ConsoleObservable();

// Abonnement de l'observateur à l'objet observable.
o.Observateur += Majuscules;
// Désabonnement
o.Observateur -= Majuscules;

// Ou bien :
o.Observateur += texte => // En C#, on appelle cela une expression lambda
                            // En général, une fonction en ligne (inline)
{
    Console.WriteLine(texte.ToUpper());
};

o.Observateur += SansEspaces(texte =>
{
    Console.WriteLine(texte.ToUpper());
});

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
    // Le mot-clé event permet la combinaison de fonction à l'aide de += et -=
    public event ConsoleObservateur? Observateur;

    public void Demarre()
    {
        for (;;) // while (true)
        {
            string? texte = Console.ReadLine();
            if (texte != null)
            {
                if (Observateur != null) Observateur(texte);
            }
        }
    }
}

// Délégué = pointeur de fonction
// ConsoleObservateur représente une méthode void(string)
delegate void ConsoleObservateur(string texte);

#endregion