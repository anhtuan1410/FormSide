namespace FormSide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNoteColForUserGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.usergroups", "note", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.usergroups", "note");
        }
    }
}
