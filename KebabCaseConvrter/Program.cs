using System;
using System.Text;

namespace KebabCaseConvrter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            var regularText = GetRegularText();

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

        private static void OutputErrorMassageAndRequestTheValue(string errorMassageEmptyLine, string requestAText)
        {
            Console.WriteLine(errorMassageEmptyLine);
            Console.WriteLine(requestAText);
        }

        private static string GetRegularText()
        {
            const string errorMassageEmptyLine1 = "Error, this field is empty";
            const string requestAText1= "Enter your text: ";
            var regularText = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrEmpty(regularText))
                {
                    OutputErrorMassageAndRequestTheValue(errorMassageEmptyLine1, requestAText1);
                    regularText = Console.ReadLine();
                    continue;
                }
                break;
            }
            return regularText;
        }
    }
}