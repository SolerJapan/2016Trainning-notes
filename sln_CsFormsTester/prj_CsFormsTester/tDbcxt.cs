namespace prj_CsFormsTester
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class tDbcxt : DbContext
    {
        public tDbcxt()
            : base("name=tDbcxt")
        {
        }

        public virtual DbSet<Tester> Testers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
