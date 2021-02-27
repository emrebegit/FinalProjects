using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImagesService:IOperations<CarImages>
    {
        IResult AddImage(IFormFile file, CarImages carImages);
        IResult UpdateImage(IFormFile file, CarImages carImages);
        IDataResult<List<CarImages>> CheckNullImage(int id);
    }
}
