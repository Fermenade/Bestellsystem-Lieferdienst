using System.Security.Cryptography;
using System.Text;

namespace Bestellsystem_Lieferdienst.BL
{
    public static class StringExtensions
    {
        public static string ToSHA256(this string input)
        {
            // generated
            SHA256 sha = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha.ComputeHash(bytes);

            StringBuilder output = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
                output.AppendFormat("{0:x2}", b); // Convert each byte to a string and append to the formatter

            return output.ToString();
        }
    }
}
