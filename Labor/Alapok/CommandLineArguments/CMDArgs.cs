namespace Alapok.CommandLineArguments;

public class CMDArgs
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Hiba: Nincs megadott szám a bemeneten!");
            return;
        }

        // int[] sortedNumbers = { };

        // for (int i = 0; i < args.Length; i++)
        // {
        //     sortedNumbers[i] = Convert.ToInt32(args[i]);
        // }

        foreach (var number in args)
        {
            Console.Write(number + ' ');
        }
    }
}