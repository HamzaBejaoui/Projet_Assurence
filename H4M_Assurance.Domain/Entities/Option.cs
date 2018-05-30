using System.ComponentModel.DataAnnotations;

namespace H4M_Assurance.Domain.Entities
{
    public class Option
    {
        [Key]
        public int IdOption { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public decimal Coefficient { get; set; }


    }
}