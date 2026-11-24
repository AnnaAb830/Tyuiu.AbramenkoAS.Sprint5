using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramenkoAS.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            text = text.Replace(',', '.');
            string[] stringNumbers = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int maxEvenInteger = int.MinValue;
            bool found = false;

            foreach (string str in stringNumbers)
            {
                if (double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (number % 1 == 0 && number % 2 == 0)
                    {
                        int intNumber = (int)number;
                        if (intNumber > maxEvenInteger)
                        {
                            maxEvenInteger = intNumber;
                            found = true;
                        }
                    }
                }
            }
            if (!found) return 0;

            double factorial = 1;
            for (int i = 1; i <= maxEvenInteger; i++)
            {
                factorial *= i;
            }

            return Math.Round(factorial, 3);
        }
    }
}
