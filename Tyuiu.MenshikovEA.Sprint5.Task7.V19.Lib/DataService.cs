using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;

namespace Tyuiu.MenshikovEA.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string PathSaveFile = @"C:\Users\mensh\source\repos\Tyuiu.MenshikovEA.Sprint5\Tyuiu.MenshikovEA.Sprint5.Task7.V19\bin\Debug\OutPutDataFileTask7V19.txt";

            FileInfo fileinfo = new FileInfo(PathSaveFile);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(PathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string Line;
                while ((Line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < Line.Length - 1; i++)
                    {
                        if (((Line[i] == 'с') && (Line[i+1] == 'с')) || ((Line[i] == 'С') && (Line[i + 1] == 'с')))
                        {
                            strLine = Regex.Replace(Line, "сс", "");
                            strLine = Regex.Replace(Line, "Сс", "");
                        }
                        if ((Line[i] == 'С') && (Line[i + 1] == 'с'))
                        {
                            strLine = Regex.Replace(Line, "Сс", "");
                        }
                    }
                    File.AppendAllText(PathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
                
            }
            return PathSaveFile;
        }
    }
}
