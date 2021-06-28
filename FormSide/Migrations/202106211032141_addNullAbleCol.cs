namespace FormSide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNullAbleCol : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.usergroups", "createdBy", c => c.Long());
            AlterColumn("dbo.usergroups", "createdDate", c => c.DateTime());
            AlterColumn("dbo.usergroups", "editedBy", c => c.Long());
            AlterColumn("dbo.usergroups", "EditedDate", c => c.DateTime());
            AlterColumn("dbo.usergroups", "deleteBy", c => c.Long());
            AlterColumn("dbo.usergroups", "deleteDate", c => c.DateTime());
            AlterColumn("dbo.users", "createdBy", c => c.Long());
            AlterColumn("dbo.users", "createdDate", c => c.DateTime());
            AlterColumn("dbo.users", "editedBy", c => c.Long());
            AlterColumn("dbo.users", "EditedDate", c => c.DateTime());
            AlterColumn("dbo.users", "deleteBy", c => c.Long());
            AlterColumn("dbo.users", "deleteDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "deleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.users", "deleteBy", c => c.Long(nullable: false));
            AlterColumn("dbo.users", "EditedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.users", "editedBy", c => c.Long(nullable: false));
            AlterColumn("dbo.users", "createdDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.users", "createdBy", c => c.Long(nullable: false));
            AlterColumn("dbo.usergroups", "deleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.usergroups", "deleteBy", c => c.Long(nullable: false));
            AlterColumn("dbo.usergroups", "EditedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.usergroups", "editedBy", c => c.Long(nullable: false));
            AlterColumn("dbo.usergroups", "createdDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.usergroups", "createdBy", c => c.Long(nullable: false));
        }
    }
}
