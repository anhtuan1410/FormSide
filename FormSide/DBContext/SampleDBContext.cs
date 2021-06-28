using FormSide.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSide.DBContext
{
    public class SampleDBContext : System.Data.Entity.DbContext
    {
        public SampleDBContext(): base("name=SampleDatabase")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //add default value fo columns
            var convention = new AttributeToColumnAnnotationConvention<DefaultValueAttribute, string>("SqlDefaultValue", (p, attributes) => attributes.SingleOrDefault().Value.ToString());
            modelBuilder.Conventions.Add(convention);
        }

        //public override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}
    }
}
