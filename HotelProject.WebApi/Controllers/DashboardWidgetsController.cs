using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;

        public DashboardWidgetsController(IStaffService staffService, IRoomService roomService, IAppUserService appUserService, IBookingService bookingService)
        {
            _staffService = staffService;
            _roomService = roomService;
            _appUserService = appUserService;
            _bookingService = bookingService;
        }

        [HttpGet("StaffCount")] //birden fazla metot tanımlayacağımız için metod adını yazıyoruz
        public IActionResult StaffCount()
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }

        [HttpGet("BookingCount")] //birden fazla metot tanımlayacağımız için metod adını yazıyoruz
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }

        [HttpGet("AppUserCount")] //birden fazla metot tanımlayacağımız için metod adını yazıyoruz
        public IActionResult AppUserCount()
        {
            var value = _appUserService.TAppUserCount();
            return Ok(value);
        }

        [HttpGet("RoomCount")] //birden fazla metot tanımlayacağımız için metod adını yazıyoruz
        public IActionResult RoomCount()
        {
            var value = _roomService.TRoomCount();
            return Ok(value);
        }
    }
}
