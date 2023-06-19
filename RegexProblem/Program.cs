using System.Text.RegularExpressions;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string websiteAddress = "https://www.example.com";

            bool isValid = ValidateWebsiteAddress(websiteAddress);
            if (isValid)
            {
                Console.WriteLine("Website address is valid.");
            }
            else
            {
                Console.WriteLine("Invalid website address format.");
            }
        }

        static bool ValidateWebsiteAddress(string websiteAddress)
        {
            
            string pattern = @"^(https?://)?([a-zA-Z0-9-]+\.)*[a-zA-Z0-9-]+(\.[a-zA-Z]{2,})+(/\S*)?$";

            Regex regex = new Regex(pattern);
            return regex.IsMatch(websiteAddress);
        }
    }
}

            