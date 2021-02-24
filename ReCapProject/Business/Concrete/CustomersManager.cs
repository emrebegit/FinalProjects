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
    public class CustomersManager : ICustomersService
    {
        ICustomersDAL _Icustomersdal;
        public CustomersManager(ICustomersDAL Icustomersdal)
        {
            _Icustomersdal = Icustomersdal;
        }
        [ValidationAspect(typeof(CustomerValidation))]
        public IResult Add(Customers customer)
        {
            _Icustomersdal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customers customer)
        {
            _Icustomersdal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_Icustomersdal.GetAll());
        }

        public IDataResult<Customers> GetById(int customerid)
        {
            return new SuccessDataResult<Customers>(_Icustomersdal.Get(c => c.CustomerId == customerid));
        }

        public IResult Update(Customers customer)
        {
            _Icustomersdal.Update(customer);
            return new SuccessResult();
        }
    }
}
