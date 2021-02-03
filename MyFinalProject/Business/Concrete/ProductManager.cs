using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _Iproductdal;
        public ProductManager(IProductDAL productDAL)
        {
            _Iproductdal = productDAL;
        }
        public List<Product> GetAll()
        {
            return _Iproductdal.GetAll();
        }
    }
}
