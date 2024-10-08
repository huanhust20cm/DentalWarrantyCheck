using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CryptographyUtility
    {
        public const string AESKey = "Rhombicosidodecahedron";
        public const string AESIV = "sR9pF3eXqW2oD7zL";

        //using AES  Encrypt
        public static string EncryptPlainTextToBase64UsingAESGCM(string plainText, string keyString, string aesIV)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            byte[] value = Encoding.UTF8.GetBytes(plainText);
            byte[] nonce = Encoding.UTF8.GetBytes(aesIV);
            return EncryptString_AES(plainText, key, nonce);
        }
        public static string EncryptString_AES(string plainText, byte[] key, byte[] IV)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (key == null || key.Length == 0) throw new ArgumentNullException(nameof(key));
            if (IV == null) throw new ArgumentNullException(nameof(IV));
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncypt = new StreamWriter(csEncrypt))
                        {
                            swEncypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }
        public static string DecyptStringFromBase64StringUsingAESGCM(string cipherTextinBase64, string keyString, string aesIV)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            byte[] value = Convert.FromBase64String(cipherTextinBase64);
            byte[] nonce = Encoding.UTF8.GetBytes(aesIV);

            return DecryptString_AES(value, key, nonce);
        }
      
        public static string DecryptString_AES(byte[] cipherText, byte[] key, byte[] IV)
        {
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (IV == null) throw new ArgumentNullException(nameof(IV));
            string plainText = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecypt = new StreamReader(csDecrypt))
                        {

                            plainText = srDecypt.ReadToEnd();
                        }
                    }

                }
            }
            return plainText;
        }
        public static string MD5Str(string Str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(Str);
            string formatStr = "{0:X2}";
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using(var crypto = MD5.Create())
                {
                    var md5Hash = crypto.ComputeHash(ms);
                    StringBuilder pwd = new StringBuilder();
                    foreach (byte btStr in md5Hash) { pwd.AppendFormat(formatStr, btStr); }
                    return pwd.ToString();
                }
            }
        }
    }
}


