using DataAccessLayer.Abstracts;
using DataAccessLayer.Repository;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}

//ben yarın öbür gün gidip sadece entity me bağlı metod tanımlayabilirim bunun imzasını gidip o entity interfaceinde vereceğim o yüzden IAboutDal ekledik
