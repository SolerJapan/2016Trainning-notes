using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace prj_CsWebSpa_02.Models
{
    [TableAttribute(name: "Authors")]
    public class tAuthor
    {
            [KeyAttribute()]
            [DisplayAttribute(Name = "Author ID")]
            [ColumnAttribute(name: "AuthorID")]
            public int p_iAuthorId { get; set; }


            [RequiredAttribute()]
            [StringLengthAttribute(maximumLength: 40)]
            [DisplayAttribute(Name = "Name")]
            [ColumnAttribute(name: "Name")]
            public string p_oStrName { get; set; }


            // navprops
            //public virtual ICollection<tBook> p_oICollOfBook { get; set; }

    } // class

} // ns