using System;
public class NumeroExcepciones
{
    public static void Main(string[] args)
    {
        string x = Console.ReadLine();

        try
        {
            Convert.ToInt32(x);
            Console.WriteLine("Es un numero");
        }
        catch
        {
            Console.WriteLine("No es un numero");
        }
    }
}