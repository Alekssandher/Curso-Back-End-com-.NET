using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos.models
{
    public class Calcu
    {
        public void somar(int x, int y){
            int result = x + y;
            Console.WriteLine($"O resultado de {x} + {y} é {result}");
        }
    }
}