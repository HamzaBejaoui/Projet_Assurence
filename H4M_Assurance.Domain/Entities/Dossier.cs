using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Dossier
    {
        [Key]
        public int IdDossier { get; set; }

        public DateTime DateCreation { get; set; }

        public Contrat Contrat { get; set; }

        public IEnumerable<Document> Documents { get; set; }


    }
}
