using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Assure :Utilisateur
    {
        public Adresse Adresse { get; set; }       

        public string DateNaissance { get; set; }

        public string CIN { get; set; }

        public string Tel { get; set; }

        public string NumPermisConduite { get; set; }

        public DateTime DatePermisConduite { get; set; }

        public IEnumerable<Vehicule> Vehicules { get; set; }
    }
}
