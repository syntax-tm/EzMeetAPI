using EzMeetAPI.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
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

        [HttpPost(nameof(Authenticate))]
        public async void Authenticate()
        {
            UserCredential credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    // TODO: NEED REAL DEAL HERE
                    ClientId = "ID",
                    ClientSecret = "SECRET"
                },
                new[] { CalendarService.Scope.CalendarReadonly, CalendarService.Scope.CalendarEvents },
                "user",
                CancellationToken.None);

            // Create the service
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "EzMeet",
            });
        }
    }
}