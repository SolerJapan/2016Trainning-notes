namespace prj_CsFormsTester
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
        public int QuestionId { get; set; }

        [Required]
        [StringLength(200)]
        public string Question { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer1 { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer2 { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer3 { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer4 { get; set; }

        public int Choice { get; set; }
    }
}
