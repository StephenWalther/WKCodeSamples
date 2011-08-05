using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace KO.Models {
    public class DataContext: DbContext {

        public DataContext() {
            Database.SetInitializer(new MyInitializer());
        }


        public DbSet<Movie> Movies { get; set; }

    }

    public class MyInitializer : DropCreateDatabaseAlways<DataContext> {

        protected override void Seed(DataContext context) {

            var movies = new List<Movie> {
                new Movie {Title="King Kong", Director="Jackson"},
                new Movie {Title="Star Wars", Director="Lucas"},
                new Movie {Title="Memento", Director="Nolan"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        
        }
    }

}