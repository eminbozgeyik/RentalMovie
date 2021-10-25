using RentalMovie.Core.DataAccess.EntityFramework;
using RentalMovie.DataAccess.Abstract;
using RentalMovie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.DataAccess.Concrete.Ef
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category, MoviesContext>, ICategoryDal
    {
    }
}
