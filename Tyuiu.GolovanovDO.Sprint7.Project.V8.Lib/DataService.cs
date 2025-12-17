using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Unicode;

namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public string[,] LoadFromFile(string path)
        {
            if (!File.Exists(path)) return new string[0, 8];

            string[] str = File.ReadAllLines(path, Encoding.UTF8);
            string[,] array = new string[str.Length,9];

            for (int i = 0; i < str.Length; i++)
            {
                string[] part = str[i].Split(';');
                for (int j = 0; j < 9;  j++)
                {
                    array[i,j] = part[j];
                    if (j < part.Length)
                    {
                        array[i, j] = part[j];
                    }
                    else
                    {
                        array[i, j] = "";
                    } 
                }
            }
            return array;
        }

        public void SaveToFile(string path, string[,] array)
        {
            List<string> lines = new List<string>();

            for (int i = 0;i < array.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < 9; j++)
                {
                    line += array[i, j];
                    if (j < 8)
                    {
                        line += ";";
                    }
                    lines.Add(line);
                }
            }
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }


        public int MinYearExperience(string[,] array)
        {
            int min = 999999;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                int year = Convert.ToInt32(array[i, 5]);
                if (year < min)
                {
                    min = year;
                }
            }
            return min;
        }

        public int MaxYearExperience(string[,] array)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                int year = Convert.ToInt32(array[i, 5]);
                if (year > max)
                {
                    max = year;
                }
            }
            return max;
        }


        public int AvgYearExperience(string[,] array)
        {
            int avg = 0;
            int cnt = 0;
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int year = Convert.ToInt32(array[i, 5]);
                cnt++;
                sum += year; 
            }
            avg = (sum / cnt);
            return avg;
        }

        public int MinSalary(string[,] array)
        {
            int min = 999999999;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int salary = Convert.ToInt32(array[i, 6]);
                if (salary < min)
                {
                    min = salary;
                }
            }
            return min;
        }

        public int MaxSalary(string[,] array)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int salary = Convert.ToInt32(array[i, 6]);
                if (salary > max)
                {
                    max = salary;
                }
            }
            return max;
        }

        public int AvgSalary(string[,] array)
        {
            int avg = 0;
            int cnt = 0;
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int salary = Convert.ToInt32(array[i, 6]);
                cnt++;
                sum += salary;
            }
            avg = (sum / cnt);
            return avg;
        }


        public string[,] Search(string[,] array, string text)
        {
            List<string[]> str = new List<string[]>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (array[i, j].ToLower().Contains(text.ToLower()))
                    {
                        string[] row = new string[9];
                        for (int k = 0; k < 8; k++)
                            row[k] = array[i, k];

                        str.Add(row);
                        break;
                    }
                }
            }
            string[,] res = new string[str.Count, 9];
            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    res[i, j] = str[i][j];  //Возвращает j-й элемент внутри i-го массива
                }
            }
            return res;
        }


    }
}
