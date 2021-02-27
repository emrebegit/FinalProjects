using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDAL _ICarImagesDAL;
        public CarImagesManager(ICarImagesDAL ICarImagesDAL)
        {
            _ICarImagesDAL = ICarImagesDAL;
        }
        
        public IResult Add(CarImages item)
        {
            throw new NotImplementedException();
        }
        public IResult Update(CarImages item)
        {
            throw new NotImplementedException();
        }
        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult AddImage(IFormFile file, CarImages carImages)
        {
            IResult result = BusinessRules.Run(CheckLimitOfImages(carImages.CarId));
            if (result!=null)
            {
                return result;
            }
            carImages.ImagePath = FileHelper.Add(file);
            carImages.Date = DateTime.Now;
            _ICarImagesDAL.Add(carImages);
            return new SuccessResult(Messages.ImagesAdded);
        }
        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Delete(CarImages item)
        {
            IResult result = BusinessRules.Run(CheckDelete(item));
            if (result != null)
            {
                return result;
            }
            _ICarImagesDAL.Delete(item);
            return new SuccessResult(Messages.ImagesDeleted);
        }
       
        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_ICarImagesDAL.GetAll());
        }

        public IDataResult<CarImages> GetById(int id)
        {
            return new SuccessDataResult<CarImages>(_ICarImagesDAL.Get(i => i.Id == id));
        }
        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult UpdateImage(IFormFile file, CarImages carImages)
        {
            carImages.ImagePath = FileHelper.Update(_ICarImagesDAL.Get(i => i.CarId == carImages.CarId).ImagePath, file);
            carImages.Date = DateTime.Now;
            _ICarImagesDAL.Update(carImages);
            return new SuccessResult();
        }
        [ValidationAspect(typeof(CarImagesValidator))]
        public IDataResult<List<CarImages>> CheckNullImage(int id)
        {
            return new SuccessDataResult<List<CarImages>>(CheckNullImageFunc(id));
        }

        private IResult CheckLimitOfImages(int id)
        {
            var imagecount = _ICarImagesDAL.GetAll(c => c.CarId == id).Count;
            if (imagecount > 5)
            {
                return new ErrorResult(Messages.LimitOfImages);
            }
            return new SuccessResult();
        }
        private IResult CheckDelete(CarImages carImages)
        {
            try
            {
                FileHelper.Delete(carImages.ImagePath);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.BadDeleteOperations);
            }
            return new SuccessResult(Messages.ImagesDeleted);
        }
        

        private List<CarImages> CheckNullImageFunc(int id)
        {
            string path = @"\Images\logo.jpg";
            var result = _ICarImagesDAL.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                return new List<CarImages> { new CarImages { CarId = id, ImagePath = path, Date = DateTime.Now } };
            }
            return _ICarImagesDAL.GetAll(p => p.CarId == id);
        }
    }
}
