using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet]
        [Route("getAllLists")]
        public string GetAllTrackingList()
        {
            return "getAllLists";
        }
    }
}
