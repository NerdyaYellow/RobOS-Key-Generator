using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            int keynumber = 0;
            bool showunchecked = false;
            bool makenoise = false;
            bool mta = false;
            bool alt = false;
            int amount = 0;

            Console.WriteLine("Welcome to the RobOS Key Generator! Please type the correct RobOS ativation key number.");
            string line = Console.ReadLine();

            if (int.Parse(line) != 0)
                keynumber = int.Parse(line);
            else
            {
                Console.WriteLine("Not a number!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("Show unverified keys? Y/N");
            ConsoleKeyInfo line2 = Console.ReadKey();
            if (line2.Key == ConsoleKey.Y)
                showunchecked = true;
            else if (line2.Key == ConsoleKey.N)
                showunchecked = false;
            else
            {
                Console.WriteLine("Not an answer!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("Create beeps of progress? Y/N");
            ConsoleKeyInfo line3 = Console.ReadKey();
            if (line3.Key == ConsoleKey.Y)
                makenoise = true;
            else if (line3.Key == ConsoleKey.N)
                makenoise = false;
            else
            {
                Console.WriteLine("Not an answer!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("Use Multi Threading? Y/N");
            ConsoleKeyInfo line4 = Console.ReadKey();
            if (line4.Key == ConsoleKey.Y)
                mta = true;
            else if (line4.Key == ConsoleKey.N)
                mta = false;
            else
            {
                Console.WriteLine("Not an answer!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("Use alternate generator? Y/N");
            ConsoleKeyInfo line5 = Console.ReadKey();
            if (line5.Key == ConsoleKey.Y)
                alt = true;
            else if (line5.Key == ConsoleKey.N)
                alt = false;
            else
            {
                Console.WriteLine("Not an answer!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Clear();

            Console.WriteLine("How many activation keys to generate?");
            string line6 = Console.ReadLine();
            try
            {
                int.Parse(line6);
            }
            catch
            {
                Console.WriteLine("Not a number!");
                Console.ReadKey();
                Environment.Exit(0);

            }
            finally
            {
                amount = int.Parse(line6);
            }

            Console.Clear();

            if (mta)
            {
                GeneratorMTA gen = new GeneratorMTA();
                gen.Generate(keynumber, showunchecked, makenoise, alt, amount);
            }
            else
            {
                Generator gen = new Generator();
                gen.Generate(keynumber, showunchecked, makenoise, alt, amount);
            }
        }
    }
}