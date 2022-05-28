using System;
using System.Collections.Generic;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new List<User>();

            var u1 = new User
            {
                Nombre = "Maria",
                Edad = 17
            };

            var u2 = new User
            {
                Nombre = "Milena",
                Edad = 23
            };

            var u3 = new User
            {
                Nombre = "Carol",
                Edad = 26
            };

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);

            LoopWhile(users.ToArray());
            LoopFor(users.ToArray());
            LoopForeach(users.ToArray());

        }
        static void LoopWhile(User[] users)
        {
            Console.WriteLine("\nLoop While\n");

            var count = 0;

            while (count < users.Length)
            {
                if (users[count].Edad >= 18)
                {
                    Console.WriteLine($"{users[count].Nombre} tiene mas que 18 años");
                }
                else
                {
                    Console.WriteLine($"{users[count].Nombre} tiene menos que 18 años");
                }

                count++;
            }
        }

        static void LoopForeach(User[] users)
        {
            Console.WriteLine("\nLoop Foreach\n");

            foreach (var user in users)
            {
                if (user.Edad >= 18)
                {
                    Console.WriteLine($"{user.Nombre} tiene mas que 18 años");
                }
                else
                {
                    Console.WriteLine($"{user.Nombre} tiene menos que 18 años");
                }
            }
        }

        static void LoopFor(User[] users)
        {
            Console.WriteLine("\nLoop For\n");
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Edad >= 18)
                {
                    Console.WriteLine($"{users[i].Nombre} tiene mas que 18 años");
                }
                else
                {
                    Console.WriteLine($"{users[i].Nombre} tiene menos que 18 años");
                }
            }

        }

    }
}