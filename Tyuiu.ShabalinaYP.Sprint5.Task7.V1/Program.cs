using Tyuiu.ShabalinaYP.Sprint5.Task7.V1.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт #5 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все цифры из файла.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V1.txt");
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Файл создан: " + res);
            Console.ReadKey();
        }
    }
}
