using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint5.Task4.V27.Lib;

namespace Tyuiu.MorozAD.Sprint5.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Мороз А.Д. | СМАРТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                  *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнил: Мороз Артём Дмитриевич     | СМАРТб-23-1                       *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt Прочитать значение из *");
            Console.WriteLine("* файла и подставить вместо Х в формуле . Вычислить значение по формуле.   *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                  *");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(@"C:\DataSprint\InPutDataFileTask4V9.txt"));
            Console.ReadKey();
        }
    }
}
