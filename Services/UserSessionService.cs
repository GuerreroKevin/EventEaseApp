using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public RegistrationModel CurrentUser { get; private set; }
        public int RegisteredEventId { get; private set; }

        public void RegisterUser(RegistrationModel user, int eventId)
        {
            CurrentUser = user;
            RegisteredEventId = eventId;
        }

        public bool IsRegistered => CurrentUser != null;
    }
}
