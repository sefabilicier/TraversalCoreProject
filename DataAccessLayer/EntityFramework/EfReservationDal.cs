using DataAccessLayer.Abstracts;
using DataAccessLayer.Concretes;
using DataAccessLayer.Repository;
using EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
	{
		public List<Reservation> GetListWithReservationByAccepted(int id)
		{
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
            };
		}

		public List<Reservation> GetListWithReservationByPrevious(int id)
		{
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş rezervasyon" && x.AppUserId == id).ToList();
            }
        }

		public List<Reservation> GetListWithReservationByWaitApproval(int id)
		{
			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay bekliyor" && x.AppUserId == id).ToList();
			}
		}
	}
}
