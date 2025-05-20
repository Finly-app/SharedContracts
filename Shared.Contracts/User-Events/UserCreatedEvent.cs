using System;

public class UserCreatedEvent {
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string CorrelationId { get; set; }
    public string ReplyTo { get; set; }
}