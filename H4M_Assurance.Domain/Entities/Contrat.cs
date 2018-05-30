using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Contrat
    {
        [Key]
        public string IdContrat { get; set; }

        public string CodeAgence { get; set; }

        public DateTime DateCreation { get; set; }

        public AgentAssureur Usercreat { get; set; }

        public DateTime DateModif { get; set; }

        public AgentAssureur UserModif { get; set; }

        public Assure Assure { get; set; }

        public Vehicule Vehicule { get; set; }

        public bool EstToutRisque { get; set; }

        public decimal MontantAssure { get; set; }

        public int Rang { get; set; }

        public decimal Prime { get; set; }

        public IEnumerable<Option> Options { get; set; }
    }
}
