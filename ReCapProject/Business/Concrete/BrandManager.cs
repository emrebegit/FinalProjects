using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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
        [SecuredOperation("brand.add,admin")]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _Ibranddal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _Ibranddal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_Ibranddal.GetAll(),Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int brandid)
        {
            return new SuccessDataResult<Brand>(_Ibranddal.Get(b => b.BrandId == brandid));
        }

        public IResult Update(Brand brand)
        {
            _Ibranddal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
