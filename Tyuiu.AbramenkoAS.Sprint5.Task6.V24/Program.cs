using Tyuiu.AbramenkoAS.Sprint5.Task6.V24.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTTask6V24.txt в котором есть       *");
            Console.WriteLine("* набор символьных данных.Найти количество пятизначных чисел в заданной   *");
            Console.WriteLine("* строке.                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folder = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask6V24.txt";
            string path = Path.Combine(folder, fileName);

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество пятизначных чисел: " + res);

            Console.ReadKey();
        }
    }
}
