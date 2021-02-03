using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string Brand { get; set; }
        public int ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Desc { get; set; }

    }
}
