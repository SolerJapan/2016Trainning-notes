namespace prj_CsFormsMasDet
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;


  public partial class tDbcxt : DbContext
  {
    public tDbcxt()
        : base( "name=tDbcxt" )
    {
    }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product>  Products   { get; set; }

  } // class

} // ns
