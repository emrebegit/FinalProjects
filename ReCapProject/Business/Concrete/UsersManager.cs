using Business.Abstract;
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
    public class UsersManager : IUsersService
    {
        IUsersDAL _Iusersdal;
        public UsersManager(IUsersDAL Userdal)
        {
            _Iusersdal = Userdal;
        }
        [ValidationAspect(typeof(UserValidation))]
        public IResult Add(Users user)
        {
            _Iusersdal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(Users user)
        {
            _Iusersdal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_Iusersdal.GetAll());
        }

        public IDataResult<Users> GetById(int userid)
        {
            return new SuccessDataResult<Users>(_Iusersdal.Get(u => u.UserId == userid));
        }

        public IResult Update(Users user)
        {
            _Iusersdal.Update(user);
            return new SuccessResult();
        }
    }
}
