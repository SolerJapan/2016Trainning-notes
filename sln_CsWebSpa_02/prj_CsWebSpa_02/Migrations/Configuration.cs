namespace prj_CsWebSpa_02.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<prj_CsWebSpa_02.Models.tDbcxt>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(tDbcxt oDbcxt)
        {
            // method is called after migrating to latest version
            // use DbSet<T>.AddOrUpdate() extension method to avoid creating duplicate seed data
            // context.People.AddOrUpdate( p => p.FullName,
            //     new Person { FullName = "Andrew Peters" },
            //     new Person { FullName = "Brice Lambson" },
            //     new Person { FullName = "Rowan Miller" }
            //   );

            oDbcxt.tAuthors.AddOrUpdate(auth => auth.p_oStrName,
                new tAuthor() { p_iAuthorId = 1, p_oStrName = "Jane Austen" },
                new tAuthor() { p_iAuthorId = 2, p_oStrName = "Charles Dickens" },
                new tAuthor() { p_iAuthorId = 3, p_oStrName = "Miguel de Cervantes" }
              );

            oDbcxt.tBooks.AddOrUpdate(bk => bk.p_oStrTitle,
                new tBook() { p_iBookId = 1, p_oStrTitle = "Pride and Prejudice", p_iPubYear = 1813, p_iAuthorId = 1, p_dPrice = 9.99M, p_oStrGenre = "Comedy of manners" },
                new tBook() { p_iBookId = 2, p_oStrTitle = "Northanger Abbey", p_iPubYear = 1817, p_iAuthorId = 1, p_dPrice = 12.95M, p_oStrGenre = "Gothic parody" },
                new tBook() { p_iBookId = 3, p_oStrTitle = "David Copperfield", p_iPubYear = 1850, p_iAuthorId = 2, p_dPrice = 15.99M, p_oStrGenre = "Bildungsroman" },
                new tBook() { p_iBookId = 4, p_oStrTitle = "Don Quixote", p_iPubYear = 1617, p_iAuthorId = 3, p_dPrice = 8.95M, p_oStrGenre = "Picaresque" }
              );
        }
    }
    
}
