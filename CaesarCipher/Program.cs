using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write the string to cipher: ");
            string c = Console.ReadLine();

            Console.WriteLine("Type the number of character to shift: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("String cipher: {0}", Cipher.Caesar(c,n));
            Console.ReadLine();
        }
    }
}
