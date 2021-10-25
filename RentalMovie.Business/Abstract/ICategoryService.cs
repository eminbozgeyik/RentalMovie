using RentalMovie.Core.Utilities.Results;
using RentalMovie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetByCategoryName(string name);
        IDataResult<Category> GetById(int id);
        IDataResult<List<Category>> GetAll();
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
