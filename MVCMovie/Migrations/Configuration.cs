namespace MVCMovie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVCMovie.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genge = "Romantic Comedy",
            Rating = "PG",
            price = 7.99M
        }
   );
        }
    }
}
