using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear matriz de valores enteros de 0 a 9
        int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Crear matriz de nombres
        string[] nombres = { "Tim", "Martin", "Nikki", "Sara" };

        // Crear matriz de valores booleanos alternantes
        bool[] booleanos = new bool[10];
        for (int i = 0; i < booleanos.Length; i++)
        {
            booleanos[i] = i % 2 == 0; // Alterna entre verdadero y falso
        }

        // Imprimir matriz de valores enteros
        Console.WriteLine("Matriz de valores enteros:");
        foreach (var numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // Imprimir matriz de nombres
        Console.WriteLine("Matriz de nombres:");
        foreach (var nombre in nombres)
        {
            Console.Write(nombre + " ");
        }
        Console.WriteLine();

        // Imprimir matriz de valores booleanos
        Console.WriteLine("Matriz de valores booleanos:");
        foreach (var valorBooleano in booleanos)
        {
            Console.Write(valorBooleano + " ");
        }
        Console.WriteLine();

        // Crear una lista de sabores de helados
        List<string> saboresHelado = new List<string>
        {
            "Vainilla", "Chocolate", "Fresa", "Menta", "Nuez", "Café"
        };

        // Imprimir la longitud de la lista de sabores de helado
        Console.WriteLine("Longitud de la lista de sabores de helado: " + saboresHelado.Count);

        // Imprimir el tercer sabor y eliminarlo
        if (saboresHelado.Count >= 3)
        {
            Console.WriteLine("Tercer sabor de la lista: " + saboresHelado[2]);
            saboresHelado.RemoveAt(2);
        }

        // Imprimir la nueva longitud de la lista
        Console.WriteLine("Nueva longitud de la lista: " + saboresHelado.Count);

        // Crear un diccionario de información de usuario
        Dictionary<string, string> infoUsuario = new Dictionary<string, string>();

        // Asociar nombres de la matriz de nombres con sabores aleatorios
        Random random = new Random();
        foreach (var nombre in nombres)
        {
            int indiceSaborAleatorio = random.Next(saboresHelado.Count);
            infoUsuario[nombre] = saboresHelado[indiceSaborAleatorio];
        }

        // Imprimir el nombre de cada usuario y su sabor de helado asociado
        Console.WriteLine("Diccionario de información del usuario:");
        foreach (var kvp in infoUsuario)
        {
            Console.WriteLine("Usuario: " + kvp.Key + ", Sabor de helado: " + kvp.Value);
        }
    }
}
