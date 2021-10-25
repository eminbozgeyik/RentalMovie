using RentalMovie.Core.DataAccess;
using RentalMovie.Entities.Concrete;
using RentalMovie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.DataAccess.Abstract
{
    public interface IMovieDal: IEntityRepository<Movie>
    {
        List<MovieDetailDto> GetMovieDetails();
    }
}
