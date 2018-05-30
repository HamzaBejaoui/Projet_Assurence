using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class OffrePrix : Document
    {
        [Key]
        public string CodeOP { get; set; }

        public DateTime DateOP { get; set; }

        public DateTime DateCreat { get; set; }

        public Utilisateur UserCreat { get; set; }

        public DateTime DateModif { get; set; }

        public Utilisateur UserModif { get; set; }

        public IEnumerable<DetailOP> Pieces { get; set; }

        public Expert Validateur { get; set; }

        public DateTime DateValidation { get; set; }


    }
}
