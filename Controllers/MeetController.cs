using EzMeetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using SlackBotMessages.Models;

namespace EzMeetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetController : ControllerBase
    {
        private readonly ILogger<MeetController> _logger;

        public MeetController(ILogger<MeetController> logger)
        {
            _logger = logger;
        }

        [HttpPost(nameof(CreateEvent))]
        public Message CreateEvent([FromForm] SlackCommand command)
        {
            var message = new Message();
            var attach = new Attachment();
            
            var props = command.GetType().GetProperties();

            foreach (var prop in props)
            {
                var propValue = prop.GetValue(command) as string;
                attach.AddField(prop.Name, propValue);
            }

            return message;
        }
    }
}