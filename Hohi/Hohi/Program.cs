using System;

namespace Hohi
{
    public class Hohi
    {
        private const string _greetings = "Hello!";

        public override string ToString()
        {
            return _greetings;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Hohi h = new Hohi();
            Console.WriteLine(h);
        }
    }
}
