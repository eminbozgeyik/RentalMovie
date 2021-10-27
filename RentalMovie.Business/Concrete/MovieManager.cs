using RentalMovie.Business.Abstract;
using Business.BusinessAspect.Autofac;
using RentalMovie.Business.Constants;
using RentalMovie.Business.ValidationRules.FluentValidation;
using RentalMovie.Core.Utilities.Results;
using RentalMovie.DataAccess.Abstract;
using RentalMovie.Entities.Concrete;
using RentalMovie.Entities.DTOs;
using System.Collections.Generic;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Autofac.Cacheing;
using Core.Aspects.Autofac.Performance;

namespace RentalMovie.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal) 
        {
            _movieDal = movieDal;
        }

 //       [@SecuredOperation("admin")]
        [ValidationAspect(typeof(MovieValidator))]
        [CacheRemoveAspect("IMovieService.Get")]
        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(Messages.MovieAdded);
        }

//        [@SecuredOperation("admin")]
        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.MovieDeleted);
        }

//        [@SecuredOperation("admin")]
        [PerformanceAspect(5)]
        public IDataResult<List<Movie>> GetAll()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(), Messages.MoviesListed);
        }

        [CacheAspect]
        public IDataResult<Movie> GetById(int id)
        {
            return new SuccessDataResult<Movie>(_movieDal.Get(c => c.MovieId == id));
        }

        public IDataResult<List<Movie>> GetMoviesByCategoryId(int id)
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetAll(m => m.MovieId == id));
        }

        public IDataResult<List<MovieDetailDto>> GetMovieDetails()
        {
            return new SuccessDataResult<List<MovieDetailDto>>(_movieDal.GetMovieDetails(), Messages.MoviesListed);
        }

        [ValidationAspect(typeof(MovieValidator))]
        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(Messages.MovieUpdated);
        }
    }
}
