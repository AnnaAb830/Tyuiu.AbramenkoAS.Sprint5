using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramenkoAS.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            char[] delimiters = new char[] { ' ', ',', '.', '\n', '\r', '\t', '!', '?', ';', ':' };
            string[] words = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (string word in words)
            {
                if (word.All(char.IsDigit) && word.Length == 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
