using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MenshikovEA.Sprint5.Task0.V8.Lib
{
    public class DataService : ISprint5Task0V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = Math.Round((Math.Pow(x, 3) - 1)/(4 * Math.Pow(x, 2)), 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
            
        }
    }
}
