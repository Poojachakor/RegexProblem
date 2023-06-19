using System.Text.RegularExpressions;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] fileNames = { "image.jpg", "photo.png", "document.docx", "picture.gif", "data.csv" };
            string pattern = @"^.+\.(jpg|jpeg|png|gif)$";

            foreach (string fileName in fileNames)
            {
                if (Regex.IsMatch(fileName, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($"{fileName} is a valid image file name.");
                }
                else
                {
                    Console.WriteLine($"{fileName} is not a valid image file name.");
                }
            }
        }
    }
}


    