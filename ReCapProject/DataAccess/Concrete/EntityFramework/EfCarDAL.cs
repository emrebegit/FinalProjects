using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDAL : EfEntityRepositoryBase<Car, CarProjectContext>, ICarDAL
    {
        public List<CarDetailDto> Listofdetails()
        {
          using(CarProjectContext context=new CarProjectContext())
            {
                var result = from c in context.Car
                             join b in context.Brand on c.BrandId equals b.BrandId
                             join co in context.Color on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId=c.CarId,
                                 DailyPrice=c.DailyPrice,
                                 ColorId=c.ColorId,
                                 ColorName=co.ColorName,
                                 BrandId=c.BrandId,
                                 BrandName=b.BrandName
                             };
                return result.ToList();
            }
        }
    }
}
