namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_neww : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "AboutDate");
        }
    }
}
