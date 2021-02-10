using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.BrandId.ToString().Length < 2)
            {
                Console.WriteLine("Your BrandId is not good");
            }
            else if (car.DailyPrice < 0)
            {
                Console.WriteLine("Dailyprice<0");
            }
            else
            {
                _Icardal.Add(car);
            }       
        }

        public void Delete(Car car)
        {
            _Icardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _Icardal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _Icardal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _Icardal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailDto> GetProductDetails()
        {
            return _Icardal.Listofdetails();
        }

        public void Update(Car car)
        {
            _Icardal.Update(car);
        }
    }
}
