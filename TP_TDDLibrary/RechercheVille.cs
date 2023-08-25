using System.Runtime.Serialization;

namespace TP_TDDLibrary
{
    public class RechercheVille
    {
        private List<String> villes;

        public List<String> Rechercher(String mot)
        {
            if (mot.Length < 2) throw new NotFoundException();
            else throw new NotImplementedException();
        }

    }

    public class NotFoundException : Exception
    {

    }
}