using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utility.Utility
{
    public static class EncryptionUtil
    {
        private static RSACryptoServiceProvider _privateKeyRsaProvider { get { return CreateRsaProviderFromPublicKey(privateKey); } }
        private static RSACryptoServiceProvider _publicKeyRsaProvider { get { return CreateRsaProviderFromPrivateKey(publicKey); } }

        static private readonly Regex _PEMCode = new Regex(@"--+.+?--+|\s+", RegexOptions.None, new TimeSpan(0, 0, 10));

        static private readonly byte[] _Ver = new byte[] { 0x02, 0x01, 0x00 };

        static private readonly byte[] _SeqOID = new byte[] { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };



        private static string privateKey = IvemBaseCommonTool.GetPrivateKeyFromEnv("doc");
        private static string publicKey = IvemBaseCommonTool.GetPublicKeyFromEnv("doc");

        public static string GetPublicKey()
        {
            return publicKey;
        }
        //public static string DecryptCryptoJsRSAString(string cipherText)
        //{
        //    return Decrypt(cipherText);
        //}
        public static string Decrypt(string cipherText)
        {
            if (_privateKeyRsaProvider == null)
            {
                throw new Exception("_privateKeyRsaProvider is null");
            }

            if (string.IsNullOrEmpty(cipherText))
            {
                return "";
            }
            return IvemBaseCommonTool.Dec(cipherText, _privateKeyRsaProvider);
        }

        public static string Encrypt(string text)
        {
            if (_publicKeyRsaProvider == null)
            {
                throw new Exception("_publicKeyRsaProvider is null");
            }
            return Convert.ToBase64String(_publicKeyRsaProvider.Encrypt(Encoding.UTF8.GetBytes(text), true));
        }

        private static RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(string pem)
        {
            return CreateRsaProviderFrom($"--PUBLIC-- {pem}");
        }

        private static RSACryptoServiceProvider CreateRsaProviderFromPublicKey(string pem)
        {
            return CreateRsaProviderFrom($"--PRIVATE-- {pem}");

        }

        private static RSACryptoServiceProvider CreateRsaProviderFrom(string pem)
        {
            var RSA = new RSACryptoServiceProvider(2048);
            var param = new RSAParameters();

            var base64 = _PEMCode.Replace(pem, "");
            byte[] data = null;
            try { data = Convert.FromBase64String(base64); } catch (Exception ex) { throw new Exception(ex.Message); }
            if (data == null)
            {
                throw new Exception("PEM content is invalid ");
            }
            var idx = 0;
            Func<byte, int> readLen = (first) =>
            {
                if (data[idx] == first)
                {
                    idx++;
                    if (data[idx] == 0x81)
                    {
                        idx++;
                        return data[idx++];
                    }
                    else if (data[idx] == 0x82)
                    {
                        idx++;
                        var pre = ((int)data[idx++]) << 8;
                        var end = data[idx++];
                        return pre + end;
                    }
                    else if (data[idx] < 0x80)
                    {
                        return data[idx++];
                    }
                }
                throw new Exception("PEM failed to extract data");
            };
            Func<byte[]> readBlock = () =>
            {
                var len = readLen(0x02);
                if (data[idx] == 0x00)
                {
                    idx++;
                    len--;
                }
                var val = new byte[len];
                for (var i = 0; i < len; i++)
                {
                    val[i] = data[idx + i];
                }
                idx += len;
                return val;
            };
            Func<byte[], bool> eq = (byts) =>
            {
                for (var i = 0; i < byts.Length; i++, idx++)
                {
                    if (idx >= data.Length)
                    {
                        return false;
                    }
                    if (byts[i] != data[idx])
                    {
                        return false;
                    }
                }
                return true;
            };

            if (pem.Contains("PUBLIC"))
            {
                readLen(0x30);
                var idx2 = idx;
                if (eq(_SeqOID))
                {
                    readLen(0x03);
                    idx++;
                    readLen(0x30);
                }
                else
                {
                    idx = idx2;
                }
                param.Modulus = readBlock();
                param.Exponent = readBlock();
            }
            else if (pem.Contains("PRIVATE"))
            {
                readLen(0x30);
                if (!eq(_Ver))
                {
                    throw new Exception("PEM version is unknown");
                }
                var idx2 = idx;
                if (eq(_SeqOID))
                {
                    readLen(0x04);
                    readLen(0x30);
                    if (!eq(_Ver))
                    {
                        throw new Exception("PEM version is invalid");
                    }
                }
                else
                {
                    idx = idx2;
                }

                param.Modulus = readBlock();
                param.Exponent = readBlock();
                int keyLen = param.Modulus.Length;
                param.D = BigL(readBlock(), keyLen);
                keyLen = keyLen / 2;
                param.P = BigL(readBlock(), keyLen);
                param.Q = BigL(readBlock(), keyLen);
                param.DP = BigL(readBlock(), keyLen);
                param.DQ = BigL(readBlock(), keyLen);
                param.InverseQ = BigL(readBlock(), keyLen);
            }

            RSA.ImportParameters(param);
            return RSA;
        }

        static public byte[] BigL(byte[] bytes, int keyLen)
        {
            if (keyLen - bytes.Length == 1)
            {
                byte[] c = new byte[bytes.Length + 1];
                Array.Copy(bytes, 0, c, 1, bytes.Length);
                bytes = c;
            }
            return bytes;
        }
    }
}
