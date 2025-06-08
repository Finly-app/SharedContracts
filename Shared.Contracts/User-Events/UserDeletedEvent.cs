using System;

public class UserDeletedEvent {
    public Guid UserId { get; set; }
    public string CorrelationId { get; set; }
    public string ReplyTo { get; set; }
}