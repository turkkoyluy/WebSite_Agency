namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionToProjectDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectDetails", "Description", c => c.String());
            DropColumn("dbo.ProjectDetails", "ProjectName");
            DropColumn("dbo.ProjectDetails", "Title");
            DropColumn("dbo.ProjectDetails", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectDetails", "ImageUrl", c => c.String());
            AddColumn("dbo.ProjectDetails", "Title", c => c.String());
            AddColumn("dbo.ProjectDetails", "ProjectName", c => c.String());
            DropColumn("dbo.ProjectDetails", "Description");
        }
    }
}
