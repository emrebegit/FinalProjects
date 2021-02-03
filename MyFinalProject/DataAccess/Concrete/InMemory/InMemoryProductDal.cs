using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDAL
    {
        List<Product> products;
        public InMemoryProductDal()
        {
            products = new List<Product>
            {
                new Product{
                ProductId=1,
                CategoryId=1,
                ProductName="Msi-Laptop",
                UnitInStock=25,
                UnitPrice=8000},
                  new Product{
                ProductId=2,
                CategoryId=2,
                ProductName="Bardak",
                UnitInStock=10,
                UnitPrice=10},
                    new Product{
                ProductId=3,
                CategoryId=1,
                ProductName="Klavye",
                UnitInStock=50,
                UnitPrice=50},
                      new Product{
                ProductId=4,
                CategoryId=1,
                ProductName="Mouse",
                UnitInStock=60,
                UnitPrice=80},
                        new Product{
                ProductId=5,
                CategoryId=1,
                ProductName="Ekran",
                UnitInStock=15,
                UnitPrice=2000},
            };

        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(Product product)
        {
            Product producttodelete = products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            products.Remove(producttodelete);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void Update(Product product)
        {
            Product producttupdate = products.SingleOrDefault(p => p.ProductId == product.ProductId);
            producttupdate.ProductName = product.ProductName;
            producttupdate.ProductId = product.ProductId;
            producttupdate.UnitPrice = product.UnitPrice;
            producttupdate.UnitInStock = product.UnitInStock;
            producttupdate.CategoryId = product.CategoryId;
        }
        

   
        List<Product> IProductDAL.GetCategoryId(int categoryid)
        {
            return products.Where(p => p.CategoryId == categoryid).ToList();
        }
    }
}
