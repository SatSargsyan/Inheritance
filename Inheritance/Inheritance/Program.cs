using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person pr = new Person();
            pr.Firstname = "Լիլիթ";
            var gr=new Person("Գևորգ", "Թումանյան", 5);
            Console.WriteLine(pr.Firstname);
            Console.WriteLine(gr.print);
            Console.Read();
        }
    }
}
