using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"byte: Max = {byte.MaxValue}, Min = {byte.MinValue}");
            Console.WriteLine($"sbyte: Max = {sbyte.MaxValue}, Min = {sbyte.MinValue}");
            Console.WriteLine($"short: Max = {short.MaxValue}, Min = {short.MinValue}");
            Console.WriteLine($"ushort: Max = {ushort.MaxValue}, Min = {ushort.MinValue}");
            Console.WriteLine($"int: Max = {int.MaxValue}, Min = {int.MinValue}");
            Console.WriteLine($"uint: Max = {uint.MaxValue}, Min = {uint.MinValue}");
            Console.WriteLine($"long: Max = {long.MaxValue}, Min = {long.MinValue}");
            Console.WriteLine($"ulong: Max = {ulong.MaxValue}, Min = {ulong.MinValue}");
            Console.WriteLine($"float: Max = {float.MaxValue}, Min = {float.MinValue}");
            Console.WriteLine($"double: Max = {double.MaxValue}, Min = {double.MinValue}");
            Console.WriteLine($"decimal: Max = {decimal.MaxValue}, Min = {decimal.MinValue}");
            
            Console.WriteLine($"float positive infinity: {float.PositiveInfinity}");
            Console.WriteLine($"float negative infinity: {float.NegativeInfinity}");
            Console.WriteLine($"float NaN: {float.NaN}");
            
            Console.WriteLine($"double positive infinity: {double.PositiveInfinity}");
            Console.WriteLine($"double negative infinity: {double.NegativeInfinity}");
            Console.WriteLine($"double NaN: {double.NaN}");
            
            uint maxUint = uint.MaxValue;
            Console.WriteLine($"Valor máximo de uint: {maxUint}");
            
            uint overflowUint = maxUint + 1;
            Console.WriteLine($"Resultado do overflow em uint (maxUint + 1): {overflowUint}\n");
            
            float largePositiveFloat = float.MaxValue * 2;  
            Console.WriteLine($"Resultado do overflow positivo em float (float.MaxValue * 2): {largePositiveFloat}");

            float largeNegativeFloat = float.MinValue * 2; 
            Console.WriteLine($"Resultado do overflow negativo em float (float.MinValue * 2): {largeNegativeFloat}\n");
        }
    }
}
