using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager crmng = new CarManager(new InMemoryCarDAL());
            foreach (var item in crmng.GetAll())
            {
                Console.WriteLine(item.CarId);
            }
            Car car1;
            car1 = new Car
            {
                CarId = 5,
                BrandId = 1,
                Brand = "Toyota",
                DailyPrice = 300,
                ModelYear = 2005,
                Desc = "This car addedd!(new)"
            };
            crmng.Add(car1);
            Console.WriteLine("--------------");
            foreach (var item in crmng.GetAll())
            {
                Console.WriteLine(item.CarId);
            }
            Console.WriteLine("This car is added!!");
            Car car2;
            car2 = new Car
            {
                CarId = 5,
                BrandId = 1,
                Brand = "Toyota",
                DailyPrice = 250,
                ModelYear = 2004,
                Desc = "This car updated!(new)"
            };
            Console.WriteLine("This car updated!!");
            crmng.Update(car2);
            foreach (var item in crmng.GetAll())
            {
                Console.WriteLine(item.CarId);
                Console.WriteLine(item.Desc);
            }
            Console.WriteLine("--------------");
            crmng.Delete(car1);
            foreach (var item in crmng.GetAll())
            {
                Console.WriteLine(item.CarId);
            }
            Console.WriteLine("This car is deleted!!");
            Console.WriteLine("BrandIds");
            List<int> brnids = crmng.GetByBrandIds();
            foreach (var item in brnids)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
