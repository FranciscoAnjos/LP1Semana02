using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            int input = int.Parse(Console.ReadLine());
            sbyte n = (sbyte)input;

            n--;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);
        }
    }
}
