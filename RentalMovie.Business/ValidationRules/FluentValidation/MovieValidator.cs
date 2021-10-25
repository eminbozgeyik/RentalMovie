using FluentValidation;
using RentalMovie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.Business.ValidationRules.FluentValidation
{
    public class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m => m.MovieTitle).MinimumLength(1);
            RuleFor(m => m.MovieDescription).MinimumLength(30);
        }
    }
}
