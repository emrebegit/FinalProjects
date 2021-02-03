using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

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
            _Icardal.Add(car);         
        }

        public void Delete(Car car)
        {
            _Icardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _Icardal.GetAll();
        }

        public List<int> GetByBrandIds()
        {
            return _Icardal.GetByBrandIds();
        }

        public void Update(Car car)
        {
            _Icardal.Update(car);
        }
    }
}
