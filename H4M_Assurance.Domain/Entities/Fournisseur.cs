using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Fournisseur
    {
        [Key]
        public int IdFournisseur { get; set; }

        public string RSFournisseur { get; set; }

        public Adresse AdresseFournisseur { get; set; }

        public string MatriculeFiscal { get; set; }

        public NomComplet Contact { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string SiteWeb { get; set; }

        public Boolean EstExonere { get; set; }

        public string AttestationExo { get; set; }

        public string RegistreCommerce { get; set; }



    }
}
