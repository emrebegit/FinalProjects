using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{/*
    public class InMemoryCarDAL : ICarDAL
    {
        List<Car> cars;
        List<Car> BrandIds;
        public InMemoryCarDAL()
        {
            cars = new List<Car>
            {
                new Car
                {
                    CarId=1,
                    BrandId=1,
                    Brand="Toyota",
                    DailyPrice=200,
                    ModelYear=2014,
                    Desc="Clear and From Teacher"
                },
                new Car
                {
                    CarId=2,
                    BrandId=1,
                    Brand="Toyota",
                    DailyPrice=250,
                    ModelYear=2016,
                    Desc="Clear and very performance"
                },
                new Car
                {
                    CarId=3,
                    BrandId=2,
                    Brand="Ford",
                    DailyPrice=300,
                    ModelYear=2018,
                    Desc="American and high speed"
                },
                new Car
                {
                    CarId=4,
                    BrandId=3,
                    Brand="Subaru",
                    DailyPrice=500,
                    ModelYear=2004,
                    Desc="This is on earth star from sky"
                }
            };       
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cardelete = cars.SingleOrDefault(c => c.CarId == car.CarId);
            cars.Remove(cardelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<int> GetByBrandIds()
        {
            List<int> BrandIds = new List<int>();
            foreach (var item in cars)
            {
                BrandIds.Add(item.BrandId); 
            }
            return BrandIds;
        }

        public void Update(Car car)
        {
            Car carupdate = cars.SingleOrDefault(c => c.CarId == car.CarId);
            carupdate.CarId = car.CarId;
            carupdate.BrandId = car.BrandId;
            carupdate.Brand = car.Brand;
            carupdate.DailyPrice = car.DailyPrice;
            carupdate.Desc = car.Desc;
        }
        public List<Car> GetByBrandId(int categoryid)
        {
            return cars.Where(c => c.BrandId == categoryid).ToList();
        }
    }*/
}
