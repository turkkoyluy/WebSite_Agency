namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "aboutDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "aboutDate", c => c.DateTime(nullable: false));
        }
    }
}
