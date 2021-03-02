using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AcessToken CreateToken(User user, List<OperationClaim> operationClaims);
        
    }
}
