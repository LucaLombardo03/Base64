using System;
using System.Text;

namespace Base64
{
    public class LibreriaBase64
    {
        public static string Base64()
        {
            string toEncode = "Luca";
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue = Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;  
        }
    }
}
