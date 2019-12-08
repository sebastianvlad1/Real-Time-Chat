using System;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Database;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Controllers{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context){
            _context = context;
        }
        public IActionResult Index() => View();

        [HttpGet("{id}")]
        public IActionResult Chat(int id) {
            var chat = _context.Chats
            .Include(x => x.Messages)
            .FirstOrDefault(x => x.Id == id);
            return View(chat);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateMessage(int chatId, string message){

            var mess = new Message {
                ChatId = chatId,
                Text = message,
                Name = "Default",
                Timestamp = DateTime.Now
            };
            _context.Messages.Add(mess);
            await _context.SaveChangesAsync();
            return RedirectToAction("Chat", new { id = chatId});
        }

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