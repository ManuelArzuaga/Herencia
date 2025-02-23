namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gato = new Gato("Pepe");
            var perro = new Perro("Pepe2");

            //nombre del objeto. se pueden usar todas sus metodos y funciones

            perro.Ladrar(); //funcion propia
            perro.Comer(); //funcion heredada
            gato.Maullar(); //funcion propia
            gato.Comer(); //funcion heredada
        }
    }
}
