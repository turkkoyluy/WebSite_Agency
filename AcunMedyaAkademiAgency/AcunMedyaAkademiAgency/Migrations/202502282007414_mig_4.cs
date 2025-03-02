namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ProjectDetails", "ProjectId");
            AddForeignKey("dbo.ProjectDetails", "ProjectId", "dbo.Projects", "ProjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectDetails", "ProjectId", "dbo.Projects");
            DropIndex("dbo.ProjectDetails", new[] { "ProjectId" });
        }
    }
}
