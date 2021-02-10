using Business.Abstract;
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
        public void Add(Color color)
        {
            _icolordal.Add(color);
        }

        public void Delete(Color color)
        {
            _icolordal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _icolordal.GetAll();
        }

        public Color GetById(int colorid)
        {
            return _icolordal.Get(c => c.ColorId == colorid);
        }

        public void Update(Color color)
        {
            _icolordal.Update(color);
        }
    }
}
