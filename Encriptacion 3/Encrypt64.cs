using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptacion_3
{
    internal class Encrypt64
    {
        public string Encriptar(string mensaje)
        {
            string result = string.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(mensaje);
            result = Convert.ToBase64String(encrypted);
            return result;
        }

        public string Desencriptar(string mensajeENC)
        {
            string result = string.Empty;
            byte[] decrypted = Convert.FromBase64String(mensajeENC);
            result = System.Text.Encoding.Unicode.GetString(decrypted);
            return result;
        }

    }
}
