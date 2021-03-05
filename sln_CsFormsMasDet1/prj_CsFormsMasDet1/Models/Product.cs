namespace prj_CsFormsMasDet1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [Key]
        public int ProdId { get; set; }

        [StringLength(30)]
        public string ProdName { get; set; }

        public int CatId { get; set; }

        public virtual Category Category { get; set; }
    }
}
