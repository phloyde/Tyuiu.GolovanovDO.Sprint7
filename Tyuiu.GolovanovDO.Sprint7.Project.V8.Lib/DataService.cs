using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Text.Unicode;

namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public string[,] LoadFromFile(string path)
        {
            if (!File.Exists(path)) return new string[0, 7];

            string[] str = File.ReadAllLines(path, Encoding.UTF8);
            string[,] array = new string[str.Length,7];

            for (int i = 0; i < str.Length; i++)
            {
                string[] part = str[i].Split(';');

                for (int j = 0; j < 7;  j++)
                {
                    
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
                for (int j = 0; j < 7; j++)
                {
                    line += array[i, j];
                    if (j < 6)
                    {
                        line += ";";    
                    }       
                }
                lines.Add(line);
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
                for (int j = 0; j < 7; j++)
                {
                    if (array[i, j].ToLower().Contains(text.ToLower()))
                    {
                        string[] row = new string[7];
                        for (int k = 0; k < 6; k++)
                            row[k] = array[i, k];

                        str.Add(row);
                        break;
                    }
                }
            }
            string[,] res = new string[str.Count, 7];
            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    res[i, j] = str[i][j];  //Возвращает j-й элемент внутри i-го массива
                }
            }
            return res;
        }

        public string GetFullName(string[,] array, int employeeIndex)
        {
            string fullname = "";
            
            if (employeeIndex >= array.GetLength(0) || employeeIndex < 0)
            {
                return "Индекс выходит за границы";
            }
            string firstname = array[employeeIndex, 1];
            string midname = array[employeeIndex, 2];
            string lastname = array[employeeIndex, 3];

            fullname = firstname + " " + midname + " " + lastname.Trim();
            return fullname;
        }

        public string[] GetAllFullName(string[,] array)
        {
            int rowcount = array.GetLength(0);
            string[] fullnames = new string[rowcount];
            for (int i = 0; i<rowcount; i++)
            {
                string firstname = array[i, 1];
                string midname = array[i, 2];
                string lastname = array[i, 3];
                fullnames[i] = firstname + " " + midname + " " + lastname.Trim();
            }
            return fullnames;
        }

        public int MostOldPeople(string[,] array)
        {
            DateTime today = DateTime.Today;
            int maxAge = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                DateTime birthDate = DateTime.ParseExact(array[i, 4], "dd.MM.yyyy", null);

                int age = today.Year - birthDate.Year;
                if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
                {
                    age = age - 1;
                }
                else
                {
                    age = age;
                }
                if (age > maxAge)
                {
                    maxAge = age;
                }
            }
            return maxAge;
        }

        public int MostYoungPeople(string[,] array)
        {
            DateTime today = DateTime.Today;
            int minAge = 999999999;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                DateTime birthDate = DateTime.ParseExact(array[i, 4], "dd.MM.yyyy", null);

                int age = today.Year - birthDate.Year;
                if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
                {
                    age = age - 1;
                }
                else
                {
                    age = age;
                }
                if (age < minAge)
                {
                    minAge = age;
                }
            }
            return minAge;
        }

        public double AvgPeopleAge(string[,] array)
        {
            DateTime today = DateTime.Today;
            double cnt = 0;
            double sum = 0;

            for (int i = 0; i < array.GetLength (0); i++)
            {
                DateTime birthDate = DateTime.ParseExact(array[i, 4], "dd.MM.yyyy", null);
                int age = today.Year - birthDate.Year;
                if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
                {
                    age = age - 1;
                }
                else
                {
                    age = age;
                }
                sum += age;
                cnt++;

            }
            double avg = sum / cnt;
            return avg;
        }
    }
}
