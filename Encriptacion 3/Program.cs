using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptacion_3
{
    class Program
    {

        static void Main(string[]args)
        { 
            Encrypt64 encr = new Encrypt64();
                     
            
            Console.WriteLine("Escribe mensaje: ");
            string pass = Console.ReadLine().ToString();
            pass = encr.Encriptar(pass);

            Console.WriteLine("El mensaje encriptado es: " + pass);
       
            Console.WriteLine("El mensaje desencriptado es: " + encr.Desencriptar(pass));

            Console.Read();
        }
        
        
    }
}
