using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediatekDocumentsModelsTests
{
    [TestClass]
    public class UtilisateurTests
    {
        public static string login = "RubenGallien";
        public static string password = "RubenGallien100";
        public static int idService = 2;
        public static string libelle = "administratif";


        private static readonly Utilisateur utilisateur = new Utilisateur(login, password, idService, libelle);

        [TestMethod()]
        public void UtilisateurTest()
        {
            Assert.AreEqual(login, utilisateur.Login, "devrait réussir : user valorisé");
            Assert.AreEqual(password, utilisateur.Password, "devrait réussir : pwd valorisé");
            Assert.AreEqual(idService, utilisateur.IdService, "devrait réussir : idService valorisé");
            Assert.AreEqual(libelle, utilisateur.Libelle, "devrait réussir : libellé valorisé");
        }
    }
}
