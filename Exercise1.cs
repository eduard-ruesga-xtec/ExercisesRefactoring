using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Introdueix el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdueix el segon número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdueix el tercer número:");
        int num3 = int.Parse(Console.ReadLine());

        int result1 = num1 * num1;
        Console.WriteLine($"El quadrat de {num1} és {result1}");

        int result2 = num2 * num2;
        Console.WriteLine($"El quadrat de {num2} és {result2}");

        int result3 = num3 * num3;
        Console.WriteLine($"El quadrat de {num3} és {result3}");
    }
}
