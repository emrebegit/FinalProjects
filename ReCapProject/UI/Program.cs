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
            GoCarRent();
            AddCustomer();
            ListwithJoin();
            PrintColorIds();
            PrintBrandIds();
            CarmngOld();
            Console.ReadLine();

        }

        private static void GoCarRent()
        {
            RentalsManager rentalmanager = new RentalsManager(new EfRentalsDAL());
            Console.WriteLine("(int)RentalId:");
            int RentalId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(int)CarId:");
            int CarId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(int)CustomerId:");
            int CustomerId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(DateTime)RentDate:");
            DateTime RentDate1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("(DateTime)ReturnDate:");
            DateTime ReturnDate1 = Convert.ToDateTime(Console.ReadLine());
            Rentals rental1 = new Rentals();
            rental1 = new Rentals()
            {
                RentalId = RentalId1,
                CarId = CarId1,
                CustomerId = CustomerId1,
                RentDate = RentDate1,
                ReturnDate = ReturnDate1
            };
        }

        private static void AddCustomer()
        {
            CustomersManager customermanager = new CustomersManager(new EfCustomersDAL());
            Console.WriteLine("(int)CustomerId:");
            int CustomerId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(int)UserId:");
            int UserId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(String)CompanyName:");
            string CompanyName1 = Console.ReadLine();
            Customers customer1 = new Customers();
            customer1 = new Customers()
            {
                CustomerId = CustomerId1,
                UserId = UserId1,
                CompanyName = CompanyName1
            };
            customermanager.Add(customer1);
        }

        private static void PrintBrandIds()
        {
            BrandManager brandmanager = new BrandManager(new EfBrandDAL());
            foreach (var item in brandmanager.GetAll().Data)
            {
                Console.WriteLine(item.BrandId);
            }
        }

        private static void PrintColorIds()
        {
            ColorManager colormanager = new ColorManager(new EfColorDAL());
            foreach (var item in colormanager.GetAll().Data)
            {
                Console.WriteLine(item.ColorId);
            }
        }

        private static void ListwithJoin()
        {
            CarManager crmng = new CarManager(new EfCarDAL());
            foreach (var item in crmng.GetProductDetails().Data)
            {
                Console.WriteLine("CarId:" + item.CarId + "\n " +
                    "BrandId:" + item.BrandId +
                    "\n BrandName:" + item.BrandName +
                    "\n ColorId:" + item.ColorId +
                    "\n ColorName:" + item.ColorName +
                    "\n DailyPrice:" + item.DailyPrice);
            }
        }

        private static void CarmngOld()
        {
            CarManager crmng = new CarManager(new EfCarDAL());
            List<Car> cars = crmng.GetAll().Data;
            foreach (var item in cars)
            {
                Console.WriteLine(item.CarId);
                Console.WriteLine(item.BrandId);
                Console.WriteLine(item.ColorId);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine(item.CarDesc);
            }
            string value = "H";
            do
            {
                Console.WriteLine("Press 1 add Car");
                Console.WriteLine("Press 2 delete Car");
                Console.WriteLine("Update press 3 ");
                Console.WriteLine("Press E for exit");
                value = Console.ReadLine();
                if (value == "1")
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
                else if (value == "3")
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
            } while (value == "E");
            Console.WriteLine("GetByBrandId");
            List<Car> GetbyBrandid = crmng.GetCarsByBrandId(2).Data;
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
            List<Car> GetByColorId = crmng.GetCarsByColorId(2).Data;
            foreach (var item in GetByColorId)
            {
                Console.WriteLine(item.CarId);
                Console.WriteLine(item.BrandId);
                Console.WriteLine(item.ColorId);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine(item.ModelYear);
                Console.WriteLine(item.CarDesc);
            }
        }
    }
}
