using System.Collections.Generic;
using System;

public class UserAuthInfo {
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public bool Active { get; set; }
}
