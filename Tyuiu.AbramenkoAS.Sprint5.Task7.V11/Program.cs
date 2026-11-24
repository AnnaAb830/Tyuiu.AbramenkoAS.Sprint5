using Tyuiu.AbramenkoAS.Sprint5.Task7.V11.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V11.txt в котором есть        *");
            Console.WriteLine("* набор символьных данных. Удалить все пробелы и строчные русские буквы из*");
            Console.WriteLine("* файла. Полученный результат сохранить в файл OutPutDataFileTask7V11.txt.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string folder = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask7V11.txt";
            string path = Path.Combine(folder, fileName);

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранен в файл: " + res);

            Console.ReadKey();
        }
    }  
}
