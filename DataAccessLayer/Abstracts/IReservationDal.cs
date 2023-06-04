using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
	public interface IReservationDal : IGenericDal<Reservation>
	{
		List<Reservation> GetListWithReservationByWaitApproval(int id);
		List<Reservation> GetListWithReservationByAccepted(int id);
		List<Reservation> GetListWithReservationByPrevious(int id);

	}
}
