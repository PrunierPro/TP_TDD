using TP_TDDLibrary;

namespace TP_TDD.Test
{
    [TestClass]
    public class RechercheVilleTest
    {
        [TestMethod]
        public void WhenMotLength_LessThan2_Then_NotFoundException()
        {
            RechercheVille rechercheVille = new RechercheVille();
            string mot = "a";
            Assert.ThrowsException<NotFoundException>(() => rechercheVille.Rechercher(mot));
        }

        [TestMethod]
        public void WhenMotLength_MoreOrEqual2_Then_ReturnVillesBeginningWithMot()
        {
            RechercheVille rechercheVille = new RechercheVille();
            string mot = "Va";
            List<string> expected = new List<string>(new string[] { "Valenciennes", "Vancouver" });
            CollectionAssert.AreEquivalent(expected, rechercheVille.Rechercher(mot));
        }

        [TestMethod]
        public void Test_CaseInsensitive()
        {
            RechercheVille rechercheVille = new RechercheVille();
            string mot = "vA";
            List<string> expected = new List<string>(new string[] { "Valenciennes", "Vancouver" });
            CollectionAssert.AreEquivalent(expected, rechercheVille.Rechercher(mot));
        }

        [TestMethod]
        public void Test_ReturnVilleFromPartOfName()
        {
            RechercheVille rechercheVille = new RechercheVille();
            string mot = "ape";
            List<string> expected = new List<string>(new string[] { "Budapest" });
            CollectionAssert.AreEquivalent(expected, rechercheVille.Rechercher(mot));
        }
    }
}