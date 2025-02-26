using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não negativo: ");
            int input = int.Parse(Console.ReadLine());
            
            byte n = (byte)input;

            int n1 = n / 2;
            Console.WriteLine(n1);

            int n2 = n << 3;
            Console.WriteLine(n2);

            int n3 = n ^ 6;
            Console.WriteLine(n3);

            bool n4 = n > 10;
            Console.WriteLine(n4);  
        }
    }
}
