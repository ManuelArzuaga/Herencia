using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
            
        }

        public void Ladrar() //funcion propia del perro
        {
            Console.WriteLine($"{Nombre} esta ladrando");
        }
    }
}
