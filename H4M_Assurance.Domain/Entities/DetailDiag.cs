using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H4M_Assurance.Domain.Entities
{
    public class DetailDiag
    {
        [Key]
        [Column(Order = 0)]
        public int IdDetail { get; set; }

        [Key]
        [Column(Order = 1)]
        public int IdPiece { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdDocument { get; set; }

        public virtual Piece Piece { get; set; }

        public virtual Diagnostique Diagnostique { get; set; }

        public decimal Qte { get; set; }
    }
}