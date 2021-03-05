using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prj_CsWebSpa_02.Models
{
    public class tDbcxt : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx/
        // ctor (default)
        public tDbcxt() : base("name=tDbcxt")
        {
            // set Log prop to a delegate it can call with a string that holds a copy of any sql it runs
            base.Database.Log = (str => System.Diagnostics.Debug.WriteLine(str));
        }

        public System.Data.Entity.DbSet<tAuthor> tAuthors { get; set; }

        public System.Data.Entity.DbSet<tBook> tBooks { get; set; }
    }
}
