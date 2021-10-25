using RentalMovie.Business.Abstract;
using RentalMovie.Business.Constants;
using RentalMovie.Core.Utilities.Results;
using RentalMovie.DataAccess.Abstract;
using RentalMovie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovie.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }
        
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);

        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<Category> GetByCategoryName(string name)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryName == name));
        }

        public IDataResult<Category> GetById(int id)
        {

            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));

        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
