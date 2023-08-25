using System.Runtime.Serialization;

namespace TP_TDDLibrary
{
    public class RechercheVille
    {
        private List<String> villes = new List<String>(new String[] {"Valenciennes", "Vancouver", "Budapest"});

        public List<String> Rechercher(String mot)
        {
            if (mot.Length < 2) throw new NotFoundException();
            else
            {
                return villes.FindAll(s => {
                    s = s.ToLower();
                    return s.Contains(mot.ToLower());
                    });
            }
        }

    }

    public class NotFoundException : Exception
    {

    }
}