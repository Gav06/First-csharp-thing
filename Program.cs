using System;

namespace first_c__thing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, {Environment.UserName}}!"); 
            if (args.Length < 1) {
                Console.WriteLine("Give me an arg >:(");
            }
            else if (args[0] == "time") {
                Console.WriteLine($"The time is currently {DateTime.Now.ToString("h:mm:ss tt")}");
            }
        }
    }
}
