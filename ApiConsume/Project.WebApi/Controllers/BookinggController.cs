using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;
using Project.BusinessLayer.Abstact;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookinggController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookinggController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            booking.Description = booking.Description ?? string.Empty;
            booking.CheckIn = booking.CheckIn.Date;
            booking.CheckOut = booking.CheckOut.Date;
			_bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut("aaaaa")]
        public IActionResult aaaaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }

        [HttpPut("bbbbb")]
        public IActionResult bbbbb(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }

        [HttpGet("BookingApproved")]
        public IActionResult BookingApproved(int id)
        {
            _bookingService.TBookingStatusChangeApproved3(id);
            return Ok(); 
        }

        [HttpGet("BookingCancel")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }

        [HttpGet("BookingWait")]
        public IActionResult BookingWait(int id)
        {
            _bookingService.TBookingStatusChangeWait(id);
            return Ok();
        }
    }
}
