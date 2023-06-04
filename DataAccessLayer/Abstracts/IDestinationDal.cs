using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
        public List<Destination> GetLast4Destinations();
    } 
}
