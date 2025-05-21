using Confluent.Kafka;
using System.Linq;
using System.Text;

public static class MessageHelper {
    public static Message<Null, string> CreateHmacMessage(string payload, string secret) {
        var hmac = HmacHelper.ComputeHmac(payload, secret);
        return new Message<Null, string> {
            Value = payload,
            Headers = new Headers { new Header("hmac", Encoding.UTF8.GetBytes(hmac)) }
        };
    }

    public static bool ValidateMessageHmac(ConsumeResult<Ignore, string> message, string secret) {
        var hmacHeader = message.Message.Headers.FirstOrDefault(h => h.Key == "hmac")?.GetValueBytes();
        if (hmacHeader == null) return false;

        var receivedHmac = Encoding.UTF8.GetString(hmacHeader);
        return HmacHelper.ValidateHmac(message.Message.Value, receivedHmac, secret);
    }
}
