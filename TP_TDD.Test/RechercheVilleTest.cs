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
    }
}