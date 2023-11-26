using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MenshikovEA.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            double  strX = Convert.ToDouble(File.ReadAllText(path));
            double res = (Math.Pow(strX, 3) - 4 * strX) / (Math.Cos(strX));
            return res;
        }
    }
}
