using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace MediatekDocumentsModelsTests
{
    [TestClass]
    public class LivreTests
    {
        private const string id = "00023";
        private const string titre = "Les 100";
        private const string image = "";
        private const string isbn = "11111111111";
        private const string auteur = "Kass Morgan";
        private const string collection = "Laffont";
        private const string idGenre = "10002";
        private const string genre = "Science Fiction";
        private const string idPublic = "00003";
        private const string lePublic = "Tous publics";
        private const string idRayon = "JN002";
        private const string rayon = "Jeunesse romans";

        private static readonly Livre livre = new Livre(id, titre, image, isbn, auteur, collection, idGenre, genre, idPublic, lePublic, idRayon, rayon);

        [TestMethod()]
        public void LivreTest()
        {
            Assert.AreEqual(id, livre.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(titre, livre.Titre, "devrait réussir : titre valorisé");
            Assert.AreEqual(image, livre.Image, "devrait réussir : chemin de l'image valorisé");
            Assert.AreEqual(isbn, livre.Isbn, "devrait réussir : isbn valorisé");
            Assert.AreEqual(auteur, livre.Auteur, "devrait réussir : auteur valorisé");
            Assert.AreEqual(collection, livre.Collection, "devrait réussir : collection valorisée");
            Assert.AreEqual(idGenre, livre.IdGenre, "devrait réussir : idGenre valorisé");
            Assert.AreEqual(genre, livre.Genre, "devrait réussir : genre valorisé");
            Assert.AreEqual(idPublic, livre.IdPublic, "devrait réussir : idPublic valorisé");
            Assert.AreEqual(lePublic, livre.Public, "devrait réussir : public valorisé");
            Assert.AreEqual(idRayon, livre.IdRayon, "devrait réussir : idRayon valorisé");
            Assert.AreEqual(rayon, livre.Rayon, "devrait réussir : rayon valorisé");
        }
    }
}
