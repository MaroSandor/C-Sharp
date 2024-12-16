namespace KutyaVasar
{
    internal class ZH
    {
        public static void Main(string[] args)
        {
            // feladat1(args);
            //
            // Point p1 = new Point(2, 3);
            // Point p2 = new Point(0, 0);
            //
            // double d = p1.DisctanceOfTwoPoints(p2);
            // Console.WriteLine($"A távolság: {d}");
            //
            // string s = "Hello Mami";
            // Console.WriteLine(s.CountSpaces());
            
            feladat2();
        }

        static void feladat1(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Hiba, adjon meg legalább 1 parancssori paramétert!");
                return;
            }

            if (int.TryParse(args[0], out int number) && number >= 0)
            {
                Console.WriteLine(number.IsSquareNumber());
            }

            Console.ReadLine();
        }

        static void feladat2()
        {
            try
            {
                var seenNumbers = new HashSet<int>();
                int sum = 0;

                foreach (var line in File.ReadLines("/home/marosandor/Documents/input.txt"))
                {
                    if (int.TryParse(line, out int number))
                    {
                        if (seenNumbers.Contains(number))
                        {
                            break;
                        }
                        
                        sum += number;
                        seenNumbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Az átalakítás nem lehetséges!");
                        return;
                    }
                }

                Console.WriteLine(sum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    
    static class MyExtensions
    {
        public static bool IsSquareNumber(this int number)
        {
            int root = (int)Math.Sqrt(number);
            return number == root * root;
        }

        public static int CountSpaces(this string str)
        {
            return str.Count(c => c == ' ');
        }

        public static double DisctanceOfTwoPoints(this Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;
            
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}