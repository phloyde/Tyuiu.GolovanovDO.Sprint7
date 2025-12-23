using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tyuiu.GolovanovDO.Sprint7.Project.V8.Lib;
namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.App
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        private string[,] dataArray;
        private string[,] savedData;
        private bool isFullNameListShown = false; // нужен для списка ФИО, чтобы понимать, когда он показан


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
                textBoxResult_GDO.Text = Convert.ToString(ds.MinYearExperience(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.MaxYearExperience(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.AvgYearExperience(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.MinSalary(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.MaxSalary(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.AvgSalary(savedData));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetAllFullName_GDO_Click(object sender, EventArgs e)
        {
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Список ФИО уже отображается.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxSearch_GDO.Text))
            {
                MessageBox.Show("Для получения полного списка ФИО очистите поле поиска.",
                               "Поиск активен",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }

            if (savedData == null || savedData.GetLength(0) == 0)
            {
                MessageBox.Show("Сначала загрузите данные!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Берем ФИО из актуальной таблицы savedData
            string[] names = ds.GetAllFullName(savedData);

            dataGridViewResult_GDO.Rows.Clear();
            dataGridViewResult_GDO.Columns.Clear();

            dataGridViewResult_GDO.ColumnCount = 1;
            dataGridViewResult_GDO.Columns[0].Width = 500;
            dataGridViewResult_GDO.Columns[0].HeaderText = "Список ФИО всех водителей";

            foreach (string name in names)
            {
                dataGridViewResult_GDO.Rows.Add(name);
            }

            isFullNameListShown = true;//список показывается 
            textBoxSearch_GDO.Enabled = false;//поле поиска отключам
        }

        private void buttonMostOldPeople_GDO_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_GDO.Text = Convert.ToString(ds.MostOldPeople(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.MostYoungPeople(savedData));
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
                textBoxResult_GDO.Text = Convert.ToString(ds.AvgPeopleAge(savedData));
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

            for (int r = 0; r < rows; r++)//заполняем таблицу
            {
                for (int c = 0; (c < cols); c++)
                {
                    dataGridViewResult_GDO.Rows[r].Cells[c].Value = dataArray[r, c];//помещает значение из dataArray в таблицу
                }
            }
            isFullNameListShown = false;//показывается полная таблица, а не ФИО
        }

        private string[,] GetDataFromDataGridView()//создал, чтобы загружать значчения из таблицы в массив
        {
            int rowCount = dataGridViewResult_GDO.Rows.Count;

            // убираем пустую строку, чтобы не было ошибки о неполных данных
            if (dataGridViewResult_GDO.AllowUserToAddRows && rowCount > 0)
            {
                rowCount--;
            }

            if (rowCount <= 0)
            {
                return new string[0, 0];
            }
            int colCount = dataGridViewResult_GDO.Columns.Count;
            string[,] result = new string[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    result[r, c] = Convert.ToString(dataGridViewResult_GDO.Rows[r].Cells[c].Value) ?? "";//если слева пустая ячейко, то есть не заполнена, то и возвращаем путстую ячейку
                                                                                                         //если в ячейке есть данные, то берем их
                }
            }

            return result;

        }



        private void buttonSearch_GDO_Click(object sender, EventArgs e)
        {
            //точно так же как при открытии файла
            string searchText = textBoxSearch_GDO.Text;

            
            if (savedData == null || savedData.GetLength(0) == 0)
            {
                MessageBox.Show("Таблица пуста!", "Результаты поиска",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(searchText))//строка поиска пуста - показываем всю талицу
            {
                dataGridViewResult_GDO.Rows.Clear();
                dataGridViewResult_GDO.Columns.Clear();

                int rows = savedData.GetLength(0);
                int cols = savedData.GetLength(1);

                dataGridViewResult_GDO.ColumnCount = cols;
                dataGridViewResult_GDO.RowCount = rows;

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

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        dataGridViewResult_GDO.Rows[r].Cells[c].Value = savedData[r, c];
                    }
                }

                isFullNameListShown = false;
                textBoxSearch_GDO.Enabled = true;
                return;
            }

            // если в поиске что-то есть
            string[,] searchResults = ds.Search(savedData, searchText);

            if (searchResults.GetLength(0) == 0)
            {
                MessageBox.Show("Совпадений нет", "Результаты поиска",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Показываем результаты поиска
            dataGridViewResult_GDO.Rows.Clear();
            dataGridViewResult_GDO.Columns.Clear();

            int rowsResult = searchResults.GetLength(0);
            int colsResult = searchResults.GetLength(1);

            dataGridViewResult_GDO.ColumnCount = colsResult;
            dataGridViewResult_GDO.RowCount = rowsResult;

            for (int i = 0; i < colsResult; i++)
            {
                dataGridViewResult_GDO.Columns[i].Width = 120;
            }

            string[] headerResult =
            {
                "Таб. номер",
                "Фамилия",
                "Имя",
                "Отчество",
                "Дата рождения",
                "Стаж",
                "Оклад"
            };

            for (int i = 0; i < colsResult && i < headerResult.Length; i++)
            {
                dataGridViewResult_GDO.Columns[i].HeaderText = headerResult[i];
            }

            for (int r = 0; r < rowsResult; r++)
            {
                for (int c = 0; c < colsResult; c++)
                {
                    dataGridViewResult_GDO.Rows[r].Cells[c].Value = searchResults[r, c];
                }
            }
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog_GDO.FileName = "OutFile.csv";
            saveFileDialog_GDO.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialog_GDO.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string path = saveFileDialog_GDO.FileName;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_GDO.RowCount;
            int cols = dataGridViewResult_GDO.ColumnCount;

            for (int i = 0; i < rows; i++)
            {
                if (dataGridViewResult_GDO.Rows[i].IsNewRow)//пропускаем пустые строки
                {
                    continue;
                }

                string str = "";

                for (int j = 0; j < cols; j++)
                {
                    str = str + Convert.ToString(dataGridViewResult_GDO.Rows[i].Cells[j].Value);

                    if (j != cols - 1)
                    {
                        str = str + ";";
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout_GDO about = new FormAbout_GDO();
            about.ShowDialog();
        }

        private void buttonSortExpirienceAscending_GDO_Click(object sender, EventArgs e)
        {
            //пузырьковым методом по возрастанию
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Операция недоступна в режиме списка ФИО.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int rowCount = dataGridViewResult_GDO.RowCount;
            if (dataGridViewResult_GDO.AllowUserToAddRows)//опять же удаляем пустую строку
            {
                rowCount--;
            }

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - 1; j++)
                {
                    DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                    DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];

                    string exp1Str = row1.Cells[5].Value.ToString() ?? "0";
                    string exp2Str = row2.Cells[5].Value.ToString() ?? "0";

                    int exp1 = 0, exp2 = 0;
                    int.TryParse(exp1Str, out exp1);//чтобы не было ошибок при пустых строках, используем tryparse
                    int.TryParse(exp2Str, out exp2);//присваеваем знач. в exp

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
            //пузырьковым методом по возрастанию
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Операция недоступна в режиме списка ФИО.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int rowCount = dataGridViewResult_GDO.Rows.Count;

            if (dataGridViewResult_GDO.AllowUserToAddRows)
            {
                rowCount--;
            }
                

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - i - 1; j++)
                {
                    DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                    DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];
     
                    string salary1Str = row1.Cells[6].Value?.ToString() ?? "0";
                    string salary2Str = row2.Cells[6].Value?.ToString() ?? "0";

                    int salary1 = 0, salary2 = 0;
                    int.TryParse(salary1Str, out salary1);
                    int.TryParse(salary2Str, out salary2);

                    
                    if (salary1 > salary2)
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

        private void buttonSortExpirienceDescending_GDO_Click(object sender, EventArgs e)
        {
            //пузырьковым методом по убыванию
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Операция недоступна в режиме списка ФИО.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int rowCount = dataGridViewResult_GDO.RowCount;
            if (dataGridViewResult_GDO.AllowUserToAddRows)
            {
                rowCount--;
            }

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - 1; j++)
                {
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

        private void buttonSortSalaryAscendingDescending_GDO_Click(object sender, EventArgs e)
        {
            //пузырьковым методом по убыванию
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Операция недоступна в режиме списка ФИО.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int rowCount = dataGridViewResult_GDO.Rows.Count;

            if (dataGridViewResult_GDO.AllowUserToAddRows)
                rowCount--;

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - i - 1; j++)
                {
                    DataGridViewRow row1 = dataGridViewResult_GDO.Rows[j];
                    DataGridViewRow row2 = dataGridViewResult_GDO.Rows[j + 1];

                    string salary1Str = row1.Cells[6].Value?.ToString() ?? "0";
                    string salary2Str = row2.Cells[6].Value?.ToString() ?? "0";

                    int salary1 = 0, salary2 = 0;
                    int.TryParse(salary1Str, out salary1);
                    int.TryParse(salary2Str, out salary2);

                    if (salary1 < salary2)
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

        private void menuStrip_GDO_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void какПользоватьсяПрограммойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHowToUse howtoUse = new FormHowToUse();
            howtoUse.ShowDialog();

        }

        private void buttonChart_GDO_Click(object sender, EventArgs e)
        {
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Операция недоступна в режиме списка ФИО.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            string[,] currentData = GetDataFromDataGridView();

            //проверяем есть ли данные
            if (currentData == null)
            {
                MessageBox.Show("Сначала загрузите данные!");
                return;
            }

            chart_GDO.Series[0].Points.Clear();

            for (int i = 0; i < currentData.GetLength(0); i++)
            {
                try
                {
                    int experience = int.Parse(currentData[i, 5]); // стаж 
                    int salary = int.Parse(currentData[i, 6]); // зарплата 

                    chart_GDO.Series[0].Points.AddXY(experience, salary);
                }
                catch
                {
                    continue;
                }
            }
            
            chart_GDO.ChartAreas[0].AxisX.Title = "Стаж (лет)";
            chart_GDO.ChartAreas[0].AxisY.Title = "Зарплата (руб.)";
        }

        private void buttonSaveCurrentTable_GDO_Click(object sender, EventArgs e)
        {
            if (isFullNameListShown)
            {
                MessageBox.Show(
                    "Нельзя сохранять таблицу в режиме списка ФИО.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Текущая таблица сохранена.", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            savedData = GetDataFromDataGridView();
        }

        private void buttonReturnOriginalTable_GDO_Click(object sender, EventArgs e)
        {
            if (dataArray == null || dataArray.GetLength(0) == 0)
            {
                MessageBox.Show("Исходные данные не загружены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rows = dataArray.GetLength(0);
            int cols = dataArray.GetLength(1);

            dataGridViewResult_GDO.Rows.Clear();
            dataGridViewResult_GDO.Columns.Clear();
       
            dataGridViewResult_GDO.ColumnCount = cols;
            dataGridViewResult_GDO.RowCount = rows;

            for (int i = 0; i < cols; i++)
                dataGridViewResult_GDO.Columns[i].Width = 120;

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
                dataGridViewResult_GDO.Columns[i].HeaderText = header[i];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewResult_GDO.Rows[r].Cells[c].Value = dataArray[r, c];
                }
            }

            savedData = null;
            isFullNameListShown = false;
            textBoxSearch_GDO.Enabled = true;

            MessageBox.Show("Исходная таблица восстановлена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void buttonAddRow_GDO_Click(object sender, EventArgs e)
        {
            if (isFullNameListShown)
            {
                MessageBox.Show("Нельзя добавлять строки в режиме списка ФИО.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int colCount = dataGridViewResult_GDO.ColumnCount;

            if (colCount == 0)
            {
                MessageBox.Show("Сначала загрузите таблицу!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow newRow = new DataGridViewRow();//создаем новую строку
            newRow.CreateCells(dataGridViewResult_GDO);//я/создаем ячейки как в моей таблице

            dataGridViewResult_GDO.Rows.Insert(0, newRow);//вставляем строку в начало
        }

        
        private void buttonDeleteRow_GDO_Click(object sender, EventArgs e)
        {
            if (isFullNameListShown)
            {
                MessageBox.Show("Нельзя удалять строки в режиме списка ФИО.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string text = textBoxDeletRow_GDO.Text;
            int rowIndex;
     
            try
            {
                rowIndex = Convert.ToInt32(text);
            }
            catch
            {
                MessageBox.Show("Введите корректный номер строки для удаления.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rowIndex < 0 || rowIndex >= dataGridViewResult_GDO.Rows.Count)
            {
                MessageBox.Show("Номер строки вне диапазона.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewResult_GDO.Rows.RemoveAt(rowIndex);
        }
    }
}
