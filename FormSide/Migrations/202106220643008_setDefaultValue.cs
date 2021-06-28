namespace FormSide.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class setDefaultValue : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "createdDate",
                        new Dictionary<string, object>
                        {
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                });
        }
    }
}
