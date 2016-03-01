using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = "I enjoy writing uber-software in C#";

            //7 Query that pulls all vowels
            var result =
                from c in sample.ToLower()
                where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                group c by c;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
