using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Diagnostique : Document
    {
        public string  CodeDiag { get; set; }

        public DateTime DateCreat { get; set; }

        public Expert Expert { get; set; }

        public string Description { get; set; }

        public DateTime DateModif { get; set; }

        public Expert ExpModif { get; set; }

        public IEnumerable<DetailDiag> MyProperty { get; set; }
    }
}
