namespace CelilCavus.ElementWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AboutTitle = c.String(maxLength: 100),
                        AboutSubTitle = c.String(maxLength: 150),
                        AboutImage = c.String(maxLength: 1000),
                        AboutDescription = c.String(maxLength: 300),
                        Name = c.String(),
                        Email = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 11),
                        Message = c.String(),
                        ServiceIcon = c.String(maxLength: 100),
                        ServiceTitle = c.String(maxLength: 100),
                        ServiceDescription = c.String(maxLength: 200),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BaseEntities");
        }
    }
}
