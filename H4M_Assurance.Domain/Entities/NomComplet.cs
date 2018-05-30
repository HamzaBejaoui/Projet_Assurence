using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    [ComplexType]
    public class NomComplet
    {

        public string Nom { get; set; }

        public string Prenom { get; set; }
    
    }
}
