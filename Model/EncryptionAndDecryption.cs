using System.Text;
using System.Security.Cryptography;

namespace Model
{
    public  static class EncryptionAndDecryption
    {
        private static readonly string Key = "My32CharLongEncryptionKey";
        private static readonly string IV = "My16CharIVString";

        public static byte[] GetValidKey(string key)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            }
        }

        public static string Encrypt(string text)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = GetValidKey(Key);
                aes.IV = Encoding.UTF8.GetBytes(IV);
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    sw.Write(text);
                    sw.Flush();
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
        public static string Decrypt(string text)
        {
            byte[] buffer = Convert.FromBase64String(text);
            using (Aes aes = Aes.Create())
            {
                //aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.Key = GetValidKey(Key);
                aes.IV = Encoding.UTF8.GetBytes(IV);
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
