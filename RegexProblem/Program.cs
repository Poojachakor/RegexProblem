using System.Text.RegularExpressions;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string pattern = @"\b[a-z]+(?:_[a-z]+)+\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Found the following sequences of lowercase letters joined by an underscore:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No sequences of lowercase letters joined by an underscore found.");
            }

            Console.ReadKey();
        }
    }
}
    
    