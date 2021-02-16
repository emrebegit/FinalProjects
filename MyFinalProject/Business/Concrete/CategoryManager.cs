using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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
        public List<Category> GetAll()
        {
            return _ICategoryDAL.GetAll();
        }

        public Category GetById(int categoryid)
        {
            return _ICategoryDAL.Get(c => c.CategoryId == categoryid);
        }
    }
}
