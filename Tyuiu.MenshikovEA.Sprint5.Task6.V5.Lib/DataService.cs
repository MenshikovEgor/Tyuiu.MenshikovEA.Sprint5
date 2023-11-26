using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MenshikovEA.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string letters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        for (int i = 0; i <= letters.Length - 1; i++)
                        {
                            if (char.IsUpper(c) && c == letters[i])
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
