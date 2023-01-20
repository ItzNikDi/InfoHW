using System;
using System.Runtime.ConstrainedExecution;

namespace Tasks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task10();
        }

        public static void Task8()
        {
            uint a = uint.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(c);
        }

        public static void Task9()
        {
            uint a = uint.Parse(Console.ReadLine());
            uint x1 = (uint)Math.Pow((2 * a), 4);
            uint x2 = (uint)(Math.Pow(2, 4) * Math.Pow(a, 4));
            Console.WriteLine(x1 == x2);
        }

        public static void Task10()
        {
            uint sec = uint.Parse(Console.ReadLine());
            uint h = sec / 3600;
            uint m = sec / 60;
            uint s = sec % 60;
            Console.WriteLine("{0}h {1}m {2}s", h.ToString(), m.ToString(), s.ToString());
        }

        public static void Task11()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("p = ");
            uint p = uint.Parse(Console.ReadLine());
            uint fullRides = n / p;
            uint notFullRides = (uint)Math.Ceiling((decimal)(n%p) / p);
            Console.WriteLine(fullRides+notFullRides);
        }

        public static void Task12()
        {
            byte h = byte.Parse(Console.ReadLine());
            byte m = byte.Parse(Console.ReadLine());
            byte t = byte.Parse(Console.ReadLine());
            m += t;
            h += (byte)(m/60);
            m %= 60;
            h %= 24;
            Console.WriteLine("{0}h {1}m", h, m);
        }
    }
}