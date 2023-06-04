using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
	public class ReservationManager : IReservationService
	{

		IReservationDal _reservationDal;
		public ReservationManager(IReservationDal reservationDal)
		{
			_reservationDal = reservationDal;
		}

		public List<Reservation> GetListWithReservationByAccepted(int id)
		{
			return _reservationDal.GetListWithReservationByAccepted(id);
		}

		public List<Reservation> GetListWithReservationByPrevious(int id)
		{
			return _reservationDal.GetListWithReservationByPrevious(id);
		}

		public List<Reservation> GetListWithReservationByWaitApproval(int id)
		{
			return _reservationDal.GetListWithReservationByWaitApproval(id);
		}

		public void TAdd(Reservation t)
		{
			_reservationDal.Insert(t);
		}

		public Reservation TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Reservation> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TRemove(Reservation t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Reservation t)
		{
			throw new NotImplementedException();
		}
	}
}
