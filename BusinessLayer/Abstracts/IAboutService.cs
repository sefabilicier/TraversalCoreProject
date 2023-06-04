using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IAboutService : IGenericService<About>
    {
    }
}

//Generice bağlayabiliriz ama ileride buna özel methodlar yazarsam bu beş taaneden hariç o zaman ilgili entityService tanımlamaız gerekecek