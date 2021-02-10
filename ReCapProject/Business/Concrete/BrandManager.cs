using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDAL _Ibranddal;
        public BrandManager(IBrandDAL _Ibranddal1)
        {
            _Ibranddal = _Ibranddal1;
        }
        public void Add(Brand brand)
        {
            _Ibranddal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _Ibranddal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _Ibranddal.GetAll();
        }

        public Brand GetById(int brandid)
        {
            return _Ibranddal.Get(b => b.BrandId == brandid);
        }

        public void Update(Brand brand)
        {
            _Ibranddal.Update(brand);
        }
    }
}
