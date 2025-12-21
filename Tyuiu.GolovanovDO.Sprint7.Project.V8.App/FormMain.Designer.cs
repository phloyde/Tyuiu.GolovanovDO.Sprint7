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
            panelTop_GDO = new Panel();
            menuStrip_GDO = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            panelLeft_GDO = new Panel();
            groupBoxResult_GDO = new GroupBox();
            textBoxResult_GDO = new TextBox();
            buttonAvgPeopleAge_GDO = new Button();
            buttonMostYoungPeople_GDO = new Button();
            buttonMostOldPeople_GDO = new Button();
            buttonGetAllFullName_GDO = new Button();
            buttonAvgSalary_GDO = new Button();
            buttonMaxSalary_GDO = new Button();
            buttonMinSalary_GDO = new Button();
            buttonAvgYearExperience_GDO = new Button();
            buttonMaxYearExperience_GDO = new Button();
            buttonMinYearExperience_GDO = new Button();
            panelFill_GDO = new Panel();
            buttonSortSalaryAscendingDescending_GDO = new Button();
            buttonSortExpirienceDescending_GDO = new Button();
            buttonSortSalaryAscending_GDO = new Button();
            buttonSortExpirienceAscending_GDO = new Button();
            groupBoxSearch_GDO = new GroupBox();
            buttonSearch_GDO = new Button();
            textBoxSearch_GDO = new TextBox();
            groupBoxOut_GDO = new GroupBox();
            dataGridViewResult_GDO = new DataGridView();
            splitterFormMain_GDO = new Splitter();
            openFileDialog_GDO = new OpenFileDialog();
            saveFileDialog_GDO = new SaveFileDialog();
            panelTop_GDO.SuspendLayout();
            menuStrip_GDO.SuspendLayout();
            panelLeft_GDO.SuspendLayout();
            groupBoxResult_GDO.SuspendLayout();
            panelFill_GDO.SuspendLayout();
            groupBoxSearch_GDO.SuspendLayout();
            groupBoxOut_GDO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GDO).BeginInit();
            SuspendLayout();
            // 
            // panelTop_GDO
            // 
            panelTop_GDO.Controls.Add(menuStrip_GDO);
            panelTop_GDO.Dock = DockStyle.Top;
            panelTop_GDO.Location = new Point(0, 0);
            panelTop_GDO.Name = "panelTop_GDO";
            panelTop_GDO.Size = new Size(1440, 25);
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
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(85, 24);
            справкаToolStripMenuItem.Text = "Справка ";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(187, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // panelLeft_GDO
            // 
            panelLeft_GDO.Controls.Add(groupBoxResult_GDO);
            panelLeft_GDO.Controls.Add(buttonAvgPeopleAge_GDO);
            panelLeft_GDO.Controls.Add(buttonMostYoungPeople_GDO);
            panelLeft_GDO.Controls.Add(buttonMostOldPeople_GDO);
            panelLeft_GDO.Controls.Add(buttonGetAllFullName_GDO);
            panelLeft_GDO.Controls.Add(buttonAvgSalary_GDO);
            panelLeft_GDO.Controls.Add(buttonMaxSalary_GDO);
            panelLeft_GDO.Controls.Add(buttonMinSalary_GDO);
            panelLeft_GDO.Controls.Add(buttonAvgYearExperience_GDO);
            panelLeft_GDO.Controls.Add(buttonMaxYearExperience_GDO);
            panelLeft_GDO.Controls.Add(buttonMinYearExperience_GDO);
            panelLeft_GDO.Dock = DockStyle.Left;
            panelLeft_GDO.Location = new Point(0, 25);
            panelLeft_GDO.Name = "panelLeft_GDO";
            panelLeft_GDO.Size = new Size(255, 762);
            panelLeft_GDO.TabIndex = 1;
            // 
            // groupBoxResult_GDO
            // 
            groupBoxResult_GDO.Controls.Add(textBoxResult_GDO);
            groupBoxResult_GDO.Location = new Point(12, 591);
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
            // buttonAvgPeopleAge_GDO
            // 
            buttonAvgPeopleAge_GDO.Location = new Point(12, 421);
            buttonAvgPeopleAge_GDO.Name = "buttonAvgPeopleAge_GDO";
            buttonAvgPeopleAge_GDO.Size = new Size(157, 48);
            buttonAvgPeopleAge_GDO.TabIndex = 10;
            buttonAvgPeopleAge_GDO.Text = "Средний возраст водителей";
            buttonAvgPeopleAge_GDO.UseVisualStyleBackColor = true;
            buttonAvgPeopleAge_GDO.Click += buttonAvgPeopleAge_GDO_Click;
            // 
            // buttonMostYoungPeople_GDO
            // 
            buttonMostYoungPeople_GDO.Location = new Point(12, 381);
            buttonMostYoungPeople_GDO.Name = "buttonMostYoungPeople_GDO";
            buttonMostYoungPeople_GDO.Size = new Size(157, 34);
            buttonMostYoungPeople_GDO.TabIndex = 9;
            buttonMostYoungPeople_GDO.Text = "Младший водитель";
            buttonMostYoungPeople_GDO.UseVisualStyleBackColor = true;
            buttonMostYoungPeople_GDO.Click += buttonMostYoungPeople_GDO_Click;
            // 
            // buttonMostOldPeople_GDO
            // 
            buttonMostOldPeople_GDO.Location = new Point(12, 338);
            buttonMostOldPeople_GDO.Name = "buttonMostOldPeople_GDO";
            buttonMostOldPeople_GDO.Size = new Size(157, 37);
            buttonMostOldPeople_GDO.TabIndex = 8;
            buttonMostOldPeople_GDO.Text = "Старший водитель";
            buttonMostOldPeople_GDO.UseVisualStyleBackColor = true;
            buttonMostOldPeople_GDO.Click += buttonMostOldPeople_GDO_Click;
            // 
            // buttonGetAllFullName_GDO
            // 
            buttonGetAllFullName_GDO.Location = new Point(12, 475);
            buttonGetAllFullName_GDO.Name = "buttonGetAllFullName_GDO";
            buttonGetAllFullName_GDO.Size = new Size(157, 49);
            buttonGetAllFullName_GDO.TabIndex = 7;
            buttonGetAllFullName_GDO.Text = "Список всех водителей";
            buttonGetAllFullName_GDO.UseVisualStyleBackColor = true;
            buttonGetAllFullName_GDO.Click += buttonGetAllFullName_GDO_Click;
            // 
            // buttonAvgSalary_GDO
            // 
            buttonAvgSalary_GDO.Location = new Point(12, 284);
            buttonAvgSalary_GDO.Name = "buttonAvgSalary_GDO";
            buttonAvgSalary_GDO.Size = new Size(157, 48);
            buttonAvgSalary_GDO.TabIndex = 6;
            buttonAvgSalary_GDO.Text = "Средняя заработная плата";
            buttonAvgSalary_GDO.UseVisualStyleBackColor = true;
            buttonAvgSalary_GDO.Click += buttonAvgSalary_GDO_Click;
            // 
            // buttonMaxSalary_GDO
            // 
            buttonMaxSalary_GDO.Location = new Point(12, 229);
            buttonMaxSalary_GDO.Name = "buttonMaxSalary_GDO";
            buttonMaxSalary_GDO.Size = new Size(157, 49);
            buttonMaxSalary_GDO.TabIndex = 5;
            buttonMaxSalary_GDO.Text = "Наибольшая заработная плата";
            buttonMaxSalary_GDO.UseVisualStyleBackColor = true;
            buttonMaxSalary_GDO.Click += buttonMaxSalary_GDO_Click;
            // 
            // buttonMinSalary_GDO
            // 
            buttonMinSalary_GDO.Location = new Point(12, 174);
            buttonMinSalary_GDO.Name = "buttonMinSalary_GDO";
            buttonMinSalary_GDO.Size = new Size(157, 49);
            buttonMinSalary_GDO.TabIndex = 4;
            buttonMinSalary_GDO.Text = "Наименьшая заработная плата";
            buttonMinSalary_GDO.UseVisualStyleBackColor = true;
            buttonMinSalary_GDO.Click += buttonMinSalary_GDO_Click;
            // 
            // buttonAvgYearExperience_GDO
            // 
            buttonAvgYearExperience_GDO.Location = new Point(12, 120);
            buttonAvgYearExperience_GDO.Name = "buttonAvgYearExperience_GDO";
            buttonAvgYearExperience_GDO.Size = new Size(157, 48);
            buttonAvgYearExperience_GDO.TabIndex = 3;
            buttonAvgYearExperience_GDO.Text = "Средний стаж вождения";
            buttonAvgYearExperience_GDO.UseVisualStyleBackColor = true;
            buttonAvgYearExperience_GDO.Click += buttonAvgYearExperience_GDO_Click;
            // 
            // buttonMaxYearExperience_GDO
            // 
            buttonMaxYearExperience_GDO.Location = new Point(12, 66);
            buttonMaxYearExperience_GDO.Name = "buttonMaxYearExperience_GDO";
            buttonMaxYearExperience_GDO.Size = new Size(157, 48);
            buttonMaxYearExperience_GDO.TabIndex = 2;
            buttonMaxYearExperience_GDO.Text = "Наибольший стаж вождения";
            buttonMaxYearExperience_GDO.UseVisualStyleBackColor = true;
            buttonMaxYearExperience_GDO.Click += buttonMaxYearExperience_GDO_Click;
            // 
            // buttonMinYearExperience_GDO
            // 
            buttonMinYearExperience_GDO.Location = new Point(12, 6);
            buttonMinYearExperience_GDO.Name = "buttonMinYearExperience_GDO";
            buttonMinYearExperience_GDO.Size = new Size(157, 54);
            buttonMinYearExperience_GDO.TabIndex = 1;
            buttonMinYearExperience_GDO.Text = "Наименьший стаж вождения";
            buttonMinYearExperience_GDO.UseVisualStyleBackColor = true;
            buttonMinYearExperience_GDO.Click += buttonMinYearExperience_GDO_Click;
            // 
            // panelFill_GDO
            // 
            panelFill_GDO.Controls.Add(buttonSortSalaryAscendingDescending_GDO);
            panelFill_GDO.Controls.Add(buttonSortExpirienceDescending_GDO);
            panelFill_GDO.Controls.Add(buttonSortSalaryAscending_GDO);
            panelFill_GDO.Controls.Add(buttonSortExpirienceAscending_GDO);
            panelFill_GDO.Controls.Add(groupBoxSearch_GDO);
            panelFill_GDO.Controls.Add(groupBoxOut_GDO);
            panelFill_GDO.Controls.Add(splitterFormMain_GDO);
            panelFill_GDO.Dock = DockStyle.Fill;
            panelFill_GDO.Location = new Point(255, 25);
            panelFill_GDO.Name = "panelFill_GDO";
            panelFill_GDO.Size = new Size(1185, 762);
            panelFill_GDO.TabIndex = 2;
            // 
            // buttonSortSalaryAscendingDescending_GDO
            // 
            buttonSortSalaryAscendingDescending_GDO.BackColor = Color.FromArgb(128, 255, 128);
            buttonSortSalaryAscendingDescending_GDO.Location = new Point(722, 78);
            buttonSortSalaryAscendingDescending_GDO.Name = "buttonSortSalaryAscendingDescending_GDO";
            buttonSortSalaryAscendingDescending_GDO.Size = new Size(213, 72);
            buttonSortSalaryAscendingDescending_GDO.TabIndex = 15;
            buttonSortSalaryAscendingDescending_GDO.Text = "Сортировать заработную плату по убыванию";
            buttonSortSalaryAscendingDescending_GDO.UseVisualStyleBackColor = false;
            buttonSortSalaryAscendingDescending_GDO.Click += buttonSortSalaryAscendingDescending_GDO_Click;
            // 
            // buttonSortExpirienceDescending_GDO
            // 
            buttonSortExpirienceDescending_GDO.BackColor = Color.FromArgb(255, 128, 128);
            buttonSortExpirienceDescending_GDO.Location = new Point(279, 78);
            buttonSortExpirienceDescending_GDO.Name = "buttonSortExpirienceDescending_GDO";
            buttonSortExpirienceDescending_GDO.Size = new Size(170, 72);
            buttonSortExpirienceDescending_GDO.TabIndex = 14;
            buttonSortExpirienceDescending_GDO.Text = "Сортировать стаж по убыванию";
            buttonSortExpirienceDescending_GDO.UseVisualStyleBackColor = false;
            buttonSortExpirienceDescending_GDO.Click += buttonSortExpirienceDescending_GDO_Click;
            // 
            // buttonSortSalaryAscending_GDO
            // 
            buttonSortSalaryAscending_GDO.BackColor = Color.FromArgb(128, 255, 128);
            buttonSortSalaryAscending_GDO.Location = new Point(503, 78);
            buttonSortSalaryAscending_GDO.Name = "buttonSortSalaryAscending_GDO";
            buttonSortSalaryAscending_GDO.Size = new Size(213, 72);
            buttonSortSalaryAscending_GDO.TabIndex = 13;
            buttonSortSalaryAscending_GDO.Text = "Сортировать сортировать заработную плату по возрастанию\r\n";
            buttonSortSalaryAscending_GDO.UseVisualStyleBackColor = false;
            buttonSortSalaryAscending_GDO.Click += buttonSortSalaryAscending_GDO_Click;
            // 
            // buttonSortExpirienceAscending_GDO
            // 
            buttonSortExpirienceAscending_GDO.BackColor = Color.FromArgb(255, 128, 128);
            buttonSortExpirienceAscending_GDO.Location = new Point(103, 78);
            buttonSortExpirienceAscending_GDO.Name = "buttonSortExpirienceAscending_GDO";
            buttonSortExpirienceAscending_GDO.Size = new Size(170, 72);
            buttonSortExpirienceAscending_GDO.TabIndex = 12;
            buttonSortExpirienceAscending_GDO.Text = "Сортировать стаж по возрастанию\r\n";
            buttonSortExpirienceAscending_GDO.UseVisualStyleBackColor = false;
            buttonSortExpirienceAscending_GDO.Click += buttonSortExpirienceAscending_GDO_Click;
            // 
            // groupBoxSearch_GDO
            // 
            groupBoxSearch_GDO.Controls.Add(buttonSearch_GDO);
            groupBoxSearch_GDO.Controls.Add(textBoxSearch_GDO);
            groupBoxSearch_GDO.Location = new Point(41, 6);
            groupBoxSearch_GDO.Name = "groupBoxSearch_GDO";
            groupBoxSearch_GDO.Size = new Size(921, 66);
            groupBoxSearch_GDO.TabIndex = 11;
            groupBoxSearch_GDO.TabStop = false;
            groupBoxSearch_GDO.Text = "Поиск";
            // 
            // buttonSearch_GDO
            // 
            buttonSearch_GDO.BackColor = Color.FromArgb(192, 192, 255);
            buttonSearch_GDO.Location = new Point(765, 18);
            buttonSearch_GDO.Name = "buttonSearch_GDO";
            buttonSearch_GDO.Size = new Size(120, 43);
            buttonSearch_GDO.TabIndex = 1;
            buttonSearch_GDO.Text = "Обновить";
            buttonSearch_GDO.UseVisualStyleBackColor = false;
            buttonSearch_GDO.Click += buttonSearch_GDO_Click;
            // 
            // textBoxSearch_GDO
            // 
            textBoxSearch_GDO.Location = new Point(6, 26);
            textBoxSearch_GDO.Name = "textBoxSearch_GDO";
            textBoxSearch_GDO.Size = new Size(715, 27);
            textBoxSearch_GDO.TabIndex = 0;
            // 
            // groupBoxOut_GDO
            // 
            groupBoxOut_GDO.Controls.Add(dataGridViewResult_GDO);
            groupBoxOut_GDO.Location = new Point(41, 142);
            groupBoxOut_GDO.Name = "groupBoxOut_GDO";
            groupBoxOut_GDO.Size = new Size(921, 561);
            groupBoxOut_GDO.TabIndex = 1;
            groupBoxOut_GDO.TabStop = false;
            groupBoxOut_GDO.Text = "Вывод";
            // 
            // dataGridViewResult_GDO
            // 
            dataGridViewResult_GDO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_GDO.Location = new Point(0, 26);
            dataGridViewResult_GDO.Name = "dataGridViewResult_GDO";
            dataGridViewResult_GDO.RowHeadersVisible = false;
            dataGridViewResult_GDO.RowHeadersWidth = 51;
            dataGridViewResult_GDO.Size = new Size(970, 651);
            dataGridViewResult_GDO.TabIndex = 0;
            dataGridViewResult_GDO.CellContentClick += dataGridViewResult_GDO_CellContentClick;
            // 
            // splitterFormMain_GDO
            // 
            splitterFormMain_GDO.Location = new Point(0, 0);
            splitterFormMain_GDO.Name = "splitterFormMain_GDO";
            splitterFormMain_GDO.Size = new Size(4, 762);
            splitterFormMain_GDO.TabIndex = 0;
            splitterFormMain_GDO.TabStop = false;
            // 
            // openFileDialog_GDO
            // 
            openFileDialog_GDO.FileName = "openFileDialog_GDO";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 787);
            Controls.Add(panelFill_GDO);
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
            groupBoxResult_GDO.ResumeLayout(false);
            groupBoxResult_GDO.PerformLayout();
            panelFill_GDO.ResumeLayout(false);
            groupBoxSearch_GDO.ResumeLayout(false);
            groupBoxSearch_GDO.PerformLayout();
            groupBoxOut_GDO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GDO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_GDO;
        private Panel panelLeft_GDO;
        private Panel panelFill_GDO;
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
    }
}
