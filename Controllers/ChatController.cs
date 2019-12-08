using System;
using System.Threading.Tasks;
using ChatApp.Database;
using ChatApp.Hubs;
using ChatApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        
        private IHubContext<ChatHub> _chat;

        public ChatController(IHubContext<ChatHub> chat){
            _chat = chat;
        }

        [HttpPost("[action]/{connectionId}/{roomName}")]
        public async Task<IActionResult> JoinRoom(string connectionId, string roomName){
            await _chat.Groups.AddToGroupAsync(connectionId, roomName);
            return Ok();
        }

        [HttpPost("[action]/{connectionId}/{roomName}")]
        public async Task<IActionResult> LeaveRoom(string connectionId, string roomName){
            await _chat.Groups.RemoveFromGroupAsync(connectionId, roomName);
            return Ok();
        }

        public async Task<IActionResult> SendMessage(int chatId, string message, string roomName, [FromServices] AppDbContext _context)
        {
            var mess = new Message {
                ChatId = chatId,
                Text = message,
                Name = User.Identity.Name,
                Timestamp = DateTime.Now
            };
            _context.Messages.Add(mess);
            await _context.SaveChangesAsync();
            await _chat.Clients.Group(roomName).SendAsync("RecieveMessage", message);
            return Ok();
        }
    }
}