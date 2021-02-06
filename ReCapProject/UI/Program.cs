using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager crmng = new CarManager(new EfCarDAL());
            List<Car> cars=crmng.GetAll();
            foreach (var item in cars)
            {
                Console.WriteLine(item.CarId);
                Console.WriteLine(item.BrandId);
                Console.WriteLine(item.ColorId);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine(item.CarDesc);
            }
            string value="H";
            do
            {
                Console.WriteLine("Press 1 add Car" );
                Console.WriteLine("Press 2 delete Car");
                Console.WriteLine("Update press 3 ");
                Console.WriteLine("Press E for exit");
                value = Console.ReadLine();
                if (value == "1")
                {
                    Console.WriteLine("(int)(len>2)Id:");
                    int CarId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)BrandId:");
                    eint BrandId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)ColorId:");
                    int ColorId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)ModelYear:");
                    int ModelYear1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(Decimal)DailyPrice:");
                    int DailyPrice1 = (int)Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("(string)Desc:");
                    string CarDesc1= Console.ReadLine();
                    Car car1 = new Car();
                    car1 = new Car()
                    {
                        CarId = CarId1,
                        CarDesc = CarDesc1,
                        BrandId=BrandId1,
                        ColorId=ColorId1,
                        ModelYear=ModelYear1,
                        DailyPrice=DailyPrice1,           
                    };
                    crmng.Add(car1);
                }
                else if (value == "2")
                {
                    Console.WriteLine("(int)(len>2)Id:");
                    int CarId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)BrandId:");
                    int BrandId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)ColorId:");
                    int ColorId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)ModelYear:");
                    int ModelYear1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(Decimal)DailyPrice:");
                    int DailyPrice1 = (int)Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("(string)Desc:");
                    string CarDesc1 = Console.ReadLine();
                    Car car1 = new Car();
                    car1 = new Car()
                    {
                        CarId = CarId1,
                        CarDesc = CarDesc1,
                        BrandId = BrandId1,
                        ColorId = ColorId1,
                        ModelYear = ModelYear1,
                        DailyPrice = DailyPrice1,
                    };
                    crmng.Delete(car1);
                }
                else if (value=="3")
                {
                    Console.WriteLine("(int)(len>2)Id:");
                    int CarId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)BrandId:");
                    int BrandId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)ColorId:");
                    int ColorId1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(int)ModelYear:");
                    int ModelYear1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("(Decimal)DailyPrice:");
                    int DailyPrice1 = (int)Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("(string)Desc:");
                    string CarDesc1 = Console.ReadLine();
                    Car car1 = new Car();
                    car1 = new Car()
                    {
                        CarId = CarId1,
                        CarDesc = CarDesc1,
                        BrandId = BrandId1,
                        ColorId = ColorId1,
                        ModelYear = ModelYear1,
                        DailyPrice = DailyPrice1,
                    };
                    crmng.Update(car1);
                }
            } while (value=="E");
            Console.WriteLine("GetByBrandId");
            List<Car> GetbyBrandid=crmng.GetCarsByBrandId(2);
            foreach (var item in GetbyBrandid)
            {
                Console.WriteLine(item.CarId);
                Console.WriteLine(item.BrandId);
                Console.WriteLine(item.ColorId);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine(item.CarDesc);
            }
            Console.WriteLine("GetByColorId");
            List<Car> GetByColorId = crmng.GetCarsByColorId(2);
            foreach (var item in GetByColorId)
            {
                Console.WriteLine(item.CarId);
                Console.WriteLine(item.BrandId);
                Console.WriteLine(item.ColorId);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine(item.CarDesc);
            }
            Console.ReadLine();
        }
    }
}
