namespace prj_TesterProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tester")]
    public partial class Tester
    {
        [Key]
        public int QId { get; set; }

        [Required]
        [StringLength(100)]
        public string Question { get; set; }

        [StringLength(30)]
        public string askAns1 { get; set; }

        [StringLength(30)]
        public string askAns2 { get; set; }

        [StringLength(30)]
        public string askAns3 { get; set; }

        [StringLength(30)]
        public string askAns4 { get; set; }

        [Required]
        [StringLength(30)]
        public string TAns { get; set; }
    }
}
