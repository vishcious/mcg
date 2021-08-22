using System;

namespace mcg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Ctrl + C to exit");
            while( 0 == 0) {
                var input = Console.ReadLine();
                if(Int64.TryParse(input, out var number)) {
                    var result = Pretty.Prettify(number);
                    Console.WriteLine(string.IsNullOrEmpty(result) ? $"Unexpected error prettifying number '{input}'" : result);
                } else {
                    Console.WriteLine($"{input} is not a valid integer. Try again");
                }
            }
        }

    }
}
