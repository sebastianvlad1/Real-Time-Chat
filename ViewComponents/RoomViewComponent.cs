using System.Linq;
using ChatApp.Database;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.ViewComponents{

    public class RoomViewComponent: ViewComponent
    {
        private AppDbContext _context;

        public RoomViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var chats = _context.Chats.ToList();
            return View(chats);
        }
    }
}