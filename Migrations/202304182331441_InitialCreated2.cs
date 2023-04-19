namespace CelilCavus.ElementWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreated2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BaseEntities", newName: "Abouts");
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 11),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceIcon = c.String(nullable: false, maxLength: 100),
                        ServiceTitle = c.String(nullable: false, maxLength: 100),
                        ServiceDescription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Abouts", "AboutTitle", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Abouts", "AboutSubTitle", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Abouts", "AboutImage", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Abouts", "AboutDescription", c => c.String(nullable: false, maxLength: 300));
            DropColumn("dbo.Abouts", "Name");
            DropColumn("dbo.Abouts", "Email");
            DropColumn("dbo.Abouts", "PhoneNumber");
            DropColumn("dbo.Abouts", "Message");
            DropColumn("dbo.Abouts", "ServiceIcon");
            DropColumn("dbo.Abouts", "ServiceTitle");
            DropColumn("dbo.Abouts", "ServiceDescription");
            DropColumn("dbo.Abouts", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Abouts", "ServiceDescription", c => c.String(maxLength: 200));
            AddColumn("dbo.Abouts", "ServiceTitle", c => c.String(maxLength: 100));
            AddColumn("dbo.Abouts", "ServiceIcon", c => c.String(maxLength: 100));
            AddColumn("dbo.Abouts", "Message", c => c.String());
            AddColumn("dbo.Abouts", "PhoneNumber", c => c.String(maxLength: 11));
            AddColumn("dbo.Abouts", "Email", c => c.String(maxLength: 100));
            AddColumn("dbo.Abouts", "Name", c => c.String());
            AlterColumn("dbo.Abouts", "AboutDescription", c => c.String(maxLength: 300));
            AlterColumn("dbo.Abouts", "AboutImage", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "AboutSubTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.Abouts", "AboutTitle", c => c.String(maxLength: 100));
            DropTable("dbo.Services");
            DropTable("dbo.Contacts");
            RenameTable(name: "dbo.Abouts", newName: "BaseEntities");
        }
    }
}
