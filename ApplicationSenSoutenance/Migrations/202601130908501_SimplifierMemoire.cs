namespace ApplicationSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimplifierMemoire : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Utilisateurs",
                c => new
                    {
                        IdUtilisateur = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        PrenomUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        TelUtilisateur = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        EmailUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        MotDePasse = c.String(nullable: false, maxLength: 300, storeType: "nvarchar"),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        DateModification = c.DateTime(precision: 0),
                        EstActif = c.Boolean(nullable: false),
                        MatriculeCandidat = c.String(maxLength: 20, storeType: "nvarchar"),
                        IdDepartement = c.Int(),
                        SpecialiteProfesseur = c.String(maxLength: 80, storeType: "nvarchar"),
                        GradeProfesseur = c.String(maxLength: 100, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdUtilisateur)
                .ForeignKey("Departements", t => t.IdDepartement)
                .Index(t => t.IdDepartement);
            
            CreateTable(
                "AnneeAcademiques",
                c => new
                    {
                        IdAnneeAcademique = c.Int(nullable: false, identity: true),
                        LibelleAnneeAcademique = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        AnneeAcademiqueVal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAnneeAcademique);
            
            CreateTable(
                "Sessions",
                c => new
                    {
                        IdSession = c.Int(nullable: false, identity: true),
                        LibelleSession = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        IdAnneeAcademique = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdSession)
                .ForeignKey("AnneeAcademiques", t => t.IdAnneeAcademique, cascadeDelete: true)
                .Index(t => t.IdAnneeAcademique);
            
            CreateTable(
                "Memoires",
                c => new
                    {
                        IdMemoire = c.Int(nullable: false, identity: true),
                        SujetMemoire = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        IdSession = c.Int(nullable: false),
                        IdCandidat = c.Int(nullable: false),
                        DateDepot = c.DateTime(nullable: false, precision: 0),
                        DateModification = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.IdMemoire)
                .ForeignKey("Utilisateurs", t => t.IdCandidat, cascadeDelete: true)
                .ForeignKey("Sessions", t => t.IdSession, cascadeDelete: true)
                .Index(t => t.IdSession)
                .Index(t => t.IdCandidat);
            
            CreateTable(
                "Departements",
                c => new
                    {
                        IdDepartement = c.Int(nullable: false, identity: true),
                        LibelleDepartement = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        CodeDepartement = c.String(maxLength: 20, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdDepartement);
            
            CreateTable(
                "Soutenances",
                c => new
                    {
                        IdSoutenance = c.Int(nullable: false, identity: true),
                        DateSoutenance = c.DateTime(nullable: false, precision: 0),
                        LieuSoutenance = c.String(maxLength: 200, storeType: "nvarchar"),
                        ResultatSoutenance = c.String(maxLength: 40, storeType: "nvarchar"),
                        MentionSoutenance = c.String(maxLength: 100, storeType: "nvarchar"),
                        ObservationsSoutenance = c.String(maxLength: 5000, storeType: "nvarchar"),
                        IdMemoire = c.Int(nullable: false),
                        IdPresident = c.Int(nullable: false),
                        IdRapporteur = c.Int(nullable: false),
                        IdExaminateur1 = c.Int(nullable: false),
                        IdExaminateur2 = c.Int(),
                        NoteSoutenance = c.Decimal(precision: 18, scale: 2),
                        DateCreation = c.DateTime(nullable: false, precision: 0),
                        DateModification = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.IdSoutenance)
                .ForeignKey("Utilisateurs", t => t.IdExaminateur1, cascadeDelete: true)
                .ForeignKey("Utilisateurs", t => t.IdExaminateur2)
                .ForeignKey("Memoires", t => t.IdMemoire, cascadeDelete: true)
                .ForeignKey("Utilisateurs", t => t.IdPresident, cascadeDelete: true)
                .ForeignKey("Utilisateurs", t => t.IdRapporteur, cascadeDelete: true)
                .Index(t => t.IdMemoire)
                .Index(t => t.IdPresident)
                .Index(t => t.IdRapporteur)
                .Index(t => t.IdExaminateur1)
                .Index(t => t.IdExaminateur2);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Soutenances", "IdRapporteur", "Utilisateurs");
            DropForeignKey("Soutenances", "IdPresident", "Utilisateurs");
            DropForeignKey("Soutenances", "IdMemoire", "Memoires");
            DropForeignKey("Soutenances", "IdExaminateur2", "Utilisateurs");
            DropForeignKey("Soutenances", "IdExaminateur1", "Utilisateurs");
            DropForeignKey("Utilisateurs", "IdDepartement", "Departements");
            DropForeignKey("Memoires", "IdSession", "Sessions");
            DropForeignKey("Memoires", "IdCandidat", "Utilisateurs");
            DropForeignKey("Sessions", "IdAnneeAcademique", "AnneeAcademiques");
            DropIndex("Soutenances", new[] { "IdExaminateur2" });
            DropIndex("Soutenances", new[] { "IdExaminateur1" });
            DropIndex("Soutenances", new[] { "IdRapporteur" });
            DropIndex("Soutenances", new[] { "IdPresident" });
            DropIndex("Soutenances", new[] { "IdMemoire" });
            DropIndex("Memoires", new[] { "IdCandidat" });
            DropIndex("Memoires", new[] { "IdSession" });
            DropIndex("Sessions", new[] { "IdAnneeAcademique" });
            DropIndex("Utilisateurs", new[] { "IdDepartement" });
            DropTable("Soutenances");
            DropTable("Departements");
            DropTable("Memoires");
            DropTable("Sessions");
            DropTable("AnneeAcademiques");
            DropTable("Utilisateurs");
        }
    }
}
