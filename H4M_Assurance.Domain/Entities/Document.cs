using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Document
    {
        [Key]
        public int IdDocument { get; set; }

        public string NomDocument { get; set; }

        public int Ordre { get; set; }

        public virtual IEnumerable<PieceJointe> PiecesJointes { get; set; }

        public Dossier Dossier { get; set; }
    }
}
