using System.Security.Cryptography;
using System.Text;
using System.Text.Unicode;

namespace Utility
{
    public static class BaseCommonTool
    {
        public static byte[] GetMBytes(string s)
        {
            return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(s));
        }
        public static byte[] GetMBytes(byte[] bs)
        {
            return MD5.Create().ComputeHash(bs);
        }
        public static string GetRandomAESKey()
        {
            StringBuilder sb = new StringBuilder();
            string text = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            for(int i = 0;i < 32; i++)
            {
                sb.Append(text[random.Next(text.Length)]);
            }
            return sb.ToString();
        }
    }
}