using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramenkoAS.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();

            double x = Convert.ToDouble(strX.Replace(',', '.'), CultureInfo.InvariantCulture);

            double result = Math.Pow(x / Math.Cos(x), 2);

            result = Math.Round(result, 3);

            return result;
        }
    }
}
