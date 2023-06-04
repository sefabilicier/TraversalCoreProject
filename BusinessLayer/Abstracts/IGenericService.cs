using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IGenericService<T>
    {
        void TAdd(T t);   
        void TRemove(T t);
        void TUpdate(T t);
        List<T> TGetList(); //return etmeli o yüzden list
        T TGetById(int id); //ıd türünde getireceğim bir method

        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}


//business a gelmeden önce business tarafından tanımlayacağım bütün methodlar buradan generic servisten geçecek ondan sonra business da concrete gelecek