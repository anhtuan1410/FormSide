namespace FormSide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_add_column_note : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "note", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "note");
        }
    }
}
