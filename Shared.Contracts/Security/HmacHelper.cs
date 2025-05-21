using System.Security.Cryptography;
using System.Text;
using System;

public static class HmacHelper {
    public static string ComputeHmac(string message, string secret) {
        var keyBytes = Encoding.UTF8.GetBytes(secret);
        var messageBytes = Encoding.UTF8.GetBytes(message);

        using var hmac = new HMACSHA256(keyBytes);
        var hash = hmac.ComputeHash(messageBytes);
        return Convert.ToBase64String(hash);
    }

    public static bool ValidateHmac(string message, string receivedHmac, string secret) {
        var computed = ComputeHmac(message, secret);
        return computed == receivedHmac;
    }
}
