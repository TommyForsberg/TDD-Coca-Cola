using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Coca_Cola
{
    public class NumberManager
    {
        public void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public string CocaColaGenerator(int input)
        {
            if (input % 3 == 0)
            {
                return "Coca";
            }
            if (input % 5 == 0)
            {
                return "Cola";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
