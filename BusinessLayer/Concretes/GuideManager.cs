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
    public class GuideManager : IGuideService
    {

        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void ChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void ChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);   
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TRemove(Guide t)
        {
            _guideDal.Delete(t);
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);    
        }
    }
}
