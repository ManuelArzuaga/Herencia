using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Herencia
{
    class Gato : Animal //hereda de animal
    {
        public Gato(string nombre) : base (nombre) //el parametro que se la pasa en base se obtiene del constructor de Gato y se pasa al constructor Padre que es animal
        {
              //el nombre se asigna en el constructor Padre que es animal
              //una herencia permite usar todos los metodos, funciones y parametros de la clase Padre en la clase hijo
        }

        public void Maullar()
        {
            Console.WriteLine($"{Nombre} esta maullando"); // el parametro Nombre lo hereda de la clase animal
        }


    }
}
