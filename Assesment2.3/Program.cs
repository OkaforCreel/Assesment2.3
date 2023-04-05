using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "foobar";
        char letter = 'o';

        int count = 0;
        foreach (char c in s)
        {
            if (c == letter)
            {
                count++;
            }
        }

        double percent = (double)count / s.Length * 100;
        int roundedPercent = (int)Math.Floor(percent);

        Console.WriteLine(roundedPercent);
    }
}
