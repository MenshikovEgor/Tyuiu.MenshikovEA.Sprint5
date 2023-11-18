using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint5.Task2.V23.Lib;
using System.IO;

namespace Tyuiu.MenshikovEA.Sprint5.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[3, 3] { { 7, 2, 8 }, { 6, 9, 1 }, { 2, 3, 5 } };
            int rows = Matrix.GetUpperBound(0) + 1;
            int columns = Matrix.Length / rows;

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{Matrix[i, j]} \t");
                }
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(Matrix);

            Console.WriteLine($"Результат сохранён в {res}");
            Console.ReadKey();
        }
    }
}
