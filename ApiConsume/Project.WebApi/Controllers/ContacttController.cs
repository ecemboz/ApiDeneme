using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContacttController : ControllerBase
	{
		private readonly IContactService _contactService;
		public ContacttController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpPost]
		public IActionResult AddContact(EntityLayer.Concrete.Contact contact)
		{
			contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
			_contactService.TInsert(contact);
			return Ok();
		}
	}
}
