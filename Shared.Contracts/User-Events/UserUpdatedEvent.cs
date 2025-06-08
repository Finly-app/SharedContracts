using System;

public class UserUpdatedEvent {
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string CorrelationId { get; set; }
    public string ReplyTo { get; set; }
}
