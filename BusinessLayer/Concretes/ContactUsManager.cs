using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactByFalse()
        {
            return _contactUsDal.GetListContactByFalse();
        }

        public List<ContactUs> GetListContactByTrue()
        {
            return _contactUsDal.GetListContactByTrue();
        }

        public void TAdd(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetListContactByFalse()
        {
            return _contactUsDal.GetListContactByFalse();
        }

        public List<ContactUs> TGetListContactByTrue()
        {
            return _contactUsDal.GetListContactByTrue();
        }

        public void TRemove(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
