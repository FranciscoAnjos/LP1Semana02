using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira a altura do cilindro (a): ");
            double altura = double.Parse(Console.ReadLine());
            
            Console.Write("Insira o raio do cilindro (r): ");
            double raio = double.Parse(Console.ReadLine());
            
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            
            double areaSuperficie = 2 * Math.PI * raio * (raio + altura);
            
            Console.WriteLine(volume.ToString("F3"));
            Console.WriteLine(areaSuperficie.ToString("F3"));
        }
    }
}
