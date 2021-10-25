using RentalMovie.Core.Utilities.Results;
using RentalMovie.Entities.Concrete;
using RentalMovie.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.Business.Abstract

{
    public interface IMovieService
    {
        IResult Add(Movie entity);
        IDataResult<List<Movie>> GetMoviesByCategoryId(int id);
        IResult Update(Movie entity);
        IResult Delete(Movie entity);
        IDataResult<Movie> GetById(int id);
        IDataResult<List<Movie>> GetAll();
        IDataResult<List<MovieDetailDto>> GetMovieDetails();
    }
}
