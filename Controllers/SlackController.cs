using Microsoft.AspNetCore.Mvc;

namespace EzMeetAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SlackController : Controller
{
    [HttpGet]
    public string GetScheduleMenu()
    {
        return null;
    }

    [HttpPost]
    public void CalendarItem()
    {

    }
}