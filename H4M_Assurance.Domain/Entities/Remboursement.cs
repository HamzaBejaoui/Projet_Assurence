using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public enum TypePaiement { Espece, Cheque, Virement}
    public class Remboursement : Document
    {

        public TypePaiement TypePaiement { get; set; }

        public decimal MontantRemboursement { get; set; }

        public string NumPiece { get; set; }

        public DateTime DateRemboursement { get; set; }

        public AgentAssureur AgentSaisie { get; set; }

        public DateTime DateSaisie { get; set; }
    }
}
