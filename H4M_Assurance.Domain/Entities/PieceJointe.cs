using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class PieceJointe
    {
        [Key]
        public int IdPieceJointe { get; set; }

        public string Path  { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public string Extension { get; set; }

        public DateTime DateCreation { get; set; }

        public Utilisateur UserCreat { get; set; }

        public DateTime   DateModif { get; set; }

        public Utilisateur UserModif { get; set; }

    }
}
