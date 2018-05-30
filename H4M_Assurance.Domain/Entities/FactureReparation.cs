using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class FactureReparation : Document
    {
        public string CodeFR { get; set; }

        public DateTime DateFacture { get; set; }

        public DateTime DateCreat { get; set; }

        public Utilisateur UserCreat { get; set; }

        public DateTime DateModif { get; set; }

        public Utilisateur UserModif { get; set; }

        public IEnumerable<DetailFR> Pieces { get; set; }

        public Expert Validateur { get; set; }

        public decimal MntRemboursement { get; set; }
    }
}
