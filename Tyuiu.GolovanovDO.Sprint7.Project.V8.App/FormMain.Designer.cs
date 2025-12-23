namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.App
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_GDO = new Panel();
            menuStrip_GDO = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            какПользоватьсяПрограммойToolStripMenuItem = new ToolStripMenuItem();
            panelLeft_GDO = new Panel();
            groupBoxLeft_GDO = new GroupBox();
            buttonChart_GDO = new Button();
            buttonAddRow_GDO = new Button();
            buttonDeleteRow_GDO = new Button();
            textBoxDeletRow_GDO = new TextBox();
            buttonMinYearExperience_GDO = new Button();
            buttonGetAllFullName_GDO = new Button();
            groupBoxResult_GDO = new GroupBox();
            textBoxResult_GDO = new TextBox();
            buttonMaxYearExperience_GDO = new Button();
            buttonAvgPeopleAge_GDO = new Button();
            buttonAvgYearExperience_GDO = new Button();
            buttonMostYoungPeople_GDO = new Button();
            buttonMinSalary_GDO = new Button();
            buttonMostOldPeople_GDO = new Button();
            buttonMaxSalary_GDO = new Button();
            buttonAvgSalary_GDO = new Button();
            panelBottom_GDO = new Panel();
            groupBoxOut_GDO = new GroupBox();
            buttonReturnOriginalTable_GDO = new Button();
            buttonSaveCurrentTable_GDO = new Button();
            chart_GDO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSortSalaryAscendingDescending_GDO = new Button();
            dataGridViewResult_GDO = new DataGridView();
            buttonSortSalaryAscending_GDO = new Button();
            buttonSortExpirienceDescending_GDO = new Button();
            buttonSortExpirienceAscending_GDO = new Button();
            splitterFormMain_GDO = new Splitter();
            panelSearch_GDO = new Panel();
            groupBoxSearch_GDO = new GroupBox();
            buttonSearch_GDO = new Button();
            textBoxSearch_GDO = new TextBox();
            openFileDialog_GDO = new OpenFileDialog();
            saveFileDialog_GDO = new SaveFileDialog();
            labelIndexRow_GDO = new Label();
            labelInfoAboutTable_GDO = new Label();
            panelTop_GDO.SuspendLayout();
            menuStrip_GDO.SuspendLayout();
            panelLeft_GDO.SuspendLayout();
            groupBoxLeft_GDO.SuspendLayout();
            groupBoxResult_GDO.SuspendLayout();
            panelBottom_GDO.SuspendLayout();
            groupBoxOut_GDO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_GDO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GDO).BeginInit();
            panelSearch_GDO.SuspendLayout();
            groupBoxSearch_GDO.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_GDO
            // 
            panelTop_GDO.Controls.Add(menuStrip_GDO);
            panelTop_GDO.Dock = DockStyle.Top;
            panelTop_GDO.Location = new Point(0, 0);
            panelTop_GDO.Name = "panelTop_GDO";
            panelTop_GDO.Size = new Size(1440, 43);
            panelTop_GDO.TabIndex = 0;
            // 
            // menuStrip_GDO
            // 
            menuStrip_GDO.ImageScalingSize = new Size(20, 20);
            menuStrip_GDO.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip_GDO.Location = new Point(0, 0);
            menuStrip_GDO.Name = "menuStrip_GDO";
            menuStrip_GDO.Size = new Size(1440, 28);
            menuStrip_GDO.TabIndex = 1;
            menuStrip_GDO.Text = "menuStrip1";
            menuStrip_GDO.ItemClicked += menuStrip_GDO_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(224, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(224, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, какПользоватьсяПрограммойToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(85, 24);
            справкаToolStripMenuItem.Text = "Справка ";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(309, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // какПользоватьсяПрограммойToolStripMenuItem
            // 
            какПользоватьсяПрограммойToolStripMenuItem.Name = "какПользоватьсяПрограммойToolStripMenuItem";
            какПользоватьсяПрограммойToolStripMenuItem.Size = new Size(309, 26);
            какПользоватьсяПрограммойToolStripMenuItem.Text = "Как пользоваться программой";
            какПользоватьсяПрограммойToolStripMenuItem.Click += какПользоватьсяПрограммойToolStripMenuItem_Click;
            // 
            // panelLeft_GDO
            // 
            panelLeft_GDO.Controls.Add(groupBoxLeft_GDO);
            panelLeft_GDO.Dock = DockStyle.Left;
            panelLeft_GDO.Location = new Point(0, 43);
            panelLeft_GDO.Name = "panelLeft_GDO";
            panelLeft_GDO.Size = new Size(324, 744);
            panelLeft_GDO.TabIndex = 1;
            // 
            // groupBoxLeft_GDO
            // 
            groupBoxLeft_GDO.Controls.Add(labelIndexRow_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonChart_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonAddRow_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonDeleteRow_GDO);
            groupBoxLeft_GDO.Controls.Add(textBoxDeletRow_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonMinYearExperience_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonGetAllFullName_GDO);
            groupBoxLeft_GDO.Controls.Add(groupBoxResult_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonMaxYearExperience_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonAvgPeopleAge_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonAvgYearExperience_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonMostYoungPeople_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonMinSalary_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonMostOldPeople_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonMaxSalary_GDO);
            groupBoxLeft_GDO.Controls.Add(buttonAvgSalary_GDO);
            groupBoxLeft_GDO.Dock = DockStyle.Fill;
            groupBoxLeft_GDO.Location = new Point(0, 0);
            groupBoxLeft_GDO.Name = "groupBoxLeft_GDO";
            groupBoxLeft_GDO.Size = new Size(324, 744);
            groupBoxLeft_GDO.TabIndex = 12;
            groupBoxLeft_GDO.TabStop = false;
            groupBoxLeft_GDO.Text = "Действия";
            // 
            // buttonChart_GDO
            // 
            buttonChart_GDO.BackColor = Color.FromArgb(0, 192, 0);
            buttonChart_GDO.Location = new Point(178, 111);
            buttonChart_GDO.Name = "buttonChart_GDO";
            buttonChart_GDO.Size = new Size(140, 44);
            buttonChart_GDO.TabIndex = 15;
            buttonChart_GDO.Text = "Создать график";
            buttonChart_GDO.UseVisualStyleBackColor = false;
            buttonChart_GDO.Click += buttonChart_GDO_Click;
            // 
            // buttonAddRow_GDO
            // 
            buttonAddRow_GDO.BackColor = Color.FromArgb(255, 192, 192);
            buttonAddRow_GDO.Location = new Point(6, 574);
            buttonAddRow_GDO.Name = "buttonAddRow_GDO";
            buttonAddRow_GDO.Size = new Size(167, 51);
            buttonAddRow_GDO.TabIndex = 14;
            buttonAddRow_GDO.Text = "Добавить строку";
            buttonAddRow_GDO.UseVisualStyleBackColor = false;
            buttonAddRow_GDO.Click += buttonAddRow_GDO_Click;
            // 
            // buttonDeleteRow_GDO
            // 
            buttonDeleteRow_GDO.BackColor = Color.FromArgb(255, 192, 192);
            buttonDeleteRow_GDO.Location = new Point(6, 631);
            buttonDeleteRow_GDO.Name = "buttonDeleteRow_GDO";
            buttonDeleteRow_GDO.Size = new Size(167, 52);
            buttonDeleteRow_GDO.TabIndex = 13;
            buttonDeleteRow_GDO.Text = "Какую строку удалить?";
            buttonDeleteRow_GDO.UseVisualStyleBackColor = false;
            buttonDeleteRow_GDO.Click += buttonDeleteRow_GDO_Click;
            // 
            // textBoxDeletRow_GDO
            // 
            textBoxDeletRow_GDO.Location = new Point(189, 644);
            textBoxDeletRow_GDO.Name = "textBoxDeletRow_GDO";
            textBoxDeletRow_GDO.Size = new Size(125, 27);
            textBoxDeletRow_GDO.TabIndex = 12;
            // 
            // buttonMinYearExperience_GDO
            // 
            buttonMinYearExperience_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonMinYearExperience_GDO.Location = new Point(6, 32);
            buttonMinYearExperience_GDO.Name = "buttonMinYearExperience_GDO";
            buttonMinYearExperience_GDO.Size = new Size(157, 54);
            buttonMinYearExperience_GDO.TabIndex = 1;
            buttonMinYearExperience_GDO.Text = "Наименьший стаж";
            buttonMinYearExperience_GDO.UseVisualStyleBackColor = false;
            buttonMinYearExperience_GDO.Click += buttonMinYearExperience_GDO_Click;
            // 
            // buttonGetAllFullName_GDO
            // 
            buttonGetAllFullName_GDO.BackColor = Color.FromArgb(255, 128, 0);
            buttonGetAllFullName_GDO.Location = new Point(183, 31);
            buttonGetAllFullName_GDO.Name = "buttonGetAllFullName_GDO";
            buttonGetAllFullName_GDO.Size = new Size(126, 63);
            buttonGetAllFullName_GDO.TabIndex = 7;
            buttonGetAllFullName_GDO.Text = "Список всех водителей";
            buttonGetAllFullName_GDO.UseVisualStyleBackColor = false;
            buttonGetAllFullName_GDO.Click += buttonGetAllFullName_GDO_Click;
            // 
            // groupBoxResult_GDO
            // 
            groupBoxResult_GDO.BackColor = Color.FromArgb(128, 255, 255);
            groupBoxResult_GDO.Controls.Add(textBoxResult_GDO);
            groupBoxResult_GDO.Location = new Point(6, 507);
            groupBoxResult_GDO.Name = "groupBoxResult_GDO";
            groupBoxResult_GDO.Size = new Size(157, 61);
            groupBoxResult_GDO.TabIndex = 11;
            groupBoxResult_GDO.TabStop = false;
            groupBoxResult_GDO.Text = "Вывод";
            // 
            // textBoxResult_GDO
            // 
            textBoxResult_GDO.Location = new Point(6, 28);
            textBoxResult_GDO.Name = "textBoxResult_GDO";
            textBoxResult_GDO.Size = new Size(145, 27);
            textBoxResult_GDO.TabIndex = 0;
            // 
            // buttonMaxYearExperience_GDO
            // 
            buttonMaxYearExperience_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonMaxYearExperience_GDO.Location = new Point(6, 92);
            buttonMaxYearExperience_GDO.Name = "buttonMaxYearExperience_GDO";
            buttonMaxYearExperience_GDO.Size = new Size(157, 48);
            buttonMaxYearExperience_GDO.TabIndex = 2;
            buttonMaxYearExperience_GDO.Text = "Наибольший стаж";
            buttonMaxYearExperience_GDO.UseVisualStyleBackColor = false;
            buttonMaxYearExperience_GDO.Click += buttonMaxYearExperience_GDO_Click;
            // 
            // buttonAvgPeopleAge_GDO
            // 
            buttonAvgPeopleAge_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonAvgPeopleAge_GDO.Location = new Point(6, 453);
            buttonAvgPeopleAge_GDO.Name = "buttonAvgPeopleAge_GDO";
            buttonAvgPeopleAge_GDO.Size = new Size(157, 48);
            buttonAvgPeopleAge_GDO.TabIndex = 10;
            buttonAvgPeopleAge_GDO.Text = "Средний возраст водителей";
            buttonAvgPeopleAge_GDO.UseVisualStyleBackColor = false;
            buttonAvgPeopleAge_GDO.Click += buttonAvgPeopleAge_GDO_Click;
            // 
            // buttonAvgYearExperience_GDO
            // 
            buttonAvgYearExperience_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonAvgYearExperience_GDO.Location = new Point(6, 146);
            buttonAvgYearExperience_GDO.Name = "buttonAvgYearExperience_GDO";
            buttonAvgYearExperience_GDO.Size = new Size(157, 48);
            buttonAvgYearExperience_GDO.TabIndex = 3;
            buttonAvgYearExperience_GDO.Text = "Средний стаж вождения";
            buttonAvgYearExperience_GDO.UseVisualStyleBackColor = false;
            buttonAvgYearExperience_GDO.Click += buttonAvgYearExperience_GDO_Click;
            // 
            // buttonMostYoungPeople_GDO
            // 
            buttonMostYoungPeople_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonMostYoungPeople_GDO.Location = new Point(6, 413);
            buttonMostYoungPeople_GDO.Name = "buttonMostYoungPeople_GDO";
            buttonMostYoungPeople_GDO.Size = new Size(157, 34);
            buttonMostYoungPeople_GDO.TabIndex = 9;
            buttonMostYoungPeople_GDO.Text = "Младший водитель";
            buttonMostYoungPeople_GDO.UseVisualStyleBackColor = false;
            buttonMostYoungPeople_GDO.Click += buttonMostYoungPeople_GDO_Click;
            // 
            // buttonMinSalary_GDO
            // 
            buttonMinSalary_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonMinSalary_GDO.Location = new Point(6, 200);
            buttonMinSalary_GDO.Name = "buttonMinSalary_GDO";
            buttonMinSalary_GDO.Size = new Size(157, 49);
            buttonMinSalary_GDO.TabIndex = 4;
            buttonMinSalary_GDO.Text = "Наименьшая зар. плата";
            buttonMinSalary_GDO.UseVisualStyleBackColor = false;
            buttonMinSalary_GDO.Click += buttonMinSalary_GDO_Click;
            // 
            // buttonMostOldPeople_GDO
            // 
            buttonMostOldPeople_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonMostOldPeople_GDO.Location = new Point(6, 364);
            buttonMostOldPeople_GDO.Name = "buttonMostOldPeople_GDO";
            buttonMostOldPeople_GDO.Size = new Size(157, 37);
            buttonMostOldPeople_GDO.TabIndex = 8;
            buttonMostOldPeople_GDO.Text = "Старший водитель";
            buttonMostOldPeople_GDO.UseVisualStyleBackColor = false;
            buttonMostOldPeople_GDO.Click += buttonMostOldPeople_GDO_Click;
            // 
            // buttonMaxSalary_GDO
            // 
            buttonMaxSalary_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonMaxSalary_GDO.Location = new Point(6, 255);
            buttonMaxSalary_GDO.Name = "buttonMaxSalary_GDO";
            buttonMaxSalary_GDO.Size = new Size(157, 49);
            buttonMaxSalary_GDO.TabIndex = 5;
            buttonMaxSalary_GDO.Text = "Наибольшая зар. плата";
            buttonMaxSalary_GDO.UseVisualStyleBackColor = false;
            buttonMaxSalary_GDO.Click += buttonMaxSalary_GDO_Click;
            // 
            // buttonAvgSalary_GDO
            // 
            buttonAvgSalary_GDO.BackColor = Color.FromArgb(192, 255, 255);
            buttonAvgSalary_GDO.Location = new Point(6, 310);
            buttonAvgSalary_GDO.Name = "buttonAvgSalary_GDO";
            buttonAvgSalary_GDO.Size = new Size(157, 48);
            buttonAvgSalary_GDO.TabIndex = 6;
            buttonAvgSalary_GDO.Text = "Средняя зар. плата";
            buttonAvgSalary_GDO.UseVisualStyleBackColor = false;
            buttonAvgSalary_GDO.Click += buttonAvgSalary_GDO_Click;
            // 
            // panelBottom_GDO
            // 
            panelBottom_GDO.Controls.Add(groupBoxOut_GDO);
            panelBottom_GDO.Controls.Add(splitterFormMain_GDO);
            panelBottom_GDO.Dock = DockStyle.Bottom;
            panelBottom_GDO.Location = new Point(324, 135);
            panelBottom_GDO.Name = "panelBottom_GDO";
            panelBottom_GDO.Size = new Size(1116, 652);
            panelBottom_GDO.TabIndex = 2;
            // 
            // groupBoxOut_GDO
            // 
            groupBoxOut_GDO.Controls.Add(labelInfoAboutTable_GDO);
            groupBoxOut_GDO.Controls.Add(buttonReturnOriginalTable_GDO);
            groupBoxOut_GDO.Controls.Add(buttonSaveCurrentTable_GDO);
            groupBoxOut_GDO.Controls.Add(chart_GDO);
            groupBoxOut_GDO.Controls.Add(buttonSortSalaryAscendingDescending_GDO);
            groupBoxOut_GDO.Controls.Add(dataGridViewResult_GDO);
            groupBoxOut_GDO.Controls.Add(buttonSortSalaryAscending_GDO);
            groupBoxOut_GDO.Controls.Add(buttonSortExpirienceDescending_GDO);
            groupBoxOut_GDO.Controls.Add(buttonSortExpirienceAscending_GDO);
            groupBoxOut_GDO.Dock = DockStyle.Fill;
            groupBoxOut_GDO.Location = new Point(4, 0);
            groupBoxOut_GDO.Name = "groupBoxOut_GDO";
            groupBoxOut_GDO.Size = new Size(1112, 652);
            groupBoxOut_GDO.TabIndex = 1;
            groupBoxOut_GDO.TabStop = false;
            groupBoxOut_GDO.Text = "Вывод";
            // 
            // buttonReturnOriginalTable_GDO
            // 
            buttonReturnOriginalTable_GDO.BackColor = Color.FromArgb(255, 255, 128);
            buttonReturnOriginalTable_GDO.Location = new Point(411, 44);
            buttonReturnOriginalTable_GDO.Name = "buttonReturnOriginalTable_GDO";
            buttonReturnOriginalTable_GDO.Size = new Size(152, 58);
            buttonReturnOriginalTable_GDO.TabIndex = 18;
            buttonReturnOriginalTable_GDO.Text = "Вернуть исходную";
            buttonReturnOriginalTable_GDO.UseVisualStyleBackColor = false;
            buttonReturnOriginalTable_GDO.Click += buttonReturnOriginalTable_GDO_Click;
            // 
            // buttonSaveCurrentTable_GDO
            // 
            buttonSaveCurrentTable_GDO.BackColor = Color.FromArgb(255, 255, 128);
            buttonSaveCurrentTable_GDO.Location = new Point(411, 120);
            buttonSaveCurrentTable_GDO.Name = "buttonSaveCurrentTable_GDO";
            buttonSaveCurrentTable_GDO.Size = new Size(152, 58);
            buttonSaveCurrentTable_GDO.TabIndex = 17;
            buttonSaveCurrentTable_GDO.Text = "Сохранить таблицу";
            buttonSaveCurrentTable_GDO.UseVisualStyleBackColor = false;
            buttonSaveCurrentTable_GDO.Click += buttonSaveCurrentTable_GDO_Click;
            // 
            // chart_GDO
            // 
            chartArea1.Name = "ChartArea1";
            chart_GDO.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart_GDO.Legends.Add(legend1);
            chart_GDO.Location = new Point(832, 191);
            chart_GDO.Name = "chart_GDO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_GDO.Series.Add(series1);
            chart_GDO.Size = new Size(577, 449);
            chart_GDO.TabIndex = 16;
            chart_GDO.Text = "chart1";
            // 
            // buttonSortSalaryAscendingDescending_GDO
            // 
            buttonSortSalaryAscendingDescending_GDO.BackColor = Color.FromArgb(128, 255, 128);
            buttonSortSalaryAscendingDescending_GDO.Location = new Point(182, 113);
            buttonSortSalaryAscendingDescending_GDO.Name = "buttonSortSalaryAscendingDescending_GDO";
            buttonSortSalaryAscendingDescending_GDO.Size = new Size(213, 72);
            buttonSortSalaryAscendingDescending_GDO.TabIndex = 15;
            buttonSortSalaryAscendingDescending_GDO.Text = "Сортировать заработную плату по убыванию";
            buttonSortSalaryAscendingDescending_GDO.UseVisualStyleBackColor = false;
            buttonSortSalaryAscendingDescending_GDO.Click += buttonSortSalaryAscendingDescending_GDO_Click;
            // 
            // dataGridViewResult_GDO
            // 
            dataGridViewResult_GDO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_GDO.Location = new Point(2, 191);
            dataGridViewResult_GDO.Name = "dataGridViewResult_GDO";
            dataGridViewResult_GDO.RowHeadersVisible = false;
            dataGridViewResult_GDO.RowHeadersWidth = 51;
            dataGridViewResult_GDO.Size = new Size(824, 458);
            dataGridViewResult_GDO.TabIndex = 0;
            dataGridViewResult_GDO.CellContentClick += dataGridViewResult_GDO_CellContentClick;
            // 
            // buttonSortSalaryAscending_GDO
            // 
            buttonSortSalaryAscending_GDO.BackColor = Color.FromArgb(128, 255, 128);
            buttonSortSalaryAscending_GDO.Location = new Point(182, 35);
            buttonSortSalaryAscending_GDO.Name = "buttonSortSalaryAscending_GDO";
            buttonSortSalaryAscending_GDO.Size = new Size(213, 72);
            buttonSortSalaryAscending_GDO.TabIndex = 13;
            buttonSortSalaryAscending_GDO.Text = "Сортировать заработную плату по возрастанию\r\n";
            buttonSortSalaryAscending_GDO.UseVisualStyleBackColor = false;
            buttonSortSalaryAscending_GDO.Click += buttonSortSalaryAscending_GDO_Click;
            // 
            // buttonSortExpirienceDescending_GDO
            // 
            buttonSortExpirienceDescending_GDO.BackColor = Color.FromArgb(255, 128, 128);
            buttonSortExpirienceDescending_GDO.Location = new Point(6, 35);
            buttonSortExpirienceDescending_GDO.Name = "buttonSortExpirienceDescending_GDO";
            buttonSortExpirienceDescending_GDO.Size = new Size(170, 72);
            buttonSortExpirienceDescending_GDO.TabIndex = 14;
            buttonSortExpirienceDescending_GDO.Text = "Сортировать стаж по убыванию";
            buttonSortExpirienceDescending_GDO.UseVisualStyleBackColor = false;
            buttonSortExpirienceDescending_GDO.Click += buttonSortExpirienceDescending_GDO_Click;
            // 
            // buttonSortExpirienceAscending_GDO
            // 
            buttonSortExpirienceAscending_GDO.BackColor = Color.FromArgb(255, 128, 128);
            buttonSortExpirienceAscending_GDO.Location = new Point(6, 113);
            buttonSortExpirienceAscending_GDO.Name = "buttonSortExpirienceAscending_GDO";
            buttonSortExpirienceAscending_GDO.Size = new Size(170, 72);
            buttonSortExpirienceAscending_GDO.TabIndex = 12;
            buttonSortExpirienceAscending_GDO.Text = "Сортировать стаж по возрастанию\r\n";
            buttonSortExpirienceAscending_GDO.UseVisualStyleBackColor = false;
            buttonSortExpirienceAscending_GDO.Click += buttonSortExpirienceAscending_GDO_Click;
            // 
            // splitterFormMain_GDO
            // 
            splitterFormMain_GDO.Location = new Point(0, 0);
            splitterFormMain_GDO.Name = "splitterFormMain_GDO";
            splitterFormMain_GDO.Size = new Size(4, 652);
            splitterFormMain_GDO.TabIndex = 0;
            splitterFormMain_GDO.TabStop = false;
            // 
            // panelSearch_GDO
            // 
            panelSearch_GDO.Controls.Add(groupBoxSearch_GDO);
            panelSearch_GDO.Dock = DockStyle.Top;
            panelSearch_GDO.Location = new Point(324, 43);
            panelSearch_GDO.Name = "panelSearch_GDO";
            panelSearch_GDO.Size = new Size(1116, 94);
            panelSearch_GDO.TabIndex = 12;
            // 
            // groupBoxSearch_GDO
            // 
            groupBoxSearch_GDO.Controls.Add(buttonSearch_GDO);
            groupBoxSearch_GDO.Controls.Add(textBoxSearch_GDO);
            groupBoxSearch_GDO.Dock = DockStyle.Top;
            groupBoxSearch_GDO.Location = new Point(0, 0);
            groupBoxSearch_GDO.Name = "groupBoxSearch_GDO";
            groupBoxSearch_GDO.Size = new Size(1116, 74);
            groupBoxSearch_GDO.TabIndex = 11;
            groupBoxSearch_GDO.TabStop = false;
            groupBoxSearch_GDO.Text = "Поиск";
            // 
            // buttonSearch_GDO
            // 
            buttonSearch_GDO.BackColor = Color.FromArgb(192, 192, 255);
            buttonSearch_GDO.Location = new Point(744, 23);
            buttonSearch_GDO.Name = "buttonSearch_GDO";
            buttonSearch_GDO.Size = new Size(120, 43);
            buttonSearch_GDO.TabIndex = 1;
            buttonSearch_GDO.Text = "Обновить";
            buttonSearch_GDO.UseVisualStyleBackColor = false;
            buttonSearch_GDO.Click += buttonSearch_GDO_Click;
            // 
            // textBoxSearch_GDO
            // 
            textBoxSearch_GDO.Location = new Point(6, 28);
            textBoxSearch_GDO.Name = "textBoxSearch_GDO";
            textBoxSearch_GDO.Size = new Size(715, 27);
            textBoxSearch_GDO.TabIndex = 0;
            // 
            // openFileDialog_GDO
            // 
            openFileDialog_GDO.FileName = "openFileDialog_GDO";
            // 
            // labelIndexRow_GDO
            // 
            labelIndexRow_GDO.AutoSize = true;
            labelIndexRow_GDO.Location = new Point(194, 601);
            labelIndexRow_GDO.Name = "labelIndexRow_GDO";
            labelIndexRow_GDO.Size = new Size(115, 40);
            labelIndexRow_GDO.TabIndex = 16;
            labelIndexRow_GDO.Text = "Введите номер\r\n       строки";
            // 
            // labelInfoAboutTable_GDO
            // 
            labelInfoAboutTable_GDO.AutoSize = true;
            labelInfoAboutTable_GDO.Location = new Point(569, 122);
            labelInfoAboutTable_GDO.Name = "labelInfoAboutTable_GDO";
            labelInfoAboutTable_GDO.Size = new Size(207, 40);
            labelInfoAboutTable_GDO.TabIndex = 19;
            labelInfoAboutTable_GDO.Text = "После изменения в таблице\r\nвсегда сохранять её.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 787);
            Controls.Add(panelSearch_GDO);
            Controls.Add(panelBottom_GDO);
            Controls.Add(panelLeft_GDO);
            Controls.Add(panelTop_GDO);
            MainMenuStrip = menuStrip_GDO;
            MinimumSize = new Size(1200, 725);
            Name = "FormMain";
            Text = "Спринт 7 / Проект / Вариант 8 / Голованов Д.О / Автотранспортное предприятие";
            Load += Form1_Load;
            panelTop_GDO.ResumeLayout(false);
            panelTop_GDO.PerformLayout();
            menuStrip_GDO.ResumeLayout(false);
            menuStrip_GDO.PerformLayout();
            panelLeft_GDO.ResumeLayout(false);
            groupBoxLeft_GDO.ResumeLayout(false);
            groupBoxLeft_GDO.PerformLayout();
            groupBoxResult_GDO.ResumeLayout(false);
            groupBoxResult_GDO.PerformLayout();
            panelBottom_GDO.ResumeLayout(false);
            groupBoxOut_GDO.ResumeLayout(false);
            groupBoxOut_GDO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_GDO).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GDO).EndInit();
            panelSearch_GDO.ResumeLayout(false);
            groupBoxSearch_GDO.ResumeLayout(false);
            groupBoxSearch_GDO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_GDO;
        private Panel panelLeft_GDO;
        private Panel panelBottom_GDO;
        private Splitter splitterFormMain_GDO;
        private Button buttonMinYearExperience_GDO;
        private Button buttonMaxYearExperience_GDO;
        private Button buttonAvgYearExperience_GDO;
        private Button buttonMinSalary_GDO;
        private Button buttonMaxSalary_GDO;
        private MenuStrip menuStrip_GDO;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button buttonAvgSalary_GDO;
        private Button buttonGetAllFullName_GDO;
        private Button buttonMostYoungPeople_GDO;
        private Button buttonMostOldPeople_GDO;
        private Button buttonAvgPeopleAge_GDO;
        private GroupBox groupBoxOut_GDO;
        private DataGridView dataGridViewResult_GDO;
        private OpenFileDialog openFileDialog_GDO;
        private SaveFileDialog saveFileDialog_GDO;
        private GroupBox groupBoxSearch_GDO;
        private TextBox textBoxSearch_GDO;
        private GroupBox groupBoxResult_GDO;
        private TextBox textBoxResult_GDO;
        private Button buttonSearch_GDO;
        private Button buttonSortSalaryAscending_GDO;
        private Button buttonSortExpirienceAscending_GDO;
        private Button buttonSortExpirienceDescending_GDO;
        private Button buttonSortSalaryAscendingDescending_GDO;
        private ToolStripMenuItem какПользоватьсяПрограммойToolStripMenuItem;
        private GroupBox groupBoxLeft_GDO;
        private Button buttonDeleteRow_GDO;
        private TextBox textBoxDeletRow_GDO;
        private Button buttonAddRow_GDO;
        private Button buttonChart_GDO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_GDO;
        private Panel panelSearch_GDO;
        private Button buttonSaveCurrentTable_GDO;
        private Button buttonReturnOriginalTable_GDO;
        private Label labelIndexRow_GDO;
        private Label labelInfoAboutTable_GDO;
    }
}
