using System;

public class UserCreatedResponse {
    public string CorrelationId { get; set; }
    public Guid UserId { get; set; }
    public string Status { get; set; }
    public string ErrorMessage { get; set; }
}
