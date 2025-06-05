using System;

public class UserAuthSingleRequest {
    public Guid UserId { get; set; }
    public string CorrelationId { get; set; } = string.Empty;
    public string ReplyTo { get; set; } = string.Empty;
}
