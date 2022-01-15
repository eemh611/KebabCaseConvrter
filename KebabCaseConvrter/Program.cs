using System;
using System.Text;
namespace KebabCaseConvrter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            var regularText = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrEmpty(regularText))
                {
                    Console.WriteLine("Enter your text: ");
                    regularText = Console.ReadLine();
                    continue;
                }
                break;
            }
           
            char[] delimiters = new char[] { ',', ' ', '.', ';', '-', ':' };
            string[] words = regularText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var stringBuilder = new StringBuilder();

            foreach (string i in words)
            {
                stringBuilder.Append(i).Append("-");
                continue;
            }

            string hyphenatedText = stringBuilder.ToString();
            int lastHyphen = hyphenatedText.Length - 1;
            string kebabCase = hyphenatedText.Remove(lastHyphen);

            Console.WriteLine(kebabCase.ToLower());
        }
    }
}