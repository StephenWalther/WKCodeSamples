using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EFCodeFirst.Models {
    class MyInitializer : DropCreateDatabaseIfModelChanges<DataContext> {


        protected override void Seed(DataContext context) {

            var movies = new List<Movie> {
                new Movie {MovieId=1, Title="Star Wars", Director="Lucas"},
                new Movie {MovieId=12, Title="Star Wars II", Director="Lucas"},
                new Movie {MovieId=3, Title="Star Wars III", Director="Lucas"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }
}
