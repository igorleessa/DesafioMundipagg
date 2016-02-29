using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL.Persistence
{
    public class CriptographyPass
    {
        public static string EncryptMD5(string Password)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();

                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(Password));

                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gerar Hash MD5: " + ex.Message);
            }

        }
    }
}
