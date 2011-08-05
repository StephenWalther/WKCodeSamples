using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Day4.Services.Infrastructure;
using Day4.DomainModel;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Day4.Services.Repositories {
    public class MovieRepository : Day4.Services.Repositories.IMovieRepository {

        private DataContext dataContext = new DataContext();


        public IList<Movie> ListAllMovies(params Expression<Func<Movie, object>>[] includeProperties) {
            IQueryable<Movie> query = dataContext.Movies;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.ToList();

        
        }


        public void Create(Movie movieToCreate) {
            dataContext.Movies.Add(movieToCreate);
        }

        public void SaveChanges() {
            dataContext.SaveChanges();
        }


    


    }
}
