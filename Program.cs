using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var u1 = new Usuario();
            u1.Nombre = "Andres";
            u1.Edad = 25;
            u1.DenifirContrasena("abc123");

            var u2 = new Usuario();
            u2.Edad = 13;

            var segundo = DateTime.Now.Second;
           
            Console.Write("\n" + segundo);

            //numero es par
            //  OR ||
            // AND &&
            if (segundo % 2 == 0 || (u1.Nombre == "Andres" && u2.Edad > 18))
            {
                Console.WriteLine(" es par");
            }
            else
            {
                Console.WriteLine(" es impar");
            }
        }
    }

}