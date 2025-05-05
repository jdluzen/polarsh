using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DZen.PolarSh
{
    public class SignatureService
    {
        public bool IsValidSignature(string id, long timestamp, string rawSignature, string secret, string body)
        {
            return rawSignature.Split(' ')
                .Where(s => s.StartsWith("v1"))//symmetric only right now
                .Select(s => s.Substring(2))
                .Any(s => IsValidSignature(body, s, secret));
        }

        //zero downtime
        public bool IsValidSignature(string content, string[] signatures, string secret)
        {
            return signatures.Any(signature => IsValidSignature(content, signature, secret));
        }

        public bool IsValidSignature(string content, string signature, string secret)
        {
            HMAC hMAC = HMACSHA256.Create();
            hMAC.Key = Encoding.UTF8.GetBytes(secret);//not right
            byte[] hash = hMAC.ComputeHash(Encoding.UTF8.GetBytes(content));

            return CryptographicOperations.FixedTimeEquals(hash, Encoding.UTF8.GetBytes(signature));
        }

    }
}
