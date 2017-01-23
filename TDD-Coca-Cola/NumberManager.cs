using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Coca_Cola
{
    public class NumberManager
    {
        public void Start() //Written by Tommy, updated by Jimmy
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(CocaColaGenerator(i));
            }
        }

        public string CocaColaGenerator(int input) //Written by Jimmy, updated by Tommy
        {
            if(input % 3 ==0 && input % 5 == 0)
            {
                return "Coca Cola";
            }
            else if (input % 3 == 0)
            {
                return "Coca";
            }
            else if (input % 5 == 0)
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
