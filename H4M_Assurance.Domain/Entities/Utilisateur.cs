using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }

        public string Login { get; set; }

        public string Mdp { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DateModif { get; set; }

        public NomComplet NomPrenom { get; set; }

        public string Email { get; set; }


    }
}
