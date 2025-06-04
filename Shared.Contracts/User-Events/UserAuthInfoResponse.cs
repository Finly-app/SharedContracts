using System.Collections.Generic;

public class UserAuthInfoResponse {
    public string CorrelationId { get; set; } = string.Empty;
    public List<UserAuthInfo> Users { get; set; } = new();
}