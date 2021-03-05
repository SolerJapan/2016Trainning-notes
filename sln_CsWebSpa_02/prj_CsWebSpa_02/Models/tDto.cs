using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace prj_CsWebSpa.Models
{
    public class tDtoBook
    {
        public int p_iBookId { get; set; }
        public string p_oStrTitle { get; set; }
        public string p_oStrAuthorName { get; set; }

    } // class


    public class tDtoBookDets
    {
        public int p_iBookId { get; set; }
        public string p_oStrTitle { get; set; }
        public int p_iPubYear { get; set; }
        public decimal p_dPrice
        {
            get; set;
        }
    public string p_oStrAuthorName { get; set; }
        public string p_oStrGenre { get; set; }

    } // class

} // ns
