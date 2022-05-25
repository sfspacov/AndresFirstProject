using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var messi = new Jugador();
            messi.Nombre = "Messi";
            messi.PuedeJugar = false;
           
            var ronaldinho = new Jugador("Ronaldinho");
            ronaldinho.PuedeJugar = true;

            var cr7 = new Jugador("Cristiano Ronaldo", true);

            var romario = new Jugador("Romário", true);

            var zidane = new Jugador("Zidane", false);

            //  OR ||
            // AND &&
            if (ronaldinho.PuedeJugar || cr7.PuedeJugar && zidane.PuedeJugar)
            {
                Console.WriteLine("Campeon");
            }
            else
            {
                Console.WriteLine("Perdio");
            }
        }

        private static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}