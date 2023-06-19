using System.Text.RegularExpressions;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            string pattern = @"<[^>]+>";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

    