using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prj_CsWebSpa_prc.Models
{
    [TableAttribute(name: "Books")]
    public class tBook
    {
        [KeyAttribute()]
        [DisplayAttribute(Name = "Book ID")]
        [ColumnAttribute(name: "BookID")]
        public int p_iBookId { get; set; }


        [RequiredAttribute()]
        [StringLengthAttribute(maximumLength: 40)]
        [DisplayAttribute(Name = "Title")]
        [ColumnAttribute(name: "Title")]
        public string p_oStrTitle { get; set; }


        [RequiredAttribute()]
        [DisplayAttribute(Name = "Pub Year")]
        [ColumnAttribute(name: "PubYear")]
        public int p_iPubYear { get; set; }


        [RequiredAttribute()]
        [DisplayAttribute(Name = "Price")]
        [ColumnAttribute(name: "Price")]
        [DisplayFormatAttribute(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal p_dPrice { get; set; }


        [RequiredAttribute()]
        [StringLengthAttribute(maximumLength: 30)]
        [DisplayAttribute(Name = "Genre")]
        [ColumnAttribute(name: "Genre")]
        public string p_oStrGenre { get; set; }


        [ForeignKeyAttribute(name: "p_oAuthor")]
        [DisplayAttribute(Name = "Author ID")]
        [ColumnAttribute(name: "AuthorID")]
        public int p_iAuthorId { get; set; }


        // navprops
        public virtual tAuthor p_oAuthor { get; set; }

    } // class

} // ns