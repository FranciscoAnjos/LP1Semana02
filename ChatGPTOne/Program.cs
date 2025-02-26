using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Please enter a question or type 'EXIT' to quit:");
                string question = Console.ReadLine();

                if (question != null && question.Equals("EXIT", StringComparison.CurrentCultureIgnoreCase))
                {
                    loop = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    if (question != null && question.Equals("what is your name?", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("I'm ChatBot!");
                    }
                    else if (question != null && question.Equals("what is the capital of portugal?", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("The capital of Portugal is Lisbon.");
                    }
                    else if (question != null && question.Equals("what is artificial intelligence?", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Artificial intelligence is the field of computer science that studies and creates systems that simulate human capabilities.");
                    }
                    else if (question != null && question.Equals("what is the color of the sky?", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("The color of the sky is blue, but it can vary depending on atmospheric conditions.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, I didn't recognize your question.");
                    }
                }
            }
        }
    }
}
