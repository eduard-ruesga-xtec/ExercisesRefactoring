using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Introdueix el nombre d'estudiants:");
        int numEstudiants = int.Parse(Console.ReadLine());
        int[] notes = new int[numEstudiants];

        // Llegir les notes
        for (int i = 0; i < numEstudiants; i++)
        {
            Console.WriteLine($"Introdueix la nota de l'estudiant {i + 1}:");
            notes[i] = int.Parse(Console.ReadLine());
        }

        // Calcular la nota mitjana
        int suma = 0;
        for (int i = 0; i < notes.Length; i++)
        {
            suma += notes[i];
        }
        double mitjana = (double)suma / notes.Length;

        // Comptar els aprovats i suspesos
        int aprovats = 0, suspesos = 0;
        for (int i = 0; i < notes.Length; i++)
        {
            if (notes[i] >= 5)
            {
                aprovats++;
            }
            else
            {
                suspesos++;
            }
        }

        // Mostrar resultats
        Console.WriteLine($"Nota mitjana: {mitjana}");
        Console.WriteLine($"Aprovats: {aprovats}");
        Console.WriteLine($"Suspesos: {suspesos}");
    }
}
