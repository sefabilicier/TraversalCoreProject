using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IContactUsService : IGenericService<ContactUs>
    {
        List<ContactUs> TGetListContactByTrue();
        List<ContactUs> TGetListContactByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
