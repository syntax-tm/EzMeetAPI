using Microsoft.AspNetCore.Mvc;

namespace EzMeetAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SlackController : Controller
{
    [HttpGet("/menu")]
    public string GetScheduleMenu()
    {
        var menuFile = Path.Join(AppDomain.CurrentDomain.BaseDirectory, "resources/ScheduleMenu.txt");
        var menuCode = System.IO.File.ReadAllText(menuFile);

        return menuCode;
    }

    [HttpPost("/schedule")]
    public void Schedule()
    {

    }
}