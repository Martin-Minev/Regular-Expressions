using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})(\2)(\d{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchDates = regex.Matches(text);

            foreach (Match match in matchDates)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[5].Value}");
            }
        }
    }
}
