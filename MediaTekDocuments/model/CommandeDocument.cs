using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CommandeDocument : Commande
    {
        public int NbExemplaire { get; set; }
        public string IdLivreDvd { get; set; }
        public string IdSuivi { get; set; }

        public string Libelle { get; set; }

        public CommandeDocument(string id, DateTime dateCommande, double montant, int nbExemplaire, string idLivreDvd, string idSuivi, string libelle) : base(id, dateCommande, montant)
        {
            this.NbExemplaire = nbExemplaire;
            this.IdLivreDvd = idLivreDvd;
            this.IdSuivi = idSuivi;
            this.Libelle = libelle;
        }
    }
}
