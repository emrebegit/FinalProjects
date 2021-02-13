using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _Icardal;
        public CarManager(ICarDAL icardal)
        {
            _Icardal = icardal;
        }

        public IResult Add(Car car)
        {
            if (car.BrandId.ToString().Length < 2)
            {
                Console.WriteLine("Your BrandId is not good");
                return new ErrorResult(Messages.CarNameInvalit);
                
            }
            else if (car.DailyPrice < 0)
            {
                Console.WriteLine("Dailyprice<0");
                return new ErrorResult(Messages.CarDailyPrice);
                
            }
            else
            {
                _Icardal.Add(car);
                return new SuccessResult();
                
            }       
        }

        public IResult Delete(Car car)
        {
            _Icardal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_Icardal.GetAll());
            
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_Icardal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_Icardal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_Icardal.Listofdetails());
        }

        public IResult Update(Car car)
        {
            _Icardal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
