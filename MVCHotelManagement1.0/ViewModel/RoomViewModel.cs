using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHotelManagement1._0.ViewModel
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }

        [Display(Name = "Room No.")]
        [Required(ErrorMessage = "Room number is required.")]
        public string RoomNumber { get; set; }

        [Display(Name = "Room Image")]

        public string RoomImage { get; set; }

        [Display(Name = "Room Price")]
        [Required(ErrorMessage = "Room Price is required.")]
        [Range(25, 10000, ErrorMessage = "Room price should be equal and greater then {0}")]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Booking Status")]
        [Required(ErrorMessage = "Booking Status is required.")]
        
        public int BookingStatusId { get; set; }    

        [Display(Name = "Room Type")]
        [Required(ErrorMessage = "Room type is required.")]
        public int RoomTypeId { get; set; }

        [Display(Name = "Room Capacity")]
        [Required(ErrorMessage = "Room capacity is required.")]
        [Range(1,8, ErrorMessage = "Room Capacity should be equal and greater then {1}")]
        public int RoomCapacity { get; set; }

        public HttpPostedFileBase Image { get; set; }

        [Display(Name = "Room Description")]
        [Required(ErrorMessage = "Room description is required.")]
        public string RoomDescription { get; set; }

        public List<SelectListItem> ListOfBookingStatus { get; set; }
        public List<SelectListItem> ListOfRoomType { get; set; }
    }
}