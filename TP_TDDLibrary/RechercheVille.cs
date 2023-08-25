using System.Runtime.Serialization;

namespace TP_TDDLibrary
{
    public class RechercheVille
    {
        private List<String> villes = new List<String>(new String[] { "Valenciennes", "Vancouver", "Budapest", "Madrid", "Paris", "Tokyo" });

        public List<String> Rechercher(String mot)
        {
            if (mot.Equals("*")) return villes;
            if (mot.Length < 2) throw new NotFoundException();
            return villes.FindAll(s =>
            {
                s = s.ToLower();
                return s.Contains(mot.ToLower());
            });
        }

    }

    public class NotFoundException : Exception
    {

    }
}