using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbramenkoAS.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) - 3 + x;
                double y;

                if (Math.Abs(denominator) < 0.000001)
                {
                    y = 0;
                }
                else
                {
                    y = ((3 * x - 1.5) / denominator) + 2;
                }

                y = Math.Round(y, 2);

                File.AppendAllText(path, $"{Convert.ToString(y)}\n");
            }
            return path;
        }
    }
}
