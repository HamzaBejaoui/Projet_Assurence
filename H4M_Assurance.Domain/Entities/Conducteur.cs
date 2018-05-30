using H4M_Assurance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    [ComplexType]
    public class Conducteur
    {
        
        public NomComplet NomConducteur { get; set; }

        
        public Adresse AdresseConducteur { get; set; }

        public string NumPermisConducteur { get; set; }

        public string TelConducteur { get; set; }
    }
}
