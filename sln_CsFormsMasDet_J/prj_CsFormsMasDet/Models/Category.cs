namespace prj_CsFormsMasDet
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;


  public partial class Category
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors" )]
    public Category()
    {
      Products = new tObservableListSource<Product>();
    }

    [Key]
    public int CatId { get; set; }

    [StringLength( 30 )]
    public string CatName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly" )]
    public virtual tObservableListSource<Product> Products { get; set; }
  }
}
