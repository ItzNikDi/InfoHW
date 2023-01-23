using System;

namespace Task17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task19();
        }
        
        public static void Task17A()
        {
            uint num = uint.Parse(Console.ReadLine());
            byte n = 0;
            n = (byte)(num % 10 % 2);
            n += (byte)(num / 10 % 2);
            n += (byte)(num / 100 % 2);
            n += (byte)(num / 1000 % 2);
            n += (byte)(num / 10000 % 2);
            Console.WriteLine(n);
        }
        
        public static void Task17B()
        {
            uint num = uint.Parse(Console.ReadLine());
            byte sum = 0;
            sum = (byte)((num / 10000 + 1) % 2);
        }

        public static void Task18()
        {
            int num = int.Parse(Console.ReadLine());
            byte sumOfDigits = 0;
            sumOfDigits = (byte)(num % 10);
            sumOfDigits += (byte)(num / 10 % 10);
            sumOfDigits += (byte)(num / 100 % 10);
            sumOfDigits += (byte)(num / 1000 % 10);
            sumOfDigits += (byte)(num / 10000 % 10);
            sumOfDigits += (byte)(num / 100000 % 10);
            sumOfDigits += (byte)(num / 1000000 % 10);
            sumOfDigits += (byte)(num / 10000000 % 10);
            double avr = sumOfDigits / 8.0;
            Console.Write(avr);
        }

        public static void Task19()
        {
            double x = double.Parse(Console.ReadLine());
            var a = Math.Floor(x * 100 % 10);
            Console.WriteLine(a);
        }
    }
}