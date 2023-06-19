using System.Text.RegularExpressions;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = "fox(es)?";
            string input = "@\"foxes are omnivorous mammals belonging to several genera of the family Canidae fox.\"";

            int count = CountPatternOccurrences(pattern, input);
            Console.WriteLine("There are {0} occurrences.", count);
        }

        static int CountPatternOccurrences(string pattern, string input)
        {
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            return matches.Count;
        }
    }
}

    