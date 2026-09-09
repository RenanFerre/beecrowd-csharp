using System;
using System.Globalization;

namespace Beecrowd;

class Problema1079
{
    static void Main(string[] args)
    {
        int N;
        double n1, n2, n3, media;

        N = int.Parse(Console.ReadLine());


        for (int i = 0; i < N; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }

        Console.ReadKey();
    }
}