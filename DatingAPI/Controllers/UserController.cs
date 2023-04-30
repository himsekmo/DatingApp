using DatingAPI.Data;
using Microsoft.AspNetCore.Mvc;
namespace DatingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly DatingAppDataContext _data;

        public UserController(ILogger<UserController> logger, DatingAppDataContext data)
        {
            _logger = logger;
            _data = data;
        }

        public ActionResult<IEnumerable<AppUser>> Users()
        {
            var user =  _data.AppUsers.ToList();
            _logger.Log(LogLevel.Warning,"This is get request");
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _data.AppUsers.FindAsync(id);
        }
    }
}