using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Disparar_Avisos.Models
{
    internal class Cripto
    {
        public  string Encrypt(string text, string key)
        {
            // Converte o texto e a chave para arrays de bytes
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            // Usa a chave para criptografar o texto
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = new byte[256 / 8];
                Buffer.BlockCopy(keyBytes, 0, aes.Key, 0, Math.Min(keyBytes.Length, aes.Key.Length));
                aes.IV = new byte[aes.BlockSize / 8];

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(textBytes, 0, textBytes.Length);
                        cs.Close();
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public  string Decrypt(string text, string key)
        {
            // Converte o texto criptografado e a chave para arrays de bytes
            byte[] textBytes = Convert.FromBase64String(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            // Usa a chave para descriptografar o texto
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = new byte[256 / 8];
                Buffer.BlockCopy(keyBytes, 0, aes.Key, 0, Math.Min(keyBytes.Length, aes.Key.Length));
                aes.IV = new byte[aes.BlockSize / 8];

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(textBytes, 0, textBytes.Length);
                        cs.Close();
                    }
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }
    }
}
