namespace Beecrowd;

class Problema1002
{
    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine());
        double n = 3.14159;
        double area = n * Math.Pow(raio, 2);

        Console.WriteLine($"A={area:F4}");
    }
}