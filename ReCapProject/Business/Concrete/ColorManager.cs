using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDAL _icolordal;
        public ColorManager(IColorDAL _icolordal1)
        {
            _icolordal = _icolordal1;
        }
        [SecuredOperation("color.add,admin")]
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            _icolordal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
            
        }

        public IResult Delete(Color color)
        {
            _icolordal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
            
        }

        public IDataResult<List<Color>> GetAll()
        {
            
            return new SuccessDataResult<List<Color>>(_icolordal.GetAll());
        }

        public IDataResult<Color> GetById(int colorid)
        {
            return new SuccessDataResult<Color>( _icolordal.Get(c => c.ColorId == colorid),Messages.ColorListed);
        }

        public IResult Update(Color color)
        {
            _icolordal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
            
        }
    }
}
