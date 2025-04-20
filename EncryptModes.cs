using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptCode
{
    public class EncryptModes
    {
        byte[] iv = new byte[16];
        byte[] key = new byte[16];
        private static readonly CipherMode cipherMode = CipherMode.CBC;
        private static readonly PaddingMode padding = PaddingMode.PKCS7;
        public EncryptModes()
        {
            using (Aes aes = Aes.Create())
            {
                iv = aes.IV;
                key = aes.Key;
            }
        }

        public byte[] EncryptAndDecryptXOR(byte[] byteArray)
        {
            byte[] encryptByteArray = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                encryptByteArray[i] = (byte)(byteArray[i] ^ key[i % key.Length]);
            }

            return encryptByteArray;
        }


        public byte[] EncryptAES(byte[] byteArray)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = padding;
                aes.Mode = cipherMode;

                ICryptoTransform cryptoTransform = aes.CreateEncryptor();

                return cryptoTransform.TransformFinalBlock(byteArray, 0, byteArray.Length);
            }
        }

        public byte[] DecryptAES(byte[] byteArray)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = padding;
                aes.Mode = cipherMode;

                ICryptoTransform cryptoTransform = aes.CreateDecryptor();
                return cryptoTransform.TransformFinalBlock(byteArray, 0, byteArray.Length);
            }
        }

        public string getKeyAndIV()
        {
            string KEY = ConvertByteArrayToStringCSharp(key);
            string IV = ConvertByteArrayToStringCSharp(iv);
            return $"byte[] key = {{ {KEY} }}; " + Environment.NewLine + $"byte[] IV = {{ {IV} }};";
        }

        public string ConvertByteArrayToStringCSharp(byte[] byteArray)
        {
            string hexString = string.Join(", ", byteArray.Select(x => $"0x{x:X2}"));
            return hexString;
        }

        public string GetDecryptAESCodeAsString()
        {
            return @"
public byte[] DecryptAES(byte[] byteArray)
{
    using (Aes aes = Aes.Create())
    {
        aes.Key = Put Your key Here;
        aes.IV = Put Your key Here;
        aes.Padding = padding;
        aes.Mode = cipherMode;

        ICryptoTransform cryptoTransform = aes.CreateDecryptor();
        return cryptoTransform.TransformFinalBlock(byteArray, 0, byteArray.Length);
    }
}
";
        }

        public string getXOREncryptAndDecryptAsString()
        {
            return @"
public byte[] EncryptAndDecryptXOR(byte[] byteArray)
        {
            byte[] encryptByteArray = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                encryptByteArray[i] = (byte)(byteArray[i] ^ key[i % key.Length]);
            }

            return encryptByteArray;
        }";
        }
    }
}
