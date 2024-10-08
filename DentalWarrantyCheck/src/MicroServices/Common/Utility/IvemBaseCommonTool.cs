using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Utility
{
    public class IvemBaseCommonTool
    {
        private const int TAB_FILL = 76;

        private static Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
    {
        { "rsapublickey", "<RSAKeyValue><Modulus>z6gqjgppVncCpFKRM+lmWOQlD0rvRgpTtt5CIeLKYERZ5NUV7zWZChqEMaG0uC1D6C6MMkYclb/AK54dM/f8hGaticV68V7krZ6ZR5ioUT6M0iyFkidks78KAK6Rf9SOGRWsu0kPOX+PiVIUFk4bmh7t2XAlzP9cU6bEmmeTL2C12xanCuAT5QC1hOZdLY0eNaH3NrcuDKRyzFTzNpBhakYQrYk2bUfl4GvSfhMI1Ikr/yMcBXNKOR41uTJISmPqbRYJTNBKv5EkiQSsUqtM18dNYzH4ElssHAueCho7IdzyOZNR9A/klNbdC+dtbhSUu926WMKNDdKOH8RyqypLiQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>" },
        { "rsaprivatekey", "<RSAKeyValue><Modulus>z6gqjgppVncCpFKRM+lmWOQlD0rvRgpTtt5CIeLKYERZ5NUV7zWZChqEMaG0uC1D6C6MMkYclb/AK54dM/f8hGaticV68V7krZ6ZR5ioUT6M0iyFkidks78KAK6Rf9SOGRWsu0kPOX+PiVIUFk4bmh7t2XAlzP9cU6bEmmeTL2C12xanCuAT5QC1hOZdLY0eNaH3NrcuDKRyzFTzNpBhakYQrYk2bUfl4GvSfhMI1Ikr/yMcBXNKOR41uTJISmPqbRYJTNBKv5EkiQSsUqtM18dNYzH4ElssHAueCho7IdzyOZNR9A/klNbdC+dtbhSUu926WMKNDdKOH8RyqypLiQ==</Modulus><Exponent>AQAB</Exponent><P>0mPSHriaAfGqXLaP/mB2c+ZfGqBoAaYh1cy19fqQNtVDiYvUsh/UidkgSRysbpPwAPYimmJZZ6bIcUhzIkkjoF/nEnuNESuYSVRRsqJiwQZgSGIMPp7eHFMvEXwJJoJ4fBPtFj85chJmx/mdlmh4GSpnfTUxOkt1FvYilKxPWGM=</P><Q>/KyrJHDANlZEFn5GbNtVaaG7gg+GFeP7af8JK/CprA+8uTQdp/K+gGzQO8bTgTkABmivKzMtaC6EhdU9aeigIOpn/59+RjtObDkLy0IbDTdVytcYZkFcvAsGeOt49UthtW2TikA5xLK0uQz5FAFCarvy37rCzA5Gijm4XgPw0iM=</Q><DP>Ovc/LN0QTPsuhE2mjeT7TgCDJzNN8yhc009MsGRJhxS+mQ5XzpSdPQVdxyACM/vCiIJzsFFgPWzBQP7NRg65rXkzijqWjvlo9SRswWRByVfAJIlWZTahic7Gol/hMKngmuX6zQFrWE1QATw0rrMY9fSsjKsb4PrFFmplxsWEd4E=</DP><DQ>rc60tw9cGMSEd5iLJyxE97GKAzBcgshdVA9cJr6YaEQ3BIrl73ZaNosjPktJiDVGYCI4hJXioSyGem0xnp2nMJ0txrfWq8b17hnblAi4BQJQYIRPQ1+ow60t2ZXYkZs17hAfElWVp0lqaXSUDX/ESRlaOy4D+0vCmCiWOw2o5VM=</DQ><InverseQ>UW5dGRIe32/p/RKXnGUZpgg3gjMbZXuge19iKGvzsclh2Jup+uE5BJ39gXIN9t48aZa1R6C5TY3hFOeh8QGIi4Enf+APViOFoNdN8sPSrc+QabeyDfLPSQHLa8xJYGma/M3l3odGAHG2FDUybtJ3ePOtEjqDAFVSTU9vT5BRPI8=</InverseQ><D>Jp10BGPlQMHyyNHd1JRzhtYuGhDqO9ERzjC4hYqh7ZLoUIhbgtcptVpG+N/ENnecaCG3ymWFTUeSGcpWTeKwn4JkhPknKpll1u9mO40kx67lCvRihlIzBMXiu0u7HNVO81U3gMBOR3f0HioYOCmgMmHMAyI6tUtLRPb/GmNmWGnCayxpCXgV5biOgkrkx/sS5vIDoIrmV7GCh3pUqDjWYDwh1iu2oFt/dtO1E6iFAAe3auSVOUz1WXiAtvRCISYvYBs1vpiMVBGlf8CP/scRAt9vPICr1udyCxwzHIpDUSEN62z2eOPl4npJ22cwTK/e74V1Klc1b2nP97EpLmS5bQ==</D></RSAKeyValue>" },
        { "docpublickey", "-----BEGIN PUBLIC KEY-----\r\nMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCDd9pRs5ZnY+7gL+tdEFLGOJ75\r\nrACd5cIonlpIFMmwBLR9nioEUW5BDc7dR1s7Ni9PNI4lUrl9jcSWuHW/BZWL5ccW\r\nD1LH2DgZbkX6R+9HVxEK7oudzN33GqAzUi52iWzo0Vj+9fqckBqlqLMFW/ZZsi/l\r\nhELlaLDk99uTJyT1ewIDAQAB\r\n-----END PUBLIC KEY-----" },
        { "docprivatekey", "-----BEGIN RSA PRIVATE KEY-----\r\nMIICWwIBAAKBgQCDd9pRs5ZnY+7gL+tdEFLGOJ75rACd5cIonlpIFMmwBLR9nioE\r\nUW5BDc7dR1s7Ni9PNI4lUrl9jcSWuHW/BZWL5ccWD1LH2DgZbkX6R+9HVxEK7oud\r\nzN33GqAzUi52iWzo0Vj+9fqckBqlqLMFW/ZZsi/lhELlaLDk99uTJyT1ewIDAQAB\r\nAoGABYy1KBbDJhknV8peDp8mR1zThSmYGxI8WHeaywkpnGcOcXEQR/9h/pgFH/0n\r\noj++zoKi73tm/iBSaKRfwBENx3rtwmQprHvjn6b7gewGRQ8byZrYFvs1p4pawrYc\r\n0xHtgfi1Eefl5TOkPfa3k9gwZDXE3wcTD+EY7U5l3lbhWBkCQQChezI24lNRLSXG\r\nRoHUUI5HswC/KjQKbf0EYXeuipru2DGqnBzXvC8iiyzs32izAgt7HniPz9QokMPA\r\nL8eFFIdTAkEA0GtqQsG79ZEUFIcLTYYZxWY1nlAULrzlrpPEZUSHdy3HXxaWDof7\r\n7fV7g3fzHCOxcd3yxDrnChpDPZPCritcOQJAA+/7E3eFTI9rQmBpvgGQ1pK4y/B9\r\ngFuaNcciofDjQjunSl+wHFqMU61NFSGFbgf4u7HMgsUwiSSugTspBEex3QJAcDm2\r\nsRWSuSsSje8dlfPkgpeDvahPBc+vOW7V7NWWwATFex01VcPBUyPBC0yWeot5q9+g\r\nLiutZpI3rLuYs6IjeQJAFInYUbr6iQAHWlolpyr3abyvxTglavxKOAN6Gf+zo0Uj\r\neX4uuL3W65uAqs4Sge4t5lgH3CQg9DGjcoJ7FkbbJQ==\r\n-----END RSA PRIVATE KEY-----" }
    };

        public static string GetDyPa => "af13ea8c12b5";


        public static string GetRmNum()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string text = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            for (int i = 0; i < 32; i++)
            {
                stringBuilder.Append(text[random.Next(text.Length)]);
            }

            return stringBuilder.ToString();
        }

        public static string GetCryString(string input)
        {
            using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(input));
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array[i].ToString("X2"));
            }

            return stringBuilder.ToString();
        }

        public static byte[] GetMBytes(string s)
        {
            return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(s));
        }

        public static byte[] GetMBytes(byte[] bs)
        {
            return MD5.Create().ComputeHash(bs);
        }

        public static void SetClient(HttpClientHandler handler)
        {
            handler.ServerCertificateCustomValidationCallback = (HttpRequestMessage httpRequestMessage, X509Certificate2? cert, X509Chain? cetChain, SslPolicyErrors policyErrors) => true;
        }

        public static void SetWenClient(HttpClientHandler handler)
        {
            ServicePointManager.ServerCertificateValidationCallback = (object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors) => true;
        }

        public static string Dec(string cipherText, RSACryptoServiceProvider _privateKeyRsaProvider)
        {
            if (_privateKeyRsaProvider == null)
            {
                throw new Exception("_privateKeyRsaProvider is null");
            }

            if (string.IsNullOrEmpty(cipherText))
            {
                return "";
            }

            return Encoding.UTF8.GetString(_privateKeyRsaProvider.Decrypt(Convert.FromBase64String(cipherText), fOAEP: false));
        }

        public static string GetPublicKeyFromEnv(string funcName)
        {
            return keyValuePairs[funcName + "publickey"];
        }

        public static string GetPrivateKeyFromEnv(string funcName)
        {
            return keyValuePairs[funcName + "privatekey"];
        }

        public static void GetStream(Stream requestStream, string requestBody)
        {
            byte[] array = new byte[8192];
            using MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(requestBody));
            int num = 0;
            while ((num = memoryStream.Read(array, 0, array.Length)) > 0)
            {
                requestStream.Write(array, 0, num);
            }
        }


        private static int ReplaceContent(Dictionary<string, string> dict, XmlElement child)
        {
            int num = 0;
            int num2 = 0;
            foreach (KeyValuePair<string, string> item in dict)
            {
                num += item.Key.Length;
                num2 += item.Value.Length;
                child.InnerXml = child.InnerXml.Replace(item.Key, item.Value);
            }

            if (num + 76 > num2)
            {
                return (num + 76 - num2) / 4 + 2;
            }

            _ = num2 - num;
            _ = 100;
            return 0;
        }

        private static void InsertTab(XmlElement parent, int tabCount, XmlDocument tabDoc)
        {
            for (int i = 0; i < tabCount; i++)
            {
                XmlNode newChild = parent.OwnerDocument.ImportNode(tabDoc.DocumentElement.FirstChild, deep: true);
                parent.AppendChild(newChild);
            }
        }

        private static void InsertLine(XmlElement parent, XmlDocument lineDoc)
        {
            XmlNode newChild = parent.OwnerDocument.ImportNode(lineDoc.DocumentElement.FirstChild, deep: true);
            parent.AppendChild(newChild);
        }

        private static void DistinctDocPrId(XmlElement node, ref int docPrIndex)
        {
            try
            {
                foreach (XmlElement xmlElement2 in GetXmlElements(node, "mc:AlternateContent"))
                {
                    int value = docPrIndex++;
                    XmlElement xmlElement = GetXmlElement(xmlElement2, "wp:docPr");
                    if (xmlElement != null)
                    {
                        xmlElement.SetAttribute("id", value.ToString());
                        xmlElement.SetAttribute("name", $"Straight Connector {value}");
                    }

                    GetXmlElement(xmlElement2, "v:line")?.SetAttribute("id", $"Straight Connector {value}");
                }
            }
            catch
            {
            }
        }

        private static IEnumerable<XmlElement> GetXmlElements(XmlElement node, string name)
        {
            if (node == null)
            {
                yield break;
            }

            foreach (XmlElement child in node.ChildNodes.OfType<XmlElement>())
            {
                if (child.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    yield return child;
                }

                if (child.ChildNodes == null)
                {
                    continue;
                }

                IEnumerable<XmlElement> xmlElements = GetXmlElements(child, name);
                if (xmlElements == null)
                {
                    continue;
                }

                foreach (XmlElement item in xmlElements)
                {
                    yield return item;
                }
            }
        }

        private static XmlElement? GetXmlElement(XmlElement node, string name)
        {
            if (node == null)
            {
                return null;
            }

            foreach (XmlElement item in node.ChildNodes.OfType<XmlElement>())
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }

                if (item.ChildNodes != null)
                {
                    XmlElement xmlElement = GetXmlElement(item, name);
                    if (xmlElement != null)
                    {
                        return xmlElement;
                    }
                }
            }

            return null;
        }
    }
}
