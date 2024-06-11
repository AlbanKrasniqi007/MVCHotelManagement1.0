using MVCHotelManagement1._0.Models;
using MVCHotelManagement1._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHotelManagement1._0.Controllers
{
    public class BookingController : Controller
    {
        private HotelDbEntities objHotelDbEntities;
        public BookingController()
        {
            objHotelDbEntities = new HotelDbEntities();
        }
        public ActionResult Index()
        {
            BookingViewModel objBookingViewModel = new BookingViewModel();
            objBookingViewModel.ListOfRooms = (from objRoom in objHotelDbEntities.Rooms
                                               where objRoom.BookingStatusId == 2
                                               select new SelectListItem()
                                               {
                                                   Text = objRoom.RoomNumber,
                                                   Value = objRoom.RoomId.ToString()
                                               }
                                               ).ToList();
            return View(objBookingViewModel);
        }

        [HttpPost]
        public ActionResult Index(BookingViewModel objBookingViewModel)
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}