public class UserAuthFilterRequest {
    public string CorrelationId { get; set; } = string.Empty;
    public string ReplyTo { get; set; } = string.Empty;
    public string? Filter { get; set; } // "all", "active", or "deactive"
}
