using MediaTekDocuments.model;
using MediaTekDocuments.dal;

namespace MediaTekDocuments.controller
{

    public class FrmAuthentificationController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// récupere les identifiants d'un utilisateur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>True si utilisateur et mot de passe trouvés</returns>
        public bool GetUtilisateur(string login, string password)
        {
            Utilisateur utilisateur = access.GetUtilisateur(login);
            if (utilisateur == null)
            {
                return false;
            }
            if (utilisateur.Password.Equals(password))
            {
                Service.Id = utilisateur.IdService;
                Service.Libelle = utilisateur.Libelle;
                return true;
            }
            return false;
        }

    }
}