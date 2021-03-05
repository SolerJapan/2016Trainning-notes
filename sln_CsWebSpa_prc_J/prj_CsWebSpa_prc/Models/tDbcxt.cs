using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prj_CsWebSpa_prc.Models
{
    public class tDbcxt : DbContext
    {
        // ctor (default)
        public tDbcxt()
          : base("name=tDbcxt")
        {
        }


        // properties
        public DbSet<tAuthor> p_oDbsetOfAuth { get; set; }
        public DbSet<tBook> p_oDbsetOfBook { get; set; }

    } // class

} // ns
