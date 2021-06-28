namespace FormSide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.usergroups",
                c => new
                    {
                        IdUserGroup = c.Long(nullable: false, identity: true),
                        groupname = c.String(nullable: false, maxLength: 500),
                        createdBy = c.Long(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        editedBy = c.Long(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                        deleteBy = c.Long(nullable: false),
                        deleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUserGroup);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 200),
                        password = c.String(nullable: false, maxLength: 4000),
                        firstname = c.String(nullable: false, maxLength: 500),
                        lastname = c.String(nullable: false, maxLength: 500),
                        email = c.String(nullable: false, maxLength: 500),
                        IdUser = c.Long(nullable: false, identity: true),
                        IdUserGroup = c.Long(nullable: false),
                        createdBy = c.Long(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        editedBy = c.Long(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                        deleteBy = c.Long(nullable: false),
                        deleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.usergroups", t => t.IdUserGroup, cascadeDelete: true)
                .Index(t => t.IdUserGroup);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.users", "IdUserGroup", "dbo.usergroups");
            DropIndex("dbo.users", new[] { "IdUserGroup" });
            DropTable("dbo.users");
            DropTable("dbo.usergroups");
        }
    }
}
