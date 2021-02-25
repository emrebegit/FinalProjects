using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _ICategoryDAL;
        public CategoryManager(ICategoryDAL CategoryDal)
        {
            _ICategoryDAL = CategoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_ICategoryDAL.GetAll());
        }

        public IDataResult<Category> GetById(int categoryid)
        {
            return new SuccessDataResult<Category>( _ICategoryDAL.Get(c => c.CategoryId == categoryid));
        }
    }
}
