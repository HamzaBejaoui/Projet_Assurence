
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        AssuranceContext DataContext { get; }
    }

}
