using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager(new InMemoryProductDal());
            foreach (var item in manager.GetAll())
            {
                Console.WriteLine(item.ProductId);
            }
            Console.ReadLine();
        }
    }
}
