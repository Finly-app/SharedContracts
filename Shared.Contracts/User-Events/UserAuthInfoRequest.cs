using System.Collections.Generic;
using System;

public class UserAuthInfoRequest {
    public List<Guid> UserIds { get; set; } = new();
    public string CorrelationId { get; set; } = string.Empty;
    public string ReplyTo { get; set; } = string.Empty;
}
