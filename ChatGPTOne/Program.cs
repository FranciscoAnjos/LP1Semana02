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
                    else
                    {
                        Console.WriteLine("Sorry, I didn't recognize your question.");
                    }
                }
            }
        }
    }
}
