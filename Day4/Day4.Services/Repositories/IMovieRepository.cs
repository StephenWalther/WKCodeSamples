using System;
namespace Day4.Services.Repositories {
    public interface IMovieRepository {
        void Create(Day4.DomainModel.Movie movieToCreate);
        System.Collections.Generic.IList<Day4.DomainModel.Movie> ListAllMovies(params System.Linq.Expressions.Expression<Func<Day4.DomainModel.Movie, object>>[] includeProperties);
        void SaveChanges();
    }
}
