using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете дължина на правоъгълника");
            int a =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Въведете ширината на правоъгълника");
            int b =
                Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Лицето на правоъгълника е:");
            int s = a * b;
            Console.WriteLine(s);
            
           
        }
    }
}
