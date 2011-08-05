using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ShowScaffolding.Models
{ 
    public class MovieRepository : IMovieRepository
    {
        ShowScaffoldingContext context = new ShowScaffoldingContext();

        public IQueryable<Movie> All
        {
            get { return context.Movies; }
        }

        public IQueryable<Movie> AllIncluding(params Expression<Func<Movie, object>>[] includeProperties)
        {
            IQueryable<Movie> query = context.Movies;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Movie Find(long id)
        {
            return context.Movies.Find(id);
        }

        public void InsertOrUpdate(Movie movie)
        {
            if (movie.Id == default(long)) {
                // New entity
                context.Movies.Add(movie);
            } else {
                // Existing entity
                context.Entry(movie).State = EntityState.Modified;
            }
        }

        public void Delete(long id)
        {
            var movie = context.Movies.Find(id);
            context.Movies.Remove(movie);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IMovieRepository
    {
        IQueryable<Movie> All { get; }
        IQueryable<Movie> AllIncluding(params Expression<Func<Movie, object>>[] includeProperties);
        Movie Find(long id);
        void InsertOrUpdate(Movie movie);
        void Delete(long id);
        void Save();
    }
}