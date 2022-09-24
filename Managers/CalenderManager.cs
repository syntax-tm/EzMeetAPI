using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Discovery;
using Google.Apis.Services;
using Microsoft.AspNetCore.Http.Connections;

namespace EzMeetAPI.Managers
{
    public class CalenderManager
    {
        //Temp variables to replace with db
        public static UserCredential token;
        private string calID = "primary";
        private string eventID = "1";

        public void createEvent()
        {
            //TODO
        }

        public void suggestEvent()
        {
            //TODO
        }

        public Events getBookings()
        {
            //TODO
            Calendar service = new Calendar();
            Events events = new Events();

            return null;
        }
    }
}
