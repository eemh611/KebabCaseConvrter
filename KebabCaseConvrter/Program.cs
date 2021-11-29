using System;
using System.Text;
namespace KebabCaseConvrter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string regularText = Console.ReadLine();

            string[] words = regularText.Split(new char[] { ',', ' ', '.', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var StringBuilder = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                regularText = words[i];
                StringBuilder.Append(words[i]).Append("-");
                continue;
            }

            string hyphenatedText = StringBuilder.ToString();
            int lastHyphen = hyphenatedText.Length - 1;
            string kebabCase = hyphenatedText.Remove(lastHyphen);

            Console.WriteLine(kebabCase.ToLower());
        }
    }
}
