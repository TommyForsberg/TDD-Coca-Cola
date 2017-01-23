using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Coca_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new NumberManager();
            manager.Start();
            Console.ReadLine();
        }
    }
}
