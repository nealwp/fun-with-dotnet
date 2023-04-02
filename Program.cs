using System;

namespace funwithdotnet
{
    class FirstApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"args was {args[0]}");

            var seconds = DateTime.Now.Second;

            if (IsEven(seconds))
            {
                Console.WriteLine($"seconds {seconds} is even");
            }
            else
            {
                Console.WriteLine($"seconds {seconds} is odd");
            }

            string[] names = { "hello", "world" };

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            var words = new string[] { "give", "a", "little", "bit" };

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    
        private static bool IsEven(int i)
        {
            return (i % 2 == 0);
        }
    }

}

