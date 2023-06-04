using DataAccessLayer.Abstracts;
using DataAccessLayer.Repository;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public void Delete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetListByFilter(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
