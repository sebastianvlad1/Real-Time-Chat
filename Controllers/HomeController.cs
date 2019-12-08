using System.Threading.Tasks;
using ChatApp.Database;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context){
            _context = context;
        }
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name){

            _context.Add(new Chat {
                Name = name,
                Type = ChatType.Room
            });

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}