using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
	[Area("Member")]
	public class ReservationController : Controller
	{
		DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

		ReservationManager reservationManager = new ReservationManager(new EfReservationDal());


		private readonly UserManager<AppUser> _userManager;

		public ReservationController(DestinationManager destinationManager, ReservationManager reservationManager)
		{
			this.destinationManager = destinationManager;
			this.reservationManager = reservationManager;
		}

		public ReservationController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> MyCurrentReservation()
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }

		public async Task<IActionResult> MyOldReservationAsync()
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }

		[HttpGet]
		public IActionResult NewReservation()
		{
			List<SelectListItem> values = (from x in destinationManager.TGetList()
										   select new SelectListItem
										   {
											   Text = x.City,
											   Value = x.DestinationID.ToString()
										   }).ToList();


			ViewBag.v = values; //valuesa gelen değerleri views a taşı
			return View();
		}

		[HttpPost]
		public IActionResult NewReservation(Reservation reservation)
		{
			reservation.AppUserId = 1;
			reservation.Status = "Pending...";
			reservationManager.TAdd(reservation);
			return RedirectToAction("MyCurrentReservation");
		}




		public async Task<IActionResult> MyApprovalReservation()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			//ViewBag.v = values.Id; //bu frontend ile ilişkili bunu oraya yazarak id yi UI ya taşıyacağız
			var valuesList = reservationManager.GetListWithReservationByWaitApproval(values.Id);
			return View(valuesList);
		}

	}

}
