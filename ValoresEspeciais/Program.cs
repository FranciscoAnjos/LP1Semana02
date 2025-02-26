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
        }
    }
}
