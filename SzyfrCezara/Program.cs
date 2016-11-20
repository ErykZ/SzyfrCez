using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Wprowadź hasło, które chcesz zmienić na szyf Cezara: ");
            string kodZnaku = Console.ReadLine();
            char[] chars = kodZnaku.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int szyfr = chars[i] + 3;
                Console.Write(Convert.ToChar(szyfr));
            }

            Console.ReadKey();
        }
    }
}
