using Tyuiu.AbramenkoAS.Sprint5.Task1.V27.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (3*x-1,5)/(Math.Sin(x)-3+x) +2. Произвести          *");
            Console.WriteLine("* табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести  *");
            Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.       *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на   *");
            Console.WriteLine("* консоль в таблицу. Значения округлить до двух знаков после запятой.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Диапазон: [{startValue}; {stopValue}], шаг: 1");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл создан: " + path);

            string[] value = File.ReadAllLines(path);

            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    x    |  f(x)   |");
            Console.WriteLine("+---------+---------+");

            for (int i = 0; i < value.Length; i++)
            {
                int currentX = startValue + i;

                Console.WriteLine($"| {currentX,-7} | {value[i],7} |");
            }
            Console.WriteLine("+---------+---------+");

            Console.ReadKey();
        }
    }
}
