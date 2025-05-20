using System;

namespace Shared.Contracts.Events {
    public class UserCreationConfirmedEvent {
        public Guid TempId { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
