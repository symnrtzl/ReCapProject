using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        IResult Delete(User user);
        IResult Update(User user);
        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        User GetByMail(string email);
    }
}
