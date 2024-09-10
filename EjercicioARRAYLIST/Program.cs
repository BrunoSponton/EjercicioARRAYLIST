using System;
using System.Collections.Generic;

class Ejercicio
{
    static void Main()
    {
        List<string> lista = new List<string>();

        // Recolectar cadenas de texto del usuario
        while (true)
        {
            Console.Write("Introducir una cadena (presionar Enter para terminar): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            lista.Add(input);
        }

        // Consultar cadenas por posición
        while (true)
        {
            Console.Write("Introducir el número de la posición de la cadena a consultar (0 para salir): ");
            string input = Console.ReadLine();
            int posicion;

            // Intentar convertir la entrada a un número
            if (int.TryParse(input, out posicion))
            {
                if (posicion == 0)
                {
                    break; // Salir del programa
                }

                // Mostrar la cadena en la posición solicitada
                if (posicion > 0 && posicion <= lista.Count)
                {
                    Console.WriteLine($"Cadena en la posición {posicion}: {lista[posicion - 1]}");
                }
                else
                {
                    Console.WriteLine("Posición inválida. Inténtalo de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Introduce un número.");
            }
        }
    }
}
