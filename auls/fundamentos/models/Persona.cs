using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos.models
{
    public class Persona
    {
        public string name { get; set; }
        public int age { get; set; }

        public void introduce(){
            Console.WriteLine($"Olá meu nome é {name}, e tenho {age}");
        }
    }
}