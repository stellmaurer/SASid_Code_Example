using Microsoft.AspNetCore.Mvc;
using UsersAPI.Services;
using UsersAPI.Entities;
using UsersAPI.Models;
using System.Threading.Tasks;

namespace UsersAPI.Controllers
{
     [Route("/")]
     public class UsersController : Controller
     {
          private UsersDbContext _context;
          public UsersController(UsersDbContext context)
          {
               _context = context;
          }

          [Route("")]
          public IActionResult Index()
          {
              return View();
          }

          [Route("users")]
          [HttpGet("{UserID}")]
          public async Task<ActionResult<User>> GetUser(int UserID)
          {
              User user = await _context.Users.FindAsync(UserID);
              if (user == null)
              {
                return NotFound();
              }
              UserProfile userProfile = new UserProfile(user);
              return Ok(userProfile);
          }

          [Route("all")]
          [HttpGet]
          public IActionResult GetUsers()
          {
               return Ok(_context.Users);
          }
     }
}