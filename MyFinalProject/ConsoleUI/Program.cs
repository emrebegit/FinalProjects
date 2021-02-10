using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            CategoryTest();
            Console.ReadLine();

        }

        private static void CategoryTest()
        {
            CategoryManager categorymanager = new CategoryManager(new EfCategoryDAL());
            foreach (var item in categorymanager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager manager = new ProductManager(new EfProductDAL());
            foreach (var item in manager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("-----------");
            foreach (var item in manager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+"/"+item.CategoryName);
            }
        }
    }
}
