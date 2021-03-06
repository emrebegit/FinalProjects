using Business.Abstract;
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
    public class RentalsManager : IRentalsService
    {
        IRentalsDAL _Irentalsdal;
        public RentalsManager(IRentalsDAL Irentalsdal)
        {
            _Irentalsdal = Irentalsdal;
        }
        [ValidationAspect(typeof(RentalValitador))]
        public IResult Add(Rentals rental)
        {
     
                _Irentalsdal.Add(rental);
                return new SuccessResult();
            
        }

        

        public IResult Delete(Rentals rental)
        {
            _Irentalsdal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_Irentalsdal.GetAll());
        }

        public IDataResult<Rentals> GetById(int rentalid)
        {
            return new SuccessDataResult<Rentals>(_Irentalsdal.Get(r => r.RentalId == rentalid));
        }

        public IResult Update(Rentals rental)
        {
            _Irentalsdal.Update(rental);
            return new SuccessResult();
        }
    }
}
