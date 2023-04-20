using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Suivi
    {
        public string Id { get; set; }
        public string Libelle { get; set; }

        public Suivi(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
    }
}
