using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    public class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }

        public List<Suivi> GetAllSuivis()
        {
            return access.GetAllSuivis();
        }


        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        public List<CommandeDocument> GetCommandesDocument(string idDocument)
        {
            return access.GetCommandesDocument(idDocument);
        }

        public List<Abonnement> GetAbonnementRevue(string idDocument)
        {
            return access.GetAbonnementRevue(idDocument);
        }

        /// <summary>
        /// récupère les abonnements qui prennent fin dans 30 jours
        /// </summary>
        /// <returns></returns>
        public List<Abonnement> GetAbonnementsEcheance()
        {
            return access.GetAbonnementsEcheance();
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        public bool CreerCommande(Commande commande)
        {
            return access.CreerCommande(commande);
        }

        /// <summary>
        /// Créé une commande de document dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            return access.CreerCommandeDocument(id, nbExemplaire, idLivreDvd, idSuivi);
        }

        /// <summary>
        /// Modifie l'étape de suivi d'une commande dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <returns>True si la modification a pu se faire</returns>
        internal bool ModifierSuiviCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            return access.ModifierSuiviCommandeDocument(id, nbExemplaire, idLivreDvd, idSuivi);
        }

        /// <summary>
        /// Supprimme une commande de livre dans la bdd
        /// </summary>
        /// <param name="commandesdocument"></param>
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SupprimerCommandeDocument(CommandeDocument commandesDocument)
        {
            return access.SupprimerCommandeDocument(commandesDocument);
        }

        /// <summary>
        /// Crée un abonnement de revue dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateFinAbonnement"></param>
        /// <param name="idRevue"></param>
        /// <returns>True si l'insertion pu se faire</returns>
        public bool CreerAbonnementRevue(string id, DateTime dateFinAbonnement, string idRevue)
        {
            return access.CreerAbonnementRevue(id, dateFinAbonnement, idRevue);
        }

        /// <summary>
        /// Supprimme un abonnement de revue dans la bdd
        /// </summary>
        /// <param name="abonnement"></param>
        /// <returns></returns>
        public bool SupprimerAbonnementRevue(Abonnement abonnement)
        {
            return access.SupprimerAbonnementRevue(abonnement);
        }
    }
}
