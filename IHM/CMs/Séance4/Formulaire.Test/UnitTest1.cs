namespace Formulaire.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Picasso", "Pablo")]
        [DataRow("De Vinci", "L�onard")]
        public void ValiderTest(string nom, string prenom)
        {
            TestView view = new TestView();
            ContactViewModel c = new ContactViewModel(view);

            // Simule l'�dition du formulaire :
            c.Nom = nom;
            c.Prenom = prenom;

            // Simule la validation du formulaire :
            c.Valider();

            // Propri�t� v�rifi�e par le test
            Assert.AreEqual(view.Message, $"Bonjour {prenom} {nom}");
        }
    }

    class TestView : IView
    {
        private string _message;

        public string Message
        {
            get { return _message; }
        }

        public void Affiche(ContactViewModel c)
        {

        }

        public void Popup(string message)
        {
            _message = message;
        }
    }
}