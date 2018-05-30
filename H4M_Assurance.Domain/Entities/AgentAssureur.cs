using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class AgentAssureur : Utilisateur
    {
        public string Fonction { get; set; }

        public decimal Salaire { get; set; }

        public DateTime DateEmbauche { get; set; }
    }
}
