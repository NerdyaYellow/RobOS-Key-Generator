using System;
using Extensions.Standard.Randomization;

namespace Program
{
    class GeneratorMTA
    {
        [MTAThread]
        private double Floor2Decimals(double d)
        {
            return Math.Floor(d * 100) / 100;
        }

        [MTAThread]
        public void Generate(int keynumber, bool showunchecked, bool makenoise, bool alt, int amount)
        {
            // A copy of the Moon Framework in Roblox RobOS

            long ctime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            StrongRandom srandom = new StrongRandom();
            Random random = new Random();

            int i = 0;

            while (i < amount)
            {
                string final;
                string befinal;
                int one;
                int two;
                int three;
                if (alt)
                {
                    one = random.Next(10000, 99999);
                    two = random.Next(10000, 99999);
                    three = random.Next(10000, 99999);
                }
                else
                {
                    one = srandom.Next(10000, 99999);
                    two = srandom.Next(10000, 99999);
                    three = srandom.Next(10000, 99999);
                }
                befinal = $"{one}{two}{three}";
                final = $"{one}-{two}-{three}";


                char[] a = befinal.ToCharArray();
                if ((int.Parse(a[0].ToString()) + int.Parse(a[1].ToString()) + int.Parse(a[2].ToString()) + int.Parse(a[3].ToString()) + int.Parse(a[4].ToString()) + int.Parse(a[5].ToString()) + int.Parse(a[6].ToString()) + int.Parse(a[7].ToString()) + int.Parse(a[8].ToString()) + int.Parse(a[9].ToString()) + int.Parse(a[10].ToString()) + int.Parse(a[11].ToString()) + int.Parse(a[12].ToString()) + int.Parse(a[13].ToString()) + int.Parse(a[14].ToString())) == keynumber)
                {
                    i++;
                    if (makenoise)
                        Console.Beep(1000, 100);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(final);
                    Console.ResetColor();
                }
                else
                {
                    if (showunchecked)
                    {
                        if (makenoise)
                            Console.Beep(500, 100);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(final);
                        Console.ResetColor();
                    }
                }
            }
            long nowtime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine($"Finished! Time to generate: {Floor2Decimals((double)(nowtime - ctime) / 1000)}");
            Console.ReadKey();
        }
    }
}
