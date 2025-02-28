using System;
using System.Buffers.Binary;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                ///Ask the player a start and step number
                Console.Write("Start number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Step Number: ");
                int step = int.Parse(Console.ReadLine());
                
                ///Verification of if one is bigger than the other
                if (start<step)
                {
                    Console.WriteLine("Out-of-range start or step. Try again");
                    continue;
                }
                ///Verification if they are equal
                if (start == step)
                {
                    Console.WriteLine("Start must be higher than the step.Try again");
                    continue;
                }
                ///Verification if they are divisible
                if (start % step != 0)
                {
                    Console.WriteLine("Start not divisible by step.Try Again");
                    continue;
                }
                else
                {
                    do
                    {
                        Console.WriteLine(start);
                        start = start -= step;
                    } while (start >= 0);
                    
                    break;

                    
                }
            }
        }
    }
}
