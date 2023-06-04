using DataAccessLayer.Abstracts.UowDal;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts.AbstractUoNow
{
    public interface IAccountService : IGenericUowService<Account>
    {

    }
}
