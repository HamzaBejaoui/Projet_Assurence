namespace H4M_Assurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class installation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        IdUtilisateur = c.Int(nullable: false, identity: true),
                        Login = c.String(unicode: false),
                        Mdp = c.String(unicode: false),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        DateModif = c.DateTime(nullable: false, precision: 0),
                        NomPrenom_Nom = c.String(unicode: false),
                        NomPrenom_Prenom = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Fonction = c.String(unicode: false),
                        Salaire = c.Decimal(precision: 18, scale: 2),
                        DateEmbauche = c.DateTime(precision: 0),
                        Adresse_Rue = c.String(unicode: false),
                        Adresse_CodePostal = c.String(unicode: false),
                        Adresse_Ville = c.String(unicode: false),
                        Adresse_Pays = c.String(unicode: false),
                        DateNaissance = c.String(unicode: false),
                        CIN = c.String(unicode: false),
                        Tel = c.String(unicode: false),
                        NumPermisConduite = c.String(unicode: false),
                        DatePermisConduite = c.DateTime(precision: 0),
                        MatriculeFiscal = c.String(unicode: false),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdUtilisateur);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        IdDocument = c.Int(nullable: false, identity: true),
                        NomDocument = c.String(unicode: false),
                        Ordre = c.Int(nullable: false),
                        CodeConstat = c.String(unicode: false),
                        DateSinistre = c.DateTime(precision: 0),
                        LieuSinistre = c.String(unicode: false),
                        Blesse = c.Boolean(),
                        Degats = c.Boolean(),
                        ConducteurAsuure_NomConducteur_Nom = c.String(unicode: false),
                        ConducteurAsuure_NomConducteur_Prenom = c.String(unicode: false),
                        ConducteurAsuure_AdresseConducteur_Rue = c.String(unicode: false),
                        ConducteurAsuure_AdresseConducteur_CodePostal = c.String(unicode: false),
                        ConducteurAsuure_AdresseConducteur_Ville = c.String(unicode: false),
                        ConducteurAsuure_AdresseConducteur_Pays = c.String(unicode: false),
                        ConducteurAsuure_NumPermisConducteur = c.String(unicode: false),
                        ConducteurAsuure_TelConducteur = c.String(unicode: false),
                        ConducteurTiers_NomConducteur_Nom = c.String(unicode: false),
                        ConducteurTiers_NomConducteur_Prenom = c.String(unicode: false),
                        ConducteurTiers_AdresseConducteur_Rue = c.String(unicode: false),
                        ConducteurTiers_AdresseConducteur_CodePostal = c.String(unicode: false),
                        ConducteurTiers_AdresseConducteur_Ville = c.String(unicode: false),
                        ConducteurTiers_AdresseConducteur_Pays = c.String(unicode: false),
                        ConducteurTiers_NumPermisConducteur = c.String(unicode: false),
                        ConducteurTiers_TelConducteur = c.String(unicode: false),
                        IdContratTiers = c.String(unicode: false),
                        CodeAgenceTiers = c.String(unicode: false),
                        AssuranceTiers = c.String(unicode: false),
                        AgenceTiers = c.String(unicode: false),
                        ValableDuTiers = c.DateTime(precision: 0),
                        ValableAuTiers = c.DateTime(precision: 0),
                        NomAssureTiers_Nom = c.String(unicode: false),
                        NomAssureTiers_Prenom = c.String(unicode: false),
                        AdresseAssureTiers_Rue = c.String(unicode: false),
                        AdresseAssureTiers_CodePostal = c.String(unicode: false),
                        AdresseAssureTiers_Ville = c.String(unicode: false),
                        AdresseAssureTiers_Pays = c.String(unicode: false),
                        TelAssureTiers = c.String(unicode: false),
                        VenantDeAssure = c.String(unicode: false),
                        AllantAAssure = c.String(unicode: false),
                        VenantDeTiers = c.String(unicode: false),
                        AllantATiers = c.String(unicode: false),
                        ObservationsAssure = c.String(unicode: false),
                        ObservationTiers = c.String(unicode: false),
                        EstValide = c.Boolean(),
                        DateValidation = c.DateTime(precision: 0),
                        CodeDiag = c.String(unicode: false),
                        DateCreat = c.DateTime(precision: 0),
                        Description = c.String(unicode: false),
                        DateModif = c.DateTime(precision: 0),
                        CodeFR = c.String(unicode: false),
                        DateFacture = c.DateTime(precision: 0),
                        DateCreat1 = c.DateTime(precision: 0),
                        DateModif1 = c.DateTime(precision: 0),
                        MntRemboursement = c.Decimal(precision: 18, scale: 2),
                        CodeOP = c.String(unicode: false),
                        DateOP = c.DateTime(precision: 0),
                        DateCreat2 = c.DateTime(precision: 0),
                        DateModif2 = c.DateTime(precision: 0),
                        DateValidation1 = c.DateTime(precision: 0),
                        TypePaiement = c.Int(),
                        MontantRemboursement = c.Decimal(precision: 18, scale: 2),
                        NumPiece = c.String(unicode: false),
                        DateRemboursement = c.DateTime(precision: 0),
                        DateSaisie = c.DateTime(precision: 0),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ContratAssure_IdContrat = c.String(maxLength: 128, storeType: "nvarchar"),
                        ExpertAffecte_IdUtilisateur = c.Int(),
                        Validateur_IdUtilisateur = c.Int(),
                        Expert_IdUtilisateur = c.Int(),
                        ExpModif_IdUtilisateur = c.Int(),
                        Dossier_IdDossier = c.Int(),
                        UserCreat_IdUtilisateur = c.Int(),
                        UserModif_IdUtilisateur = c.Int(),
                        Validateur_IdUtilisateur1 = c.Int(),
                        UserCreat_IdUtilisateur1 = c.Int(),
                        UserModif_IdUtilisateur1 = c.Int(),
                        Validateur_IdUtilisateur2 = c.Int(),
                        AgentSaisie_IdUtilisateur = c.Int(),
                    })
                .PrimaryKey(t => t.IdDocument)
                .ForeignKey("dbo.Contrats", t => t.ContratAssure_IdContrat)
                .ForeignKey("dbo.Utilisateurs", t => t.ExpertAffecte_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.Validateur_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.Expert_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.ExpModif_IdUtilisateur)
                .ForeignKey("dbo.Dossiers", t => t.Dossier_IdDossier)
                .ForeignKey("dbo.Utilisateurs", t => t.UserCreat_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.UserModif_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.Validateur_IdUtilisateur1)
                .ForeignKey("dbo.Utilisateurs", t => t.UserCreat_IdUtilisateur1)
                .ForeignKey("dbo.Utilisateurs", t => t.UserModif_IdUtilisateur1)
                .ForeignKey("dbo.Utilisateurs", t => t.Validateur_IdUtilisateur2)
                .ForeignKey("dbo.Utilisateurs", t => t.AgentSaisie_IdUtilisateur)
                .Index(t => t.ContratAssure_IdContrat)
                .Index(t => t.ExpertAffecte_IdUtilisateur)
                .Index(t => t.Validateur_IdUtilisateur)
                .Index(t => t.Expert_IdUtilisateur)
                .Index(t => t.ExpModif_IdUtilisateur)
                .Index(t => t.Dossier_IdDossier)
                .Index(t => t.UserCreat_IdUtilisateur)
                .Index(t => t.UserModif_IdUtilisateur)
                .Index(t => t.Validateur_IdUtilisateur1)
                .Index(t => t.UserCreat_IdUtilisateur1)
                .Index(t => t.UserModif_IdUtilisateur1)
                .Index(t => t.Validateur_IdUtilisateur2)
                .Index(t => t.AgentSaisie_IdUtilisateur);
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        IdContrat = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        CodeAgence = c.String(unicode: false),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        DateModif = c.DateTime(nullable: false, precision: 0),
                        EstToutRisque = c.Boolean(nullable: false),
                        MontantAssure = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rang = c.Int(nullable: false),
                        Prime = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Assure_IdUtilisateur = c.Int(),
                        Usercreat_IdUtilisateur = c.Int(),
                        UserModif_IdUtilisateur = c.Int(),
                        Vehicule_IdVehicule = c.Int(),
                    })
                .PrimaryKey(t => t.IdContrat)
                .ForeignKey("dbo.Utilisateurs", t => t.Assure_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.Usercreat_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.UserModif_IdUtilisateur)
                .ForeignKey("dbo.Vehicules", t => t.Vehicule_IdVehicule)
                .Index(t => t.Assure_IdUtilisateur)
                .Index(t => t.Usercreat_IdUtilisateur)
                .Index(t => t.UserModif_IdUtilisateur)
                .Index(t => t.Vehicule_IdVehicule);
            
            CreateTable(
                "dbo.Vehicules",
                c => new
                    {
                        IdVehicule = c.Int(nullable: false, identity: true),
                        Matricule = c.String(unicode: false),
                        NumChassie = c.String(unicode: false),
                        DateFabrication = c.DateTime(nullable: false, precision: 0),
                        DateCirculation = c.DateTime(nullable: false, precision: 0),
                        Marque = c.String(unicode: false),
                        Gamme = c.String(unicode: false),
                        PuissanceFiscale = c.String(unicode: false),
                        Motorisation = c.Int(nullable: false),
                        Proprietaire_IdUtilisateur = c.Int(),
                    })
                .PrimaryKey(t => t.IdVehicule)
                .ForeignKey("dbo.Utilisateurs", t => t.Proprietaire_IdUtilisateur)
                .Index(t => t.Proprietaire_IdUtilisateur);
            
            CreateTable(
                "dbo.Dossiers",
                c => new
                    {
                        IdDossier = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        Contrat_IdContrat = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdDossier)
                .ForeignKey("dbo.Contrats", t => t.Contrat_IdContrat)
                .Index(t => t.Contrat_IdContrat);
            
            CreateTable(
                "dbo.Fournisseurs",
                c => new
                    {
                        IdFournisseur = c.Int(nullable: false, identity: true),
                        RSFournisseur = c.String(unicode: false),
                        AdresseFournisseur_Rue = c.String(unicode: false),
                        AdresseFournisseur_CodePostal = c.String(unicode: false),
                        AdresseFournisseur_Ville = c.String(unicode: false),
                        AdresseFournisseur_Pays = c.String(unicode: false),
                        MatriculeFiscal = c.String(unicode: false),
                        Contact_Nom = c.String(unicode: false),
                        Contact_Prenom = c.String(unicode: false),
                        Tel = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        SiteWeb = c.String(unicode: false),
                        EstExonere = c.Boolean(nullable: false),
                        AttestationExo = c.String(unicode: false),
                        RegistreCommerce = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdFournisseur);
            
            CreateTable(
                "dbo.DetailDiags",
                c => new
                    {
                        IdDetail = c.Int(nullable: false),
                        IdPiece = c.Int(nullable: false),
                        IdDocument = c.Int(nullable: false),
                        Qte = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.IdDetail, t.IdPiece, t.IdDocument })
                .ForeignKey("dbo.Documents", t => t.IdDocument, cascadeDelete: true)
                .ForeignKey("dbo.Pieces", t => t.IdPiece, cascadeDelete: true)
                .Index(t => t.IdPiece)
                .Index(t => t.IdDocument);
            
            CreateTable(
                "dbo.Pieces",
                c => new
                    {
                        IdPiece = c.Int(nullable: false, identity: true),
                        Designation = c.String(unicode: false),
                        Reference = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdPiece);
            
            CreateTable(
                "dbo.DetailFRs",
                c => new
                    {
                        IdDetail = c.Int(nullable: false),
                        IdPiece = c.Int(nullable: false),
                        IdDocument = c.Int(nullable: false),
                        Qte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrixHT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TVA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.IdDetail, t.IdPiece, t.IdDocument })
                .ForeignKey("dbo.Documents", t => t.IdDocument, cascadeDelete: true)
                .ForeignKey("dbo.Pieces", t => t.IdPiece, cascadeDelete: true)
                .Index(t => t.IdPiece)
                .Index(t => t.IdDocument);
            
            CreateTable(
                "dbo.DetailOPs",
                c => new
                    {
                        IdDetail = c.Int(nullable: false),
                        IdPiece = c.Int(nullable: false),
                        IdDocument = c.Int(nullable: false),
                        Qte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrixHT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TVA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.IdDetail, t.IdPiece, t.IdDocument })
                .ForeignKey("dbo.Documents", t => t.IdDocument, cascadeDelete: true)
                .ForeignKey("dbo.Pieces", t => t.IdPiece, cascadeDelete: true)
                .Index(t => t.IdPiece)
                .Index(t => t.IdDocument);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        IdOption = c.Int(nullable: false, identity: true),
                        Nom = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        Coefficient = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdOption);
            
            CreateTable(
                "dbo.PieceJointes",
                c => new
                    {
                        IdPieceJointe = c.Int(nullable: false, identity: true),
                        Path = c.String(unicode: false),
                        Nom = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        Extension = c.String(unicode: false),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        DateModif = c.DateTime(nullable: false, precision: 0),
                        UserCreat_IdUtilisateur = c.Int(),
                        UserModif_IdUtilisateur = c.Int(),
                    })
                .PrimaryKey(t => t.IdPieceJointe)
                .ForeignKey("dbo.Utilisateurs", t => t.UserCreat_IdUtilisateur)
                .ForeignKey("dbo.Utilisateurs", t => t.UserModif_IdUtilisateur)
                .Index(t => t.UserCreat_IdUtilisateur)
                .Index(t => t.UserModif_IdUtilisateur);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PieceJointes", "UserModif_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.PieceJointes", "UserCreat_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.DetailOPs", "IdPiece", "dbo.Pieces");
            DropForeignKey("dbo.DetailOPs", "IdDocument", "dbo.Documents");
            DropForeignKey("dbo.DetailFRs", "IdPiece", "dbo.Pieces");
            DropForeignKey("dbo.DetailFRs", "IdDocument", "dbo.Documents");
            DropForeignKey("dbo.DetailDiags", "IdPiece", "dbo.Pieces");
            DropForeignKey("dbo.DetailDiags", "IdDocument", "dbo.Documents");
            DropForeignKey("dbo.Documents", "AgentSaisie_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "Validateur_IdUtilisateur2", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "UserModif_IdUtilisateur1", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "UserCreat_IdUtilisateur1", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "Validateur_IdUtilisateur1", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "UserModif_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "UserCreat_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "Dossier_IdDossier", "dbo.Dossiers");
            DropForeignKey("dbo.Documents", "ExpModif_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "Expert_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "Validateur_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Documents", "ExpertAffecte_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Dossiers", "Contrat_IdContrat", "dbo.Contrats");
            DropForeignKey("dbo.Documents", "ContratAssure_IdContrat", "dbo.Contrats");
            DropForeignKey("dbo.Contrats", "Vehicule_IdVehicule", "dbo.Vehicules");
            DropForeignKey("dbo.Vehicules", "Proprietaire_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Contrats", "UserModif_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Contrats", "Usercreat_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Contrats", "Assure_IdUtilisateur", "dbo.Utilisateurs");
            DropIndex("dbo.PieceJointes", new[] { "UserModif_IdUtilisateur" });
            DropIndex("dbo.PieceJointes", new[] { "UserCreat_IdUtilisateur" });
            DropIndex("dbo.DetailOPs", new[] { "IdDocument" });
            DropIndex("dbo.DetailOPs", new[] { "IdPiece" });
            DropIndex("dbo.DetailFRs", new[] { "IdDocument" });
            DropIndex("dbo.DetailFRs", new[] { "IdPiece" });
            DropIndex("dbo.DetailDiags", new[] { "IdDocument" });
            DropIndex("dbo.DetailDiags", new[] { "IdPiece" });
            DropIndex("dbo.Dossiers", new[] { "Contrat_IdContrat" });
            DropIndex("dbo.Vehicules", new[] { "Proprietaire_IdUtilisateur" });
            DropIndex("dbo.Contrats", new[] { "Vehicule_IdVehicule" });
            DropIndex("dbo.Contrats", new[] { "UserModif_IdUtilisateur" });
            DropIndex("dbo.Contrats", new[] { "Usercreat_IdUtilisateur" });
            DropIndex("dbo.Contrats", new[] { "Assure_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "AgentSaisie_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "Validateur_IdUtilisateur2" });
            DropIndex("dbo.Documents", new[] { "UserModif_IdUtilisateur1" });
            DropIndex("dbo.Documents", new[] { "UserCreat_IdUtilisateur1" });
            DropIndex("dbo.Documents", new[] { "Validateur_IdUtilisateur1" });
            DropIndex("dbo.Documents", new[] { "UserModif_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "UserCreat_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "Dossier_IdDossier" });
            DropIndex("dbo.Documents", new[] { "ExpModif_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "Expert_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "Validateur_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "ExpertAffecte_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "ContratAssure_IdContrat" });
            DropTable("dbo.PieceJointes");
            DropTable("dbo.Options");
            DropTable("dbo.DetailOPs");
            DropTable("dbo.DetailFRs");
            DropTable("dbo.Pieces");
            DropTable("dbo.DetailDiags");
            DropTable("dbo.Fournisseurs");
            DropTable("dbo.Dossiers");
            DropTable("dbo.Vehicules");
            DropTable("dbo.Contrats");
            DropTable("dbo.Documents");
            DropTable("dbo.Utilisateurs");
        }
    }
}
