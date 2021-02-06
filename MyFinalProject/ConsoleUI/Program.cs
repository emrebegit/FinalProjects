using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager(new EfProductDAL());
            foreach (var item in manager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("-----------");
            foreach (var item in manager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadLine();
            
        }
    }
}
