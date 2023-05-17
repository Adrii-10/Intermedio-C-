using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el ancho del cuadrado:");
        int ancho = int.Parse(Console.ReadLine());

        // Validar el ancho para asegurarnos de que sea mayor que 1
        if (ancho < 1)
        {
            Console.WriteLine("El ancho debe ser mayor que 1.");
            return;
        }

        // Imprimir el cuadrado
        for (int i = 0; i < ancho; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write(numero);
            }
            Console.WriteLine();
        }
    }
}
