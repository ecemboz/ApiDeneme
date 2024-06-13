using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstact;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _subscribeService;
        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }
    }
}
