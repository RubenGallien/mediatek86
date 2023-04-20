using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestParutionAbonnement
{
    [TestClass]
    public class TestParution
    {
        [TestMethod]
        public void TestParutionDansAbonnement()
        {
            DateTime dateCommande = new DateTime(2022, 10, 3);
            DateTime dateFinAbonnement = new DateTime(2022, 11, 3);
            DateTime dateParution = new DateTime(2022, 10, 4);
            bool resultatAttendu = true;

            bool resultatActuel = ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);

            Assert.AreEqual(resultatAttendu, resultatActuel);
        }

        public bool ParutionDansAbonnement(DateTime dateCommande, DateTime dateFinAbonnement, DateTime dateParution)
        {
            return (DateTime.Compare(dateCommande, dateParution) < 0 && DateTime.Compare(dateParution, dateFinAbonnement) < 0);
        }
    }
}
