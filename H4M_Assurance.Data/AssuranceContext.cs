using H4M_Assurance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H4M_Assurance.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AssuranceContext : DbContext
    {
        public AssuranceContext() : base("name=Assurance")
        {

        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Constat> Constats { get; set; }
        public DbSet<FactureReparation> FacturesReparation { get; set; }
        public DbSet<OffrePrix> OffresPrix { get; set; }
        public DbSet<Diagnostique> Diagnostiques { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<PieceJointe> PieceJointes { get; set; }
        public DbSet<AgentAssureur> AgentsAssureurs { get; set; }
        public DbSet<Assure> Assures { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<DetailDiag> LignesDiagnostique { get; set; }
        public DbSet<DetailFR> LignesFactures { get; set; }
        public DbSet<DetailOP> LignesOffresPrix { get; set; }
        public DbSet<Remboursement> Remboursements { get; set; }
        public DbSet<Option> Options { get; set; }

    }
}
