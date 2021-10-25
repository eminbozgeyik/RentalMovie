using RentalMovie.Core.DataAccess.EntityFramework;
using RentalMovie.DataAccess.Abstract;
using RentalMovie.Entities.Concrete;
using RentalMovie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.DataAccess.Concrete.Ef
{
    public class EfMovieDal: EfEntityRepositoryBase<Movie, MoviesContext>, IMovieDal
    {
        public List<MovieDetailDto> GetMovieDetails()
        {
            using (MoviesContext context = new MoviesContext())
            {
                var result = from m in context.Movies
                             join c in context.Categories
                             on m.CategoryId equals c.CategoryId
                             select new MovieDetailDto { 
                                 CategoryId = c.CategoryId, 
                                 MovieTitle = m.MovieTitle, 
                                 MovieDescription  = m.MovieDescription,
                                 MovieImageUrl = m.MovieImageUrl
                             };

                return result.ToList();
            }
        }
    }
}
