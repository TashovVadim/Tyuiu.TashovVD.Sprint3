using Tyuiu.TashovVD.Sprint3.Task5.V23.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task5.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Название проектов (консольного приложения, библиотеки классов,          *");
            Console.WriteLine("* тестового модуля) оформить по шаблону в соответствии с вариантом.       *");
            Console.WriteLine("* Интерфейс консольного приложения оформить по шаблону.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("значение переменной x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("значение переменной startValue1: ");
            int startValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("значение переменной startValue2: ");
            int startValue2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("значение переменной stopValue1: ");
            int stopValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("значение переменной stopValue2: ");
            int stopValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
