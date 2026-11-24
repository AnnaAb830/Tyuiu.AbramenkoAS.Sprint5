using Tyuiu.AbramenkoAS.Sprint5.Task4.V19.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt в котором есть       *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* в формуле y = (x / cos(x))^2. Вычислить значение по формуле и вернуть   *");
            Console.WriteLine("* полученный результат на консоль.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folderPath = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask4V19.txt";

            string path = Path.Combine(folderPath, fileName);

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
