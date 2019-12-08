using System;
using System.Security.Claims;
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

        [HttpPost("[action]/{connectionId}/{roomId}")]
        public async Task<IActionResult> JoinRoom(int id, string connectionId, string roomId, [FromServices] AppDbContext _context){
            await _chat.Groups.AddToGroupAsync(connectionId, roomId);
            return Ok();
        }
        [HttpPost("[action]/{connectionId}/{roomId}")]
        public async Task<IActionResult> LeaveRoom(string connectionId, string roomId){
            await _chat.Groups.RemoveFromGroupAsync(connectionId, roomId);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SendMessage(int roomId, string message, [FromServices] AppDbContext _context)
        {
            var mess = new Message {
                ChatId = roomId,
                Text = message,
                Name = User.Identity.Name,
                Timestamp = DateTime.Now
            };
            _context.Messages.Add(mess);
            await _context.SaveChangesAsync();
            await _chat.Clients.Group(roomId.ToString()).SendAsync("RecieveMessage", new {
                Text = mess.Text,
                Name = mess.Name,
                Timestamp = mess.Timestamp.ToString("M/d/yyyy h:mm:ss tt")
            });
            return Ok();
        }
    }
}