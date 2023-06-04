using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IGenericDal<T>
    {
        void Insert(T t);    
        void Update(T t);    
        void Delete(T t);
        List<T> GetList();


        T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
//lambda expresssion -> bunun sayesinde managerda şartımızı yazabiliyoruz

//entityleri T diye varsaydık