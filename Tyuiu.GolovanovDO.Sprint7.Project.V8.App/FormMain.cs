using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tyuiu.GolovanovDO.Sprint7.Project.V8.Lib;
namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.App
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        private string[,] dataArray;

        public FormMain()
        {
            InitializeComponent();
            openFileDialog_GDO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_GDO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static int rows;
        static int cols;
        static string openFilePath;


        private void buttonMinYearExperience_GDO_Click(object sender, EventArgs e)
        {

            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MinYearExperience(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMaxYearExperience_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MaxYearExperience(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonAvgYearExperience_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.AvgYearExperience(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMinSalary_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MinSalary(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMaxSalary_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MaxSalary(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAvgSalary_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.AvgSalary(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetAllFullName_GDO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_GDO.Rows.Clear();
            dataGridViewResult_GDO.Columns.Clear();

            string header = "Список ФИО всех водителей";


            string[] names = ds.GetAllFullName(dataArray);
            int rows = dataArray.GetLength(0);

            dataGridViewResult_GDO.ColumnCount = 1;


            dataGridViewResult_GDO.Columns[0].Width = 500;

            dataGridViewResult_GDO.Columns[0].HeaderText = header;

            foreach (string name in names)
            {
                dataGridViewResult_GDO.Rows.Add(name);
            }
        }

        private void buttonMostOldPeople_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MostOldPeople(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMostYoungPeople_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MostYoungPeople(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAvgPeopleAge_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.AvgPeopleAge(dataArray));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResult_GDO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_GDO.ShowDialog();
            openFilePath = openFileDialog_GDO.FileName;

            dataArray = ds.LoadFromFile(openFilePath);

            int rows = dataArray.GetLength(0);
            int cols = dataArray.GetLength(1);

            dataGridViewResult_GDO.ColumnCount = cols;
            dataGridViewResult_GDO.RowCount = rows;

            //Задаем ширину столбцов
            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult_GDO.Columns[i].Width = 120;
            }

            string[] header =
            {
                "Таб. номер",
                "Фамилия",
                "Имя",
                "Отчество",
                "Дата рождения",
                "Стаж",
                "Оклад"
            };

            for (int i = 0; i < cols && i < header.Length; i++)
            {
                dataGridViewResult_GDO.Columns[i].HeaderText = header[i];
            }

            //Добавляем данные в dataGridViewResult_GDO
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; (c < cols); c++)
                {
                    dataGridViewResult_GDO.Rows[r].Cells[c].Value = dataArray[r, c];
                }
            }
        }

        private void buttonSearch_GDO_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_GDO.Text;
            string[,] searchResults = ds.Search(dataArray, searchText);

            if (searchResults.GetLength(0) == 0)
            {
                MessageBox.Show($"По запросу '{searchText}' ничего не найдено.", "Результаты поиска",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewResult_GDO.Rows.Clear();
                dataGridViewResult_GDO.Columns.Clear();

                int rows = searchResults.GetLength(0);
                int cols = searchResults.GetLength(1);

                dataGridViewResult_GDO.ColumnCount = cols;
                dataGridViewResult_GDO.RowCount = rows;

                //Задаем ширину столбцов
                for (int i = 0; i < cols; i++)
                {
                    dataGridViewResult_GDO.Columns[i].Width = 120;
                }

                string[] header =
                            {
                            "Таб. номер",
                            "Фамилия",
                            "Имя",
                            "Отчество",
                            "Дата рождения",
                            "Стаж",
                            "Оклад"
                            };

                for (int i = 0; i < cols && i < header.Length; i++)
                {
                    dataGridViewResult_GDO.Columns[i].HeaderText = header[i];
                }

                //Добавляем данные в dataGridViewResult_GDO
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; (c < cols); c++)
                    {
                        dataGridViewResult_GDO.Rows[r].Cells[c].Value = searchResults[r, c];
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog_GDO.FileName = "OutPutFileTask7V16.csv";
                saveFileDialog_GDO.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_GDO.ShowDialog();

                string path = saveFileDialog_GDO.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewResult_GDO.RowCount; //кол-ыо строк
                int cols = dataGridViewResult_GDO.ColumnCount;//кол-во столбцов

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + dataGridViewResult_GDO.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewResult_GDO.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout_GDO about = new FormAbout_GDO();
            about.ShowDialog();
        }

        private void buttonSortExpirienceAscending_GDO_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridViewResult_GDO.RowCount;
            if (dataGridViewResult_GDO.AllowUserToAddRows)
            {
                rowCount--;
            }

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - 1; j++)
                {
                    //Две соседние строки
                    DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                    DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];

                    string exp1Str = row1.Cells[5].Value.ToString() ?? "0";
                    string exp2Str = row2.Cells[5].Value.ToString() ?? "0";

                    int exp1 = 0, exp2 = 0;
                    int.TryParse(exp1Str, out exp1);
                    int.TryParse(exp2Str, out exp2);

                    if (exp1 > exp2)
                    {
                        {
                            for (int col = 0; col < dataGridViewResult_GDO.ColumnCount; col++)
                            {
                                object temp = row1.Cells[col].Value;
                                row1.Cells[col].Value = row2.Cells[col].Value;
                                row2.Cells[col].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void buttonSortSalaryAscending_GDO_Click(object sender, EventArgs e)
        {
            // Просто сортируем строки прямо в DataGridView
            int rowCount = dataGridViewResult_GDO.Rows.Count;

            // Если есть пустая строка для добавления, уменьшаем счетчик
            if (dataGridViewResult_GDO.AllowUserToAddRows)
                rowCount--;

            // Самый тупой способ: пузырьковая сортировка
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - i - 1; j++)
                {
                    // Берем две соседние строки
                    DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                    DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];

                    // Получаем оклад из обеих строк
                    string salary1Str = row1.Cells[6].Value?.ToString() ?? "0";
                    string salary2Str = row2.Cells[6].Value?.ToString() ?? "0";

                    int salary1 = 0, salary2 = 0;
                    int.TryParse(salary1Str, out salary1);
                    int.TryParse(salary2Str, out salary2);

                    // Если первая больше второй - меняем местами
                    if (salary1 > salary2)
                    {
                        // Меняем все столбцы
                        for (int col = 0; col < dataGridViewResult_GDO.ColumnCount; col++)
                        {
                            object temp = row1.Cells[col].Value;
                            row1.Cells[col].Value = row2.Cells[col].Value;
                            row2.Cells[col].Value = temp;
                        }
                    }
                }
            }
        }

        private void buttonSortExpirienceDescending_GDO_Click(object sender, EventArgs e)
        {
            {
                int rowCount = dataGridViewResult_GDO.RowCount;
                if (dataGridViewResult_GDO.AllowUserToAddRows)
                {
                    rowCount--;
                }

                for (int i = 0; i < rowCount - 1; i++)
                {
                    for (int j = 0; j < rowCount - 1; j++)
                    {
                        //Две соседние строки
                        DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                        DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];

                        string exp1Str = row1.Cells[5].Value.ToString() ?? "0";
                        string exp2Str = row2.Cells[5].Value.ToString() ?? "0";

                        int exp1 = 0, exp2 = 0;
                        int.TryParse(exp1Str, out exp1);
                        int.TryParse(exp2Str, out exp2);

                        if (exp1 < exp2)
                        {
                            {
                                for (int col = 0; col < dataGridViewResult_GDO.ColumnCount; col++)
                                {
                                    object temp = row1.Cells[col].Value;
                                    row1.Cells[col].Value = row2.Cells[col].Value;
                                    row2.Cells[col].Value = temp;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonSortSalaryAscendingDescending_GDO_Click(object sender, EventArgs e)
        {
            {
                // Просто сортируем строки прямо в DataGridView
                int rowCount = dataGridViewResult_GDO.Rows.Count;

                // Если есть пустая строка для добавления, уменьшаем счетчик
                if (dataGridViewResult_GDO.AllowUserToAddRows)
                    rowCount--;

                // Самый тупой способ: пузырьковая сортировка
                for (int i = 0; i < rowCount - 1; i++)
                {
                    for (int j = 0; j < rowCount - i - 1; j++)
                    {
                        // Берем две соседние строки
                        DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                        DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];

                        // Получаем оклад из обеих строк
                        string salary1Str = row1.Cells[6].Value?.ToString() ?? "0";
                        string salary2Str = row2.Cells[6].Value?.ToString() ?? "0";

                        int salary1 = 0, salary2 = 0;
                        int.TryParse(salary1Str, out salary1);
                        int.TryParse(salary2Str, out salary2);

                        // Если первая больше второй - меняем местами
                        if (salary1 < salary2)
                        {
                            // Меняем все столбцы
                            for (int col = 0; col < dataGridViewResult_GDO.ColumnCount; col++)
                            {
                                object temp = row1.Cells[col].Value;
                                row1.Cells[col].Value = row2.Cells[col].Value;
                                row2.Cells[col].Value = temp;
                            }
                        }
                    }
                }
            }
        }
    }
}
