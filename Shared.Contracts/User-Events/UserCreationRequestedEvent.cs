using System;

namespace Shared.Contracts.Events {
    public class UserCreationRequestedEvent {
        public Guid TempId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}